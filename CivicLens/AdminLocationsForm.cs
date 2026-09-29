using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace CivicLens
{
    public partial class AdminLocationsForm : Form
    {
        private readonly SqlConnection con =
            new SqlConnection("Data Source=LAPTOP-368QC6MP\\SQLEXPRESS;Initial Catalog=CivicLensDB;Integrated Security=True;");

        // track editing state (0 = new)
        private int _editingLocationId = 0;

        // Which columns exist in DB?
        private bool _hasIsActive;   // used only for read-only display in grid
        private bool _hasCreatedAt;

        public AdminLocationsForm()
        {
            InitializeComponent();

            // Ensure events are wired even if designer comments them
            this.Load += AdminLocationsForm_Load;
            this.btnSearch.Click += btnSearch_Click;
            this.btnRefresh.Click += btnRefresh_Click;
            this.btnSave.Click += btnSave_Click;
            this.btnClear.Click += btnClear_Click;
            this.dgvLocations.CellContentClick += dgvLocations_CellContentClick;
            this.btnClose.Click += btnClose_Click;
        }

        private void AdminLocationsForm_Load(object sender, EventArgs e)
        {
            try
            {
                DetectLocationColumns();
                LoadGridFromDb();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Load error: " + ex.Message, "CivicLens");
            }
        }

        // =============== Detection ===============
        private void DetectLocationColumns()
        {
            var cols = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

            string sql =
                "SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME='Locations'";

            using (var da = new SqlDataAdapter(sql, con))
            {
                var dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow r in dt.Rows)
                    cols.Add(Convert.ToString(r["COLUMN_NAME"]));
            }

            _hasIsActive = cols.Contains("IsActive");
            _hasCreatedAt = cols.Contains("CreatedAt");
        }

        // =============== Search / Refresh ===============
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

        // =============== Save / Clear ===============
        private void btnSave_Click(object sender, EventArgs e)
        {
            var district = (txtDistrict.Text ?? "").Trim();
            var city = (txtCity.Text ?? "").Trim();
            var area = (txtArea.Text ?? "").Trim();

            if (string.IsNullOrWhiteSpace(district))
            {
                MessageBox.Show("District is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDistrict.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(city))
            {
                MessageBox.Show("City is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCity.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(area))
            {
                MessageBox.Show("Area is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtArea.Focus();
                return;
            }

            try
            {
                if (_editingLocationId == 0)
                {
                    // INSERT (no Active flag here)
                    var cols = new List<string> { "District", "City", "Area" };
                    var vals = new List<string> {
                        "N'" + Escape(district) + "'",
                        "N'" + Escape(city) + "'",
                        "N'" + Escape(area) + "'"
                    };

                    if (_hasCreatedAt)
                    {
                        cols.Add("CreatedAt");
                        vals.Add("SYSUTCDATETIME()");
                    }

                    string sql = "INSERT INTO Locations(" + string.Join(",", cols) + ") VALUES (" + string.Join(",", vals) + ")";
                    using (var cmd = new SqlCommand(sql, con))
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }

                    MessageBox.Show("Location created.", "CivicLens", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // UPDATE (no Active flag)
                    var sets = new List<string>
                    {
                        "District=N'" + Escape(district) + "'",
                        "City=N'" + Escape(city) + "'",
                        "Area=N'" + Escape(area) + "'"
                    };

                    string sql = "UPDATE Locations SET " + string.Join(", ", sets) + " WHERE LocationId=" + _editingLocationId;

                    using (var cmd = new SqlCommand(sql, con))
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }

                    MessageBox.Show("Location updated.", "CivicLens", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            _editingLocationId = 0;
            txtDistrict.Clear();
            txtCity.Clear();
            txtArea.Clear();
            txtDistrict.Focus();
        }

        // =============== Grid actions ===============
        private void dgvLocations_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string col = dgvLocations.Columns[e.ColumnIndex].Name;
            var row = dgvLocations.Rows[e.RowIndex];

            int id = Convert.ToInt32(row.Cells["colLocationId"].Value);
            string district = Convert.ToString(row.Cells["colDistrict"].Value);
            string city = Convert.ToString(row.Cells["colCity"].Value);
            string area = Convert.ToString(row.Cells["colArea"].Value);

            if (col == "colEdit")
            {
                _editingLocationId = id;
                txtDistrict.Text = district;
                txtCity.Text = city;
                txtArea.Text = area;
                txtDistrict.Focus();
                return;
            }

            if (col == "colDelete")
            {
                var ok = MessageBox.Show($"Delete location #{id} ({district}/{city}/{area})?",
                    "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (ok != DialogResult.Yes) return;

                try
                {
                    string sql = "DELETE FROM Locations WHERE LocationId=" + id;
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
                        "Delete failed. This location may be referenced by other records.\n\nDetails: " + sx.Message,
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

        // =============== Data loading ===============
        private void LoadGridFromDb()
        {
            dgvLocations.Rows.Clear();

            string q = (txtSearch.Text ?? "").Trim();
            string where = "WHERE 1=1 ";
            if (!string.IsNullOrWhiteSpace(q))
            {
                string eq = Escape(q);
                where += "AND ( " +
                         "ISNULL(l.District,'') + ' ' + ISNULL(l.City,'') + ' ' + ISNULL(l.Area,'') LIKE N'%" + eq + "%' " +
                         ") ";
            }

            string select =
                "l.LocationId, " +
                "ISNULL(l.District,'') AS District, " +
                "ISNULL(l.City,'') AS City, " +
                "ISNULL(l.Area,'') AS Area, " +
                (_hasIsActive ? "CASE WHEN l.IsActive=1 THEN 'Active' ELSE 'Inactive' END" : "''") + " AS ActiveText, " +
                (_hasCreatedAt ? "l.CreatedAt" : "GETUTCDATE()") + " AS CreatedAtVal ";

            string sql =
                "SELECT " + select +
                "FROM Locations l " +
                where +
                "ORDER BY l.District ASC, l.City ASC, l.Area ASC";

            using (var da = new SqlDataAdapter(sql, con))
            {
                var dt = new DataTable();
                da.Fill(dt);

                foreach (DataRow r in dt.Rows)
                {
                    dgvLocations.Rows.Add(
                        r["LocationId"],
                        r["District"],
                        r["City"],
                        r["Area"],
                        Convert.ToString(r["ActiveText"]), // will be empty if no IsActive column in DB
                        Convert.ToDateTime(r["CreatedAtVal"]).ToString("yyyy-MM-dd HH:mm")
                    );
                }
            }
        }

        // =============== Util ===============
        private static string Escape(string s) => s?.Replace("'", "''") ?? "";
    }
}
