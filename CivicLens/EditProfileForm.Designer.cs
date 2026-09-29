using System;
using System.Windows.Forms;

namespace CivicLens
{
    partial class EditProfileForm
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

        private Label lblPassword;
        private TextBox txtPassword;
        private Button btnChangePassword;   // stays

        private Button btnSave;
        private Button btnCancel;

        // kept for backend compatibility, but hidden
        private Button btnUploadPhoto;
        private PictureBox pbAvatar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

            this.lblTitle = new Label();

            this.lblFullName = new Label();
            this.txtFullName = new TextBox();

            this.lblEmail = new Label();
            this.txtEmail = new TextBox();

            this.lblPhone = new Label();
            this.txtPhone = new TextBox();

            this.lblAddress = new Label();
            this.txtAddress = new TextBox();

            this.lblPassword = new Label();
            this.txtPassword = new TextBox();
            this.btnChangePassword = new Button();

            this.btnSave = new Button();
            this.btnCancel = new Button();

            // hidden-but-initialized controls (backend-safe)
            this.btnUploadPhoto = new Button();
            this.pbAvatar = new PictureBox();

            // ===== Form =====
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(248, 250, 253);
            this.ClientSize = new System.Drawing.Size(720, 420);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Edit Profile - CivicLens";

            // make Enter = Save, Esc = Cancel
            this.AcceptButton = this.btnSave;
            this.CancelButton = this.btnCancel;

            // ===== Title =====
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(24, 18);
            this.lblTitle.Text = "Edit My Profile";

            // ---- A soft container for inputs (local variable; no backend impact) ----
            GroupBox grp = new GroupBox();
            grp.Text = "Profile";
            grp.BackColor = System.Drawing.Color.White;
            grp.Location = new System.Drawing.Point(20, 58);
            grp.Size = new System.Drawing.Size(680, 280);
            grp.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grp.Padding = new Padding(14);

            // layout metrics inside group
            int leftLabel = 24;
            int leftText = 150;
            int widthText = 480;
            int h = 28;
            int gap = 40;
            int top = 36;

            // Full Name
            this.lblFullName.Location = new System.Drawing.Point(leftLabel, top);
            this.lblFullName.Size = new System.Drawing.Size(120, 22);
            this.lblFullName.Text = "Full Name:";
            this.lblFullName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtFullName.Location = new System.Drawing.Point(leftText, top - 4);
            this.txtFullName.Size = new System.Drawing.Size(widthText, h);
            this.txtFullName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.txtFullName.BorderStyle = BorderStyle.FixedSingle;
            this.txtFullName.TabIndex = 0;
            top += gap;

            // Email
            this.lblEmail.Location = new System.Drawing.Point(leftLabel, top);
            this.lblEmail.Size = new System.Drawing.Size(120, 22);
            this.lblEmail.Text = "Email:";
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtEmail.Location = new System.Drawing.Point(leftText, top - 4);
            this.txtEmail.Size = new System.Drawing.Size(widthText, h);
            this.txtEmail.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.txtEmail.BorderStyle = BorderStyle.FixedSingle;
            this.txtEmail.TabIndex = 1;
            top += gap;

            // Phone
            this.lblPhone.Location = new System.Drawing.Point(leftLabel, top);
            this.lblPhone.Size = new System.Drawing.Size(120, 22);
            this.lblPhone.Text = "Phone:";
            this.lblPhone.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPhone.Location = new System.Drawing.Point(leftText, top - 4);
            this.txtPhone.Size = new System.Drawing.Size(widthText, h);
            this.txtPhone.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.txtPhone.BorderStyle = BorderStyle.FixedSingle;
            this.txtPhone.TabIndex = 2;
            top += gap;

            // Address
            this.lblAddress.Location = new System.Drawing.Point(leftLabel, top);
            this.lblAddress.Size = new System.Drawing.Size(120, 22);
            this.lblAddress.Text = "Address:";
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtAddress.Location = new System.Drawing.Point(leftText, top - 4);
            this.txtAddress.Size = new System.Drawing.Size(widthText, h);
            this.txtAddress.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.txtAddress.BorderStyle = BorderStyle.FixedSingle;
            this.txtAddress.TabIndex = 3;
            top += gap;

            // Password (for verifying profile save)
            this.lblPassword.Location = new System.Drawing.Point(leftLabel, top);
            this.lblPassword.Size = new System.Drawing.Size(120, 22);
            this.lblPassword.Text = "Password:";
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 10F);

            this.txtPassword.Location = new System.Drawing.Point(leftText, top - 4);
            this.txtPassword.Size = new System.Drawing.Size(widthText - 168, h);
            this.txtPassword.PasswordChar = '•';
            this.txtPassword.BorderStyle = BorderStyle.FixedSingle;
            this.txtPassword.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.txtPassword.TabIndex = 4;

            // Change Password button
            this.btnChangePassword.Text = "Change Password…";
            this.btnChangePassword.Size = new System.Drawing.Size(160, 28);
            this.btnChangePassword.Location = new System.Drawing.Point(leftText + widthText - 160, top - 4);
            this.btnChangePassword.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.btnChangePassword.FlatStyle = FlatStyle.Flat;
            this.btnChangePassword.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnChangePassword.TabIndex = 5;
            this.btnChangePassword.Click += new EventHandler(this.btnChangePassword_Click);

            // add input controls to group box
            grp.Controls.Add(this.lblFullName);
            grp.Controls.Add(this.txtFullName);
            grp.Controls.Add(this.lblEmail);
            grp.Controls.Add(this.txtEmail);
            grp.Controls.Add(this.lblPhone);
            grp.Controls.Add(this.txtPhone);
            grp.Controls.Add(this.lblAddress);
            grp.Controls.Add(this.txtAddress);
            grp.Controls.Add(this.lblPassword);
            grp.Controls.Add(this.txtPassword);
            grp.Controls.Add(this.btnChangePassword);

            // ===== Bottom Buttons Row =====
            // keep outside group for nicer spacing
            this.btnSave.Text = "Save";
            this.btnSave.Size = new System.Drawing.Size(120, 36);
            this.btnSave.Location = new System.Drawing.Point(320, 352);
            this.btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.FlatStyle = FlatStyle.Flat;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnSave.TabIndex = 6;
            this.btnSave.Click += new EventHandler(this.btnSave_Click);

            this.btnCancel.Text = "Cancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 36);
            this.btnCancel.Location = new System.Drawing.Point(450, 352);
            this.btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(235, 237, 240);
            this.btnCancel.FlatStyle = FlatStyle.Flat;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Click += new EventHandler(this.btnCancel_Click);

            // ===== Hidden Photo controls (kept for backend compatibility) =====
            this.pbAvatar.Location = new System.Drawing.Point(12, 12);
            this.pbAvatar.Size = new System.Drawing.Size(1, 1);
            this.pbAvatar.Visible = false;
            this.pbAvatar.SizeMode = PictureBoxSizeMode.Zoom;

            this.btnUploadPhoto.Text = "Upload Photo";
            this.btnUploadPhoto.Size = new System.Drawing.Size(1, 1);
            this.btnUploadPhoto.Location = new System.Drawing.Point(12, 12);
            this.btnUploadPhoto.Visible = false;
            this.btnUploadPhoto.Click += new EventHandler(this.btnUploadPhoto_Click);

            // ===== Add Controls =====
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(grp); // container with all inputs

            // hidden ones still added (safe for backend)
            this.Controls.Add(this.pbAvatar);
            this.Controls.Add(this.btnUploadPhoto);

            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
        }
        #endregion
    }
}
