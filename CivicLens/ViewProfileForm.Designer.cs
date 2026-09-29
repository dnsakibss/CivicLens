using System;
using System.Windows.Forms;

namespace CivicLens
{
    partial class ViewProfileForm
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
        private TextBox txtRole;

        private Label lblApproval;
        private TextBox txtApproval;

        private Label lblCreatedAt;
        private TextBox txtCreatedAt;

        private Label lblApprovedAt;
        private TextBox txtApprovedAt;

        private Button btnRefresh;
        private Button btnEdit;
        private Button btnClose;

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

            this.lblRole = new Label();
            this.txtRole = new TextBox();

            this.lblApproval = new Label();
            this.txtApproval = new TextBox();

            this.lblCreatedAt = new Label();
            this.txtCreatedAt = new TextBox();

            this.lblApprovedAt = new Label();
            this.txtApprovedAt = new TextBox();

            this.btnRefresh = new Button();
            this.btnEdit = new Button();
            this.btnClose = new Button();

            // ===== Form =====
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(248, 250, 253);
            this.ClientSize = new System.Drawing.Size(720, 460);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ViewProfileForm";
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Profile - CivicLens";
            this.CancelButton = this.btnClose;

            // ===== Title =====
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(24, 18);
            this.lblTitle.Text = "My Profile";

            // ---- Container group (visual only; backend-safe) ----
            GroupBox grp = new GroupBox();
            grp.Text = "Details";
            grp.BackColor = System.Drawing.Color.White;
            grp.Location = new System.Drawing.Point(20, 58);
            grp.Size = new System.Drawing.Size(680, 320);
            grp.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grp.Padding = new Padding(14);

            // Metrics
            int leftLabel = 24;
            int leftText = 150;
            int widthText = 480;
            int h = 28;
            int gap = 40;
            int top = 36;

            System.Drawing.Font labelFont = new System.Drawing.Font("Segoe UI", 10F);

            // Full Name
            this.lblFullName.Location = new System.Drawing.Point(leftLabel, top);
            this.lblFullName.Size = new System.Drawing.Size(120, 22);
            this.lblFullName.Text = "Full Name:";
            this.lblFullName.Font = labelFont;

            this.txtFullName.Location = new System.Drawing.Point(leftText, top - 4);
            this.txtFullName.Size = new System.Drawing.Size(widthText, h);
            this.txtFullName.ReadOnly = true;
            this.txtFullName.BorderStyle = BorderStyle.FixedSingle;
            this.txtFullName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            top += gap;

            // Email
            this.lblEmail.Location = new System.Drawing.Point(leftLabel, top);
            this.lblEmail.Size = new System.Drawing.Size(120, 22);
            this.lblEmail.Text = "Email:";
            this.lblEmail.Font = labelFont;

            this.txtEmail.Location = new System.Drawing.Point(leftText, top - 4);
            this.txtEmail.Size = new System.Drawing.Size(widthText, h);
            this.txtEmail.ReadOnly = true;
            this.txtEmail.BorderStyle = BorderStyle.FixedSingle;
            this.txtEmail.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            top += gap;

            // Phone
            this.lblPhone.Location = new System.Drawing.Point(leftLabel, top);
            this.lblPhone.Size = new System.Drawing.Size(120, 22);
            this.lblPhone.Text = "Phone:";
            this.lblPhone.Font = labelFont;

            this.txtPhone.Location = new System.Drawing.Point(leftText, top - 4);
            this.txtPhone.Size = new System.Drawing.Size(widthText, h);
            this.txtPhone.ReadOnly = true;
            this.txtPhone.BorderStyle = BorderStyle.FixedSingle;
            this.txtPhone.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            top += gap;

            // Address
            this.lblAddress.Location = new System.Drawing.Point(leftLabel, top);
            this.lblAddress.Size = new System.Drawing.Size(120, 22);
            this.lblAddress.Text = "Address:";
            this.lblAddress.Font = labelFont;

            this.txtAddress.Location = new System.Drawing.Point(leftText, top - 4);
            this.txtAddress.Size = new System.Drawing.Size(widthText, h);
            this.txtAddress.ReadOnly = true;
            this.txtAddress.BorderStyle = BorderStyle.FixedSingle;
            this.txtAddress.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            top += gap;

