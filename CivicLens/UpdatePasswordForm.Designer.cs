using System;
using System.Windows.Forms;

namespace CivicLens
{
    partial class UpdatePasswordForm
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblTitle;

        private GroupBox grpIdentity;
        private Label lblFullName;
        private TextBox txtFullName;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblPhone;
        private TextBox txtPhone;
        private Label lblRole;
        private ComboBox cmbRole;
        private Label lblUsername;
        private TextBox txtUsername;

        private Label lblCurrentPassword;
        private TextBox txtCurrentPassword;

        private GroupBox grpNewPassword;
        private Label lblNewPassword;
        private TextBox txtNewPassword;
        private Label lblConfirmPassword;
        private TextBox txtConfirmPassword;
        private CheckBox chkShowNew;

        private Button btnUpdate;
        private Button btnCancel;

        // Decorative header (no backend dependency)
        private Panel panelHeader;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

            this.panelHeader = new Panel();
            this.lblTitle = new Label();

            this.grpIdentity = new GroupBox();
            this.lblFullName = new Label();
            this.txtFullName = new TextBox();
            this.lblEmail = new Label();
            this.txtEmail = new TextBox();
            this.lblPhone = new Label();
            this.txtPhone = new TextBox();
            this.lblRole = new Label();
            this.cmbRole = new ComboBox();
            this.lblUsername = new Label();
            this.txtUsername = new TextBox();
            this.lblCurrentPassword = new Label();
            this.txtCurrentPassword = new TextBox();

            this.grpNewPassword = new GroupBox();
            this.lblNewPassword = new Label();
            this.txtNewPassword = new TextBox();
            this.lblConfirmPassword = new Label();
            this.txtConfirmPassword = new TextBox();
            this.chkShowNew = new CheckBox();

            this.btnUpdate = new Button();
            this.btnCancel = new Button();

            // ===== Form =====
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(248, 250, 253);
            this.ClientSize = new System.Drawing.Size(780, 580);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterParent;
            this.Name = "UpdatePasswordForm";
            this.Text = "Update Password";

            // ===== Header =====
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(235, 241, 250);
            this.panelHeader.Dock = DockStyle.Top;
            this.panelHeader.Height = 70;

            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(32, 56, 100);
            this.lblTitle.Location = new System.Drawing.Point(22, 20);
            this.lblTitle.Text = "Update Password";

            this.panelHeader.Controls.Add(this.lblTitle);

            // Common metrics
            var fText = new System.Drawing.Font("Segoe UI", 10F);
            int leftL = 18, leftI = 180, w = 520, h = 28, gap = 38;

            // ===== Identity Group =====
            this.grpIdentity.Text = "Verify your identity";
            this.grpIdentity.Location = new System.Drawing.Point(24, 86);
            this.grpIdentity.Size = new System.Drawing.Size(732, 280);
            this.grpIdentity.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

            int top = 36;

            // Full Name
            this.lblFullName.Location = new System.Drawing.Point(leftL, top);
            this.lblFullName.Size = new System.Drawing.Size(150, 22);
            this.lblFullName.Text = "Full Name *";
            this.txtFullName.Location = new System.Drawing.Point(leftI, top - 2);
            this.txtFullName.Size = new System.Drawing.Size(w, h);
            this.txtFullName.Font = fText;
            this.txtFullName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            top += gap;

            // Email
            this.lblEmail.Location = new System.Drawing.Point(leftL, top);
            this.lblEmail.Size = new System.Drawing.Size(150, 22);
            this.lblEmail.Text = "Email *";
            this.txtEmail.Location = new System.Drawing.Point(leftI, top - 2);
            this.txtEmail.Size = new System.Drawing.Size(w, h);
            this.txtEmail.Font = fText;
            this.txtEmail.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            top += gap;

            // Phone
            this.lblPhone.Location = new System.Drawing.Point(leftL, top);
            this.lblPhone.Size = new System.Drawing.Size(150, 22);
            this.lblPhone.Text = "Phone *";
            this.txtPhone.Location = new System.Drawing.Point(leftI, top - 2);
            this.txtPhone.Size = new System.Drawing.Size(w, h);
            this.txtPhone.Font = fText;
            this.txtPhone.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            top += gap;

