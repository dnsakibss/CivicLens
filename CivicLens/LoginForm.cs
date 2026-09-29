using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CivicLens
{
    public partial class LoginForm : Form
    {
        // ✅ Change server name only if needed
        private readonly SqlConnection con = new SqlConnection(
            "Data Source=LAPTOP-368QC6MP\\SQLEXPRESS;Initial Catalog=CivicLensDB;Integrated Security=True;");

        public LoginForm()
        {
            InitializeComponent();
            // Make sure the password is masked on load
            this.Load += (s, e) => { txtPassword.UseSystemPasswordChar = !chkShowPassword.Checked; };
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = (txtUsername.Text ?? "").Trim();
            string password = txtPassword.Text ?? ""; // plain per your rule

            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("Please enter username.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUsername.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter password.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPassword.Focus();
                return;
            }

            try
            {
                // Use parameters (prevents SQL injection and quoting issues)
                string sql = @"
                    SELECT TOP 1 
                        u.UserId,
                        u.FullName,
                        u.ApprovalStatus,
                        u.IsActive,
                        u.IsDeleted,
                        l.IsLocked,
                        r.RoleName
                    FROM Logins l
                    JOIN Users  u ON u.UserId = l.UserId
                    JOIN Roles  r ON r.RoleId = u.RoleId
                    WHERE l.Username = @u AND l.[Password] = @p;";

                using (var da = new SqlDataAdapter(sql, con))
                {
                    da.SelectCommand.Parameters.AddWithValue("@u", username);
                    da.SelectCommand.Parameters.AddWithValue("@p", password);

                    var dt = new DataTable();
                    da.Fill(dt);

                    if (dt.Rows.Count != 1)
                    {
                        MessageBox.Show("Wrong username or password!!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    var row = dt.Rows[0];

                    // Some schemas might not have all columns — guard reads:
                    bool TryBool(string col, bool d = false) =>
                        dt.Columns.Contains(col) && row[col] != DBNull.Value ? Convert.ToBoolean(row[col]) : d;

                    string TryStr(string col, string d = "") =>
                        dt.Columns.Contains(col) && row[col] != DBNull.Value ? row[col].ToString() : d;

                    int userId = Convert.ToInt32(row["UserId"]);
                    string fullName = TryStr("FullName", "User");
                    string role = TryStr("RoleName", "Citizen");
                    string approval = TryStr("ApprovalStatus", "Approved");

                    bool isLocked = TryBool("IsLocked", false);
                    bool isActive = TryBool("IsActive", true);
                    bool isDeleted = TryBool("IsDeleted", false);

                    // validation checks
                    if (isDeleted)
                    {
                        MessageBox.Show("Account is removed. Contact admin.", "Login");
                        return;
                    }
                    if (!isActive)
                    {
                        MessageBox.Show("Account is disabled. Contact admin.", "Login");
                        return;
                    }
                    if (isLocked)
                    {
                        MessageBox.Show("Account is locked. Contact admin.", "Login");
                        return;
                    }
                    if (!approval.Equals("Approved", StringComparison.OrdinalIgnoreCase))
                    {
                        MessageBox.Show($"Your account is '{approval}'. Wait for admin approval.", "Login");
                        return;
                    }

                    // success → open dashboard and close login when dashboard closes
                    var dash = new DashboardForm(userId, fullName, role);
                    dash.FormClosed += (s, args) => this.Close(); // ensures single-close behavior
                    dash.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Login error: " + ex.Message, "Login");
            }
        }

        private void linkSignup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (var f = new SignupForm())
            {
                f.StartPosition = FormStartPosition.CenterParent;
                f.ShowDialog(this);
            }
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
        }

        // NEW: Forgot password → open UpdatePasswordForm in Forgot mode
        private void linkForgot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                // Open the unified form in Forgot mode (no current password required)
                using (var f = new UpdatePasswordForm(UpdatePasswordMode.Forgot))
                {
                    f.StartPosition = FormStartPosition.CenterParent;
                    f.ShowDialog(this);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to open password reset: " + ex.Message, "Login");
            }
        }
    }
}
