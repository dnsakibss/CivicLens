using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace CivicLens
{
    public partial class AdminCategoriesForm : Form
    {
        // ⬇️ Update instance if needed
        private readonly SqlConnection con =
            new SqlConnection("Data Source=LAPTOP-368QC6MP\\SQLEXPRESS;Initial Catalog=CivicLensDB;Integrated Security=True;");

        // Track editing state (0 = new)
        private int _editingCategoryId = 0;

        // What columns exist in DB?
        private bool _hasDescription;
        private bool _hasIsActive;
        private bool _hasCreatedAt;

        public AdminCategoriesForm()
        {
            InitializeComponent();
            this.Load += AdminCategoriesForm_Load;
        }

        private void AdminCategoriesForm_Load(object sender, EventArgs e)
        {
            try
            {
                DetectCategoryColumns();

                // Hide/disable unsupported editor fields to avoid confusion
                if (!_hasDescription) { txtDescription.Enabled = false; TextBoxExtensions.PlaceholderTextSafe(txtDescription, "Not supported by DB"); }
                if (!_hasIsActive) { chkActive.Enabled = false; chkActive.Text = "Active (not supported by DB)"; }

                LoadGridFromDb();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Load error: " + ex.Message, "CivicLens");
            }
        }

        // ===================== Detection =====================
        private void DetectCategoryColumns()
        {
            var cols = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

            string sql =
                "SELECT COLUMN_NAME " +
                "FROM INFORMATION_SCHEMA.COLUMNS " +
                "WHERE TABLE_NAME='Categories'";

            using (var da = new SqlDataAdapter(sql, con))
            {
                var dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow r in dt.Rows)
                    cols.Add(Convert.ToString(r["COLUMN_NAME"]));
            }

            _hasDescription = cols.Contains("Description");
            _hasIsActive = cols.Contains("IsActive");
            _hasCreatedAt = cols.Contains("CreatedAt");
        }

        // ===================== Search / Refresh =====================
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try { LoadGridFromDb(); }
            catch (Exception ex) { MessageBox.Show("Search error: " + ex.Message, "CivicLens"); }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            try { LoadGridFromDb(); }
            catch (Exception ex) { MessageBox.Show("Refresh error: " + ex.Message, "CivicLens"); }
        }

        // ===================== Save / Clear =====================
        private void btnSave_Click(object sender, EventArgs e)
        {
            var name = (txtName.Text ?? "").Trim();
            var description = (txtDescription.Text ?? "").Trim();
            var active = chkActive.Checked;

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Name is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return;
            }

            try
            {
                if (_editingCategoryId == 0)
                {
                    // CREATE (build column list dynamically)
                    var cols = new List<string> { "CategoryName" };
                    var vals = new List<string> { "'" + Escape(name) + "'" };

                    if (_hasDescription)
                    {
                        cols.Add("Description");
                        vals.Add(string.IsNullOrWhiteSpace(description) ? "NULL" : "N'" + Escape(description) + "'");
                    }
                    if (_hasIsActive)
                    {
                        cols.Add("IsActive");
                        vals.Add(active ? "1" : "0");
                    }
                    if (_hasCreatedAt)
                    {
                        cols.Add("CreatedAt");
                        vals.Add("SYSUTCDATETIME()");
                    }

                    string sql = "INSERT INTO Categories(" + string.Join(",", cols) + ") VALUES (" + string.Join(",", vals) + ")";
                    using (var cmd = new SqlCommand(sql, con))
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }

                    MessageBox.Show("Category created.", "CivicLens", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // UPDATE (only update existing columns)
                    var sets = new List<string> { "CategoryName='" + Escape(name) + "'" };

                    if (_hasDescription)
                        sets.Add("Description=" + (string.IsNullOrWhiteSpace(description) ? "NULL" : "N'" + Escape(description) + "'"));

                    if (_hasIsActive)
                        sets.Add("IsActive=" + (active ? "1" : "0"));

                    string sql = "UPDATE Categories SET " + string.Join(", ", sets) + " WHERE CategoryId=" + _editingCategoryId;

                    using (var cmd = new SqlCommand(sql, con))
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }

                    MessageBox.Show("Category updated.", "CivicLens", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                ClearEditor();
                LoadGridFromDb();
            }
            catch (Exception ex)
            {
                if (con.State == ConnectionState.Open) con.Close();
                MessageBox.Show("Save failed: " + ex.Message, "CivicLens");
            }
        }

        private void btnClear_Click(object sender, EventArgs e) => ClearEditor();

        private void ClearEditor()
        {
            _editingCategoryId = 0;
            txtName.Clear();
            txtDescription.Clear();
            chkActive.Checked = true;
            txtName.Focus();
        }

        // ===================== Grid actions =====================
        private void dgvCategories_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var col = dgvCategories.Columns[e.ColumnIndex].Name;
            var row = dgvCategories.Rows[e.RowIndex];

            var id = Convert.ToInt32(row.Cells["colCategoryId"].Value);
            var name = row.Cells["colCategoryName"].Value?.ToString();
            var desc = row.Cells["colDescription"].Value?.ToString();
            var activeStr = row.Cells["colIsActive"].Value?.ToString();
            bool isActive = string.Equals(activeStr, "Active", StringComparison.OrdinalIgnoreCase);

            if (col == "colEdit")
            {
                _editingCategoryId = id;
                txtName.Text = name;
                txtDescription.Text = desc;
                chkActive.Checked = isActive;
                txtName.Focus();
                return;
            }

            if (col == "colToggleActive")
            {
                if (!_hasIsActive)
                {
                    MessageBox.Show("Your Categories table has no 'IsActive' column. Toggle is not supported.", "CivicLens");
                    return;
                }

                try
                {
                    string sql = "UPDATE Categories SET IsActive = " + (isActive ? "0" : "1") + " WHERE CategoryId = " + id;
                    using (var cmd = new SqlCommand(sql, con))
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                    LoadGridFromDb();
                }
                catch (Exception ex)
                {
                    if (con.State == ConnectionState.Open) con.Close();
                    MessageBox.Show("Toggle failed: " + ex.Message, "CivicLens");
                }
                return;
            }

            if (col == "colDelete")
            {
                var ok = MessageBox.Show($"Delete category #{id} ({name})?",
                    "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (ok != DialogResult.Yes) return;

                try
                {
                    string sql = "DELETE FROM Categories WHERE CategoryId = " + id;
                    using (var cmd = new SqlCommand(sql, con))
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                    LoadGridFromDb();
                }
                catch (SqlException sx)
                {
                    if (con.State == ConnectionState.Open) con.Close();
                    MessageBox.Show(
                        "Delete failed. This category might be referenced by other records.\n\nDetails: " + sx.Message,
                        "CivicLens", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (Exception ex)
                {
                    if (con.State == ConnectionState.Open) con.Close();
                    MessageBox.Show("Delete failed: " + ex.Message, "CivicLens");
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e) => this.Close();

        // ===================== Data loading =====================
        private void LoadGridFromDb()
        {
            dgvCategories.Rows.Clear();

            string q = (txtSearch.Text ?? "").Trim();
            string where = "WHERE 1=1 ";
            if (!string.IsNullOrWhiteSpace(q))
            {
                string eq = Escape(q);
                var likePieces = new List<string> { "c.CategoryName LIKE '%" + eq + "%'" };
                if (_hasDescription)
                    likePieces.Add("ISNULL(c.Description,'') LIKE N'%" + eq + "%'");
                where += "AND (" + string.Join(" OR ", likePieces) + ") ";
            }

            string select =
                "c.CategoryId, " +
                "c.CategoryName, " +
                (_hasDescription ? "ISNULL(c.Description,'')" : "''") + " AS DescriptionText, " +
                (_hasIsActive ? "CASE WHEN c.IsActive=1 THEN 'Active' ELSE 'Inactive' END" : "''") + " AS ActiveText, " +
                (_hasCreatedAt ? "c.CreatedAt" : "GETUTCDATE()") + " AS CreatedAtVal ";

            string sql =
                "SELECT " + select +
                "FROM Categories c " +
                where +
                "ORDER BY " + (_hasCreatedAt ? "c.CreatedAt DESC, " : "") + "c.CategoryName ASC";

            using (var da = new SqlDataAdapter(sql, con))
            {
                var dt = new DataTable();
                da.Fill(dt);

                foreach (DataRow r in dt.Rows)
                {
                    dgvCategories.Rows.Add(
                        r["CategoryId"],
                        r["CategoryName"],
                        Convert.ToString(r["DescriptionText"]),
                        Convert.ToString(r["ActiveText"]),
                        Convert.ToDateTime(r["CreatedAtVal"]).ToString("yyyy-MM-dd HH:mm")
                    );
                }
            }
        }

        // ===================== Util =====================
        private static string Escape(string s) => s?.Replace("'", "''") ?? "";
    }

    internal static class TextBoxExtensions
    {
        /// <summary>
        /// Sets PlaceholderText on newer WinForms via reflection; no-op on older targets.
        /// </summary>
        public static void PlaceholderTextSafe(TextBox tb, string text)
        {
            try
            {
                var prop = typeof(TextBox).GetProperty("PlaceholderText");
                if (prop != null && prop.CanWrite)
                {
                    prop.SetValue(tb, text, null);
                }
            }
            catch
            {
                // ignore – not supported on this runtime
            }
        }
    }
}