            // Role
            this.lblRole.Location = new System.Drawing.Point(leftL, top);
            this.lblRole.Size = new System.Drawing.Size(150, 22);
            this.lblRole.Text = "Role *";
            this.cmbRole.Location = new System.Drawing.Point(leftI, top - 2);
            this.cmbRole.Size = new System.Drawing.Size(280, h + 2);
            this.cmbRole.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbRole.Font = fText;
            top += gap;

            // Username
            this.lblUsername.Location = new System.Drawing.Point(leftL, top);
            this.lblUsername.Size = new System.Drawing.Size(150, 22);
            this.lblUsername.Text = "Username *";
            this.txtUsername.Location = new System.Drawing.Point(leftI, top - 2);
            this.txtUsername.Size = new System.Drawing.Size(380, h);
            this.txtUsername.Font = fText;
            top += gap;

            // Current Password (visibility controlled in code-behind)
            this.lblCurrentPassword.Location = new System.Drawing.Point(leftL, top);
            this.lblCurrentPassword.Size = new System.Drawing.Size(150, 22);
            this.lblCurrentPassword.Text = "Current Password *";
            this.txtCurrentPassword.Location = new System.Drawing.Point(leftI, top - 2);
            this.txtCurrentPassword.Size = new System.Drawing.Size(420, h);
            this.txtCurrentPassword.UseSystemPasswordChar = true;
            this.txtCurrentPassword.Font = fText;
            this.lblCurrentPassword.Visible = false;
            this.txtCurrentPassword.Visible = false;

            this.grpIdentity.Controls.AddRange(new Control[]
            {
                lblFullName, txtFullName,
                lblEmail, txtEmail,
                lblPhone, txtPhone,
                lblRole, cmbRole,
                lblUsername, txtUsername,
                lblCurrentPassword, txtCurrentPassword
            });

            // ===== New Password Group =====
            this.grpNewPassword.Text = "Set new password";
            this.grpNewPassword.Location = new System.Drawing.Point(24, 378);
            this.grpNewPassword.Size = new System.Drawing.Size(732, 140);
            this.grpNewPassword.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

            int top2 = 34;

            // New Password
            this.lblNewPassword.Location = new System.Drawing.Point(leftL, top2);
            this.lblNewPassword.Size = new System.Drawing.Size(150, 22);
            this.lblNewPassword.Text = "New Password *";
            this.txtNewPassword.Location = new System.Drawing.Point(leftI, top2 - 2);
            this.txtNewPassword.Size = new System.Drawing.Size(380, h);
            this.txtNewPassword.UseSystemPasswordChar = true;
            this.txtNewPassword.Font = fText;

            // Show passwords (inline with New)
            this.chkShowNew.Location = new System.Drawing.Point(leftI + 392, top2);
            this.chkShowNew.Size = new System.Drawing.Size(150, 24);
            this.chkShowNew.Text = "Show passwords";
            this.chkShowNew.CheckedChanged += new EventHandler(this.chkShowNew_CheckedChanged);

            // Confirm
            this.lblConfirmPassword.Location = new System.Drawing.Point(leftL, top2 + gap);
            this.lblConfirmPassword.Size = new System.Drawing.Size(160, 22);
            this.lblConfirmPassword.Text = "Confirm Password *";
            this.txtConfirmPassword.Location = new System.Drawing.Point(leftI, top2 + gap - 2);
            this.txtConfirmPassword.Size = new System.Drawing.Size(380, h);
            this.txtConfirmPassword.UseSystemPasswordChar = true;
            this.txtConfirmPassword.Font = fText;

            this.grpNewPassword.Controls.AddRange(new Control[]
            {
                lblNewPassword, txtNewPassword,
                chkShowNew,
                lblConfirmPassword, txtConfirmPassword
            });

            // ===== Buttons =====
            this.btnUpdate.Location = new System.Drawing.Point(474, 528);
            this.btnUpdate.Size = new System.Drawing.Size(120, 34);
            this.btnUpdate.Text = "Update";
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(33, 150, 243);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.FlatStyle = FlatStyle.Flat;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.Click += new EventHandler(this.btnUpdate_Click);

            this.btnCancel.Location = new System.Drawing.Point(604, 528);
            this.btnCancel.Size = new System.Drawing.Size(120, 34);
            this.btnCancel.Text = "Cancel";
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
            this.btnCancel.FlatStyle = FlatStyle.Flat;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnCancel.Click += new EventHandler(this.btnCancel_Click);

            // ===== Add Controls =====
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.grpIdentity);
            this.Controls.Add(this.grpNewPassword);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCancel);
        }
        #endregion
    }
}