            // Role + Approval (inline pair)
            this.lblRole.Location = new System.Drawing.Point(leftLabel, top);
            this.lblRole.Size = new System.Drawing.Size(120, 22);
            this.lblRole.Text = "Role:";
            this.lblRole.Font = labelFont;

            this.txtRole.Location = new System.Drawing.Point(leftText, top - 4);
            this.txtRole.Size = new System.Drawing.Size(190, h);
            this.txtRole.ReadOnly = true;
            this.txtRole.BorderStyle = BorderStyle.FixedSingle;

            this.lblApproval.Location = new System.Drawing.Point(leftText + 200, top);
            this.lblApproval.Size = new System.Drawing.Size(80, 22);
            this.lblApproval.Text = "Approval:";
            this.lblApproval.Font = labelFont;

            this.txtApproval.Location = new System.Drawing.Point(leftText + 280, top - 4);
            this.txtApproval.Size = new System.Drawing.Size(190, h);
            this.txtApproval.ReadOnly = true;
            this.txtApproval.BorderStyle = BorderStyle.FixedSingle;
            top += gap;

            // Created At + Approved At (inline pair)
            this.lblCreatedAt.Location = new System.Drawing.Point(leftLabel, top);
            this.lblCreatedAt.Size = new System.Drawing.Size(120, 22);
            this.lblCreatedAt.Text = "Created At:";
            this.lblCreatedAt.Font = labelFont;

            this.txtCreatedAt.Location = new System.Drawing.Point(leftText, top - 4);
            this.txtCreatedAt.Size = new System.Drawing.Size(190, h);
            this.txtCreatedAt.ReadOnly = true;
            this.txtCreatedAt.BorderStyle = BorderStyle.FixedSingle;

            this.lblApprovedAt.Location = new System.Drawing.Point(leftText + 200, top);
            this.lblApprovedAt.Size = new System.Drawing.Size(100, 22);
            this.lblApprovedAt.Text = "Approved At:";
            this.lblApprovedAt.Font = labelFont;

            this.txtApprovedAt.Location = new System.Drawing.Point(leftText + 300, top - 4);
            this.txtApprovedAt.Size = new System.Drawing.Size(170, h);
            this.txtApprovedAt.ReadOnly = true;
            this.txtApprovedAt.BorderStyle = BorderStyle.FixedSingle;

            // Add to group
            grp.Controls.Add(this.lblFullName);
            grp.Controls.Add(this.txtFullName);
            grp.Controls.Add(this.lblEmail);
            grp.Controls.Add(this.txtEmail);
            grp.Controls.Add(this.lblPhone);
            grp.Controls.Add(this.txtPhone);
            grp.Controls.Add(this.lblAddress);
            grp.Controls.Add(this.txtAddress);
            grp.Controls.Add(this.lblRole);
            grp.Controls.Add(this.txtRole);
            grp.Controls.Add(this.lblApproval);
            grp.Controls.Add(this.txtApproval);
            grp.Controls.Add(this.lblCreatedAt);
            grp.Controls.Add(this.txtCreatedAt);
            grp.Controls.Add(this.lblApprovedAt);
            grp.Controls.Add(this.txtApprovedAt);

            // ===== Bottom Buttons =====
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Size = new System.Drawing.Size(110, 36);
            this.btnRefresh.Location = new System.Drawing.Point(360, 390);
            this.btnRefresh.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            this.btnRefresh.FlatStyle = FlatStyle.Flat;
            this.btnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnRefresh.Click += new EventHandler(this.btnRefresh_Click);

            this.btnEdit.Text = "Edit Profile";
            this.btnEdit.Size = new System.Drawing.Size(120, 36);
            this.btnEdit.Location = new System.Drawing.Point(476, 390);
            this.btnEdit.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.FlatStyle = FlatStyle.Flat;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnEdit.Click += new EventHandler(this.btnEdit_Click);

            this.btnClose.Text = "Close";
            this.btnClose.Size = new System.Drawing.Size(110, 36);
            this.btnClose.Location = new System.Drawing.Point(598, 390);
            this.btnClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            this.btnClose.FlatStyle = FlatStyle.Flat;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnClose.Click += new EventHandler(this.btnClose_Click);

            // ===== Add to Form =====
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(grp);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnClose);
        }
        #endregion
    }
}
