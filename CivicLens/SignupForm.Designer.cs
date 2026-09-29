using System;
using System.Windows.Forms;

namespace CivicLens
{
    partial class SignupForm
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblTitle;
        private Label lblFullName;
        private TextBox txtFullName;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblPhone;
        private TextBox txtPhone;
        private Label lblAddress;
        private TextBox txtAddress;
        private Label lblRole;
        private ComboBox cmbRole;
        private Label lblUsername;
        private TextBox txtUsername;
        private Label lblPassword;
        private TextBox txtPassword;
        private Label lblConfirm;
        private TextBox txtConfirm;
        private Button btnSignup;
        private Button btnCancel;

        // Decorative header strip (no backend dependency)
        private Panel panelHeader;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();

            this.lblFullName = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();

            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();

            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();

            this.lblAddress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();

            this.lblRole = new System.Windows.Forms.Label();
            this.cmbRole = new System.Windows.Forms.ComboBox();

            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();

            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();

            this.lblConfirm = new System.Windows.Forms.Label();
            this.txtConfirm = new System.Windows.Forms.TextBox();

            this.btnSignup = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();

            // ===== Form =====
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(248, 250, 253);
            this.ClientSize = new System.Drawing.Size(560, 620);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sign up - CivicLens";
            this.AcceptButton = this.btnSignup;
            this.CancelButton = this.btnCancel;

            // ===== Header =====
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(235, 241, 250);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Height = 68;

            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(32, 56, 100);
            this.lblTitle.Location = new System.Drawing.Point(22, 18);
            this.lblTitle.Text = "Create Account";
            this.panelHeader.Controls.Add(this.lblTitle);

            // layout metrics
            int leftLabel = 36;
            int leftText = 168;
            int widthText = 350;
            int rowH = 30;
            int gap = 40;
            int top = 92;

            // Common text style
            var txtFont = new System.Drawing.Font("Segoe UI", 10F);

            // ===== Full Name =====
            this.lblFullName.Location = new System.Drawing.Point(leftLabel, top);
            this.lblFullName.Size = new System.Drawing.Size(120, 22);
            this.lblFullName.Text = "Full Name:";
            this.txtFullName.Location = new System.Drawing.Point(leftText, top - 2);
            this.txtFullName.Size = new System.Drawing.Size(widthText, rowH);
            this.txtFullName.Font = txtFont;
            this.txtFullName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            top += gap;

            // ===== Email =====
            this.lblEmail.Location = new System.Drawing.Point(leftLabel, top);
            this.lblEmail.Size = new System.Drawing.Size(120, 22);
            this.lblEmail.Text = "Email:";
            this.txtEmail.Location = new System.Drawing.Point(leftText, top - 2);
            this.txtEmail.Size = new System.Drawing.Size(widthText, rowH);
            this.txtEmail.Font = txtFont;
            this.txtEmail.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            top += gap;

            // ===== Phone =====
            this.lblPhone.Location = new System.Drawing.Point(leftLabel, top);
            this.lblPhone.Size = new System.Drawing.Size(120, 22);
            this.lblPhone.Text = "Phone:";
            this.txtPhone.Location = new System.Drawing.Point(leftText, top - 2);
            this.txtPhone.Size = new System.Drawing.Size(widthText, rowH);
            this.txtPhone.Font = txtFont;
            this.txtPhone.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            top += gap;

            // ===== Address =====
            this.lblAddress.Location = new System.Drawing.Point(leftLabel, top);
            this.lblAddress.Size = new System.Drawing.Size(120, 22);
            this.lblAddress.Text = "Address:";
            this.txtAddress.Location = new System.Drawing.Point(leftText, top - 2);
            this.txtAddress.Size = new System.Drawing.Size(widthText, rowH);
            this.txtAddress.Font = txtFont;
            this.txtAddress.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            top += gap;

            // ===== Role =====
            this.lblRole.Location = new System.Drawing.Point(leftLabel, top);
            this.lblRole.Size = new System.Drawing.Size(120, 22);
            this.lblRole.Text = "Role:";
            this.cmbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRole.Items.AddRange(new object[] { "Citizen", "Moderator", "Police", "Journalist" });
            this.cmbRole.Location = new System.Drawing.Point(leftText, top - 2);
            this.cmbRole.Size = new System.Drawing.Size(widthText, rowH);
            this.cmbRole.Font = txtFont;
            this.cmbRole.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            top += gap;

            // ===== Username =====
            this.lblUsername.Location = new System.Drawing.Point(leftLabel, top);
            this.lblUsername.Size = new System.Drawing.Size(120, 22);
            this.lblUsername.Text = "Username:";
            this.txtUsername.Location = new System.Drawing.Point(leftText, top - 2);
            this.txtUsername.Size = new System.Drawing.Size(widthText, rowH);
            this.txtUsername.Font = txtFont;
            this.txtUsername.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            top += gap;

            // ===== Password =====
            this.lblPassword.Location = new System.Drawing.Point(leftLabel, top);
            this.lblPassword.Size = new System.Drawing.Size(120, 22);
            this.lblPassword.Text = "Password:";
            this.txtPassword.Location = new System.Drawing.Point(leftText, top - 2);
            this.txtPassword.Size = new System.Drawing.Size(widthText, rowH);
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.Font = txtFont;
            this.txtPassword.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            top += gap;

            // ===== Confirm Password =====
            this.lblConfirm.Location = new System.Drawing.Point(leftLabel, top);
            this.lblConfirm.Size = new System.Drawing.Size(130, 22);
            this.lblConfirm.Text = "Confirm Password:";
            this.txtConfirm.Location = new System.Drawing.Point(leftText, top - 2);
            this.txtConfirm.Size = new System.Drawing.Size(widthText, rowH);
            this.txtConfirm.UseSystemPasswordChar = true;
            this.txtConfirm.Font = txtFont;
            this.txtConfirm.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            top += gap + 6;

            // ===== Buttons =====
            this.btnSignup.Location = new System.Drawing.Point(leftText, top);
            this.btnSignup.Size = new System.Drawing.Size(140, 36);
            this.btnSignup.Text = "Sign Up";
            this.btnSignup.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnSignup.BackColor = System.Drawing.Color.FromArgb(33, 150, 243);
            this.btnSignup.ForeColor = System.Drawing.Color.White;
            this.btnSignup.FlatStyle = FlatStyle.Flat;
            this.btnSignup.FlatAppearance.BorderSize = 0;
            this.btnSignup.Click += new System.EventHandler(this.btnSignup_Click);

            this.btnCancel.Location = new System.Drawing.Point(leftText + 160, top);
            this.btnCancel.Size = new System.Drawing.Size(140, 36);
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
            this.btnCancel.FlatStyle = FlatStyle.Flat;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            // ===== Add Controls =====
            this.Controls.Add(this.panelHeader);

            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.txtFullName);

            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);

            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtPhone);

            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtAddress);

            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.cmbRole);

            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtUsername);

            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtPassword);

            this.Controls.Add(this.lblConfirm);
            this.Controls.Add(this.txtConfirm);

            this.Controls.Add(this.btnSignup);
            this.Controls.Add(this.btnCancel);
        }
        #endregion
    }
}
