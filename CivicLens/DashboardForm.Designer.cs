using System;
using System.Windows.Forms;

namespace CivicLens
{
    partial class DashboardForm
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblAppTitle;
        private Label lblWelcome;
        private Label lblRole;

        private GroupBox grpShared;
        private Button btnViewProfile;
        private Button btnEditProfile;
        private Button btnLogout;

        private GroupBox grpAdmin;
        private Button btnUserApprovals;
        private Button btnManageUsers;
        private Button btnManageAdmins;
        private Button btnCategories;
        private Button btnLocations;

        private GroupBox grpModerator;
        private Button btnModeratorQueue;

        private GroupBox grpPolice;
        private Button btnPoliceAssigned;

        private GroupBox grpJournalist;
        private Button btnJournalistFeed;

        private GroupBox grpCitizen;
        private Button btnSubmitComplaint;
        private Button btnMyComplaints;

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
            this.lblAppTitle = new Label();
            this.lblWelcome = new Label();
            this.lblRole = new Label();

            this.grpShared = new GroupBox();
            this.btnViewProfile = new Button();
            this.btnEditProfile = new Button();
            this.btnLogout = new Button();

            this.grpAdmin = new GroupBox();
            this.btnUserApprovals = new Button();
            this.btnManageUsers = new Button();
            this.btnManageAdmins = new Button();
            this.btnCategories = new Button();
            this.btnLocations = new Button();

            this.grpModerator = new GroupBox();
            this.btnModeratorQueue = new Button();

            this.grpPolice = new GroupBox();
            this.btnPoliceAssigned = new Button();

            this.grpJournalist = new GroupBox();
            this.btnJournalistFeed = new Button();

            this.grpCitizen = new GroupBox();
            this.btnSubmitComplaint = new Button();
            this.btnMyComplaints = new Button();

            // ===== FORM =====
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(248, 250, 253);
            this.ClientSize = new System.Drawing.Size(1180, 720);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "CivicLens - Dashboard";
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.MaximizeBox = true;
            this.MinimizeBox = true;

            // ===== HEADER =====
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(235, 241, 250);
            this.panelHeader.Dock = DockStyle.Top;
            this.panelHeader.Height = 80;

            this.lblAppTitle.AutoSize = true;
            this.lblAppTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold);
            this.lblAppTitle.ForeColor = System.Drawing.Color.FromArgb(32, 56, 100);
            this.lblAppTitle.Location = new System.Drawing.Point(22, 20);
            this.lblAppTitle.Text = "CivicLens";

            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
            this.lblWelcome.Location = new System.Drawing.Point(240, 22);
            this.lblWelcome.Text = "Welcome, User";

            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Italic);
            this.lblRole.ForeColor = System.Drawing.Color.FromArgb(108, 117, 125);
            this.lblRole.Location = new System.Drawing.Point(242, 48);
            this.lblRole.Text = "Role: Citizen";

            this.panelHeader.Controls.Add(this.lblAppTitle);
            this.panelHeader.Controls.Add(this.lblWelcome);
            this.panelHeader.Controls.Add(this.lblRole);

            // Shared metrics
            int btnW = 300, btnH = 40, padX = 24, padY = 36;

            // ===== SHARED =====
            this.grpShared.Text = "Shared";
            this.grpShared.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.grpShared.Location = new System.Drawing.Point(24, 100);
            this.grpShared.Size = new System.Drawing.Size(350, 210);
            this.grpShared.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            this.btnViewProfile.Text = "View Profile";
            this.btnViewProfile.Size = new System.Drawing.Size(btnW - 40, btnH);
            this.btnViewProfile.Location = new System.Drawing.Point(padX, padY);
            this.btnViewProfile.FlatStyle = FlatStyle.Flat;
            this.btnViewProfile.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnViewProfile.Click += new EventHandler(this.btnViewProfile_Click);

            this.btnEditProfile.Text = "Edit Profile";
            this.btnEditProfile.Size = new System.Drawing.Size(btnW - 40, btnH);
            this.btnEditProfile.Location = new System.Drawing.Point(padX, padY + 48);
            this.btnEditProfile.FlatStyle = FlatStyle.Flat;
            this.btnEditProfile.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnEditProfile.Click += new EventHandler(this.btnEditProfile_Click);

            this.btnLogout.Text = "Logout";
            this.btnLogout.Size = new System.Drawing.Size(btnW - 40, btnH);
            this.btnLogout.Location = new System.Drawing.Point(padX, padY + 96);
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(231, 76, 60);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.FlatStyle = FlatStyle.Flat;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnLogout.Click += new EventHandler(this.btnLogout_Click);

            this.grpShared.Controls.Add(this.btnViewProfile);
            this.grpShared.Controls.Add(this.btnEditProfile);
            this.grpShared.Controls.Add(this.btnLogout);

            // ===== ADMIN =====
            this.grpAdmin.Text = "Admin";
            this.grpAdmin.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.grpAdmin.Location = new System.Drawing.Point(396, 100);
            this.grpAdmin.Size = new System.Drawing.Size(350, 300);
            this.grpAdmin.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            int aTop = padY;

            ButtonStylePrimary(this.btnUserApprovals, "User Approvals",
                new System.Drawing.Point(padX, aTop));
            this.btnUserApprovals.Click += new EventHandler(this.btnUserApprovals_Click);
            aTop += 48;

            ButtonStylePrimary(this.btnManageUsers, "Manage Users",
                new System.Drawing.Point(padX, aTop));
            this.btnManageUsers.Click += new EventHandler(this.btnManageUsers_Click);
            aTop += 48;

            ButtonStylePrimary(this.btnManageAdmins, "Manage Admins",
                new System.Drawing.Point(padX, aTop));
            this.btnManageAdmins.Click += new EventHandler(this.btnManageAdmins_Click);
            aTop += 48;

            ButtonStyleSecondary(this.btnCategories, "Categories",
                new System.Drawing.Point(padX, aTop));
            this.btnCategories.Click += new EventHandler(this.btnCategories_Click);
            aTop += 48;

            ButtonStyleSecondary(this.btnLocations, "Locations",
                new System.Drawing.Point(padX, aTop));
            this.btnLocations.Click += new EventHandler(this.btnLocations_Click);

            this.grpAdmin.Controls.Add(this.btnUserApprovals);
            this.grpAdmin.Controls.Add(this.btnManageUsers);
            this.grpAdmin.Controls.Add(this.btnManageAdmins);
            this.grpAdmin.Controls.Add(this.btnCategories);
            this.grpAdmin.Controls.Add(this.btnLocations);

            // ===== MODERATOR =====
            this.grpModerator.Text = "Moderator";
            this.grpModerator.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.grpModerator.Location = new System.Drawing.Point(768, 100);
            this.grpModerator.Size = new System.Drawing.Size(350, 120);
            this.grpModerator.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

            ButtonStylePrimary(this.btnModeratorQueue, "Complaint Queue",
                new System.Drawing.Point(padX, 48));
            this.btnModeratorQueue.Click += new EventHandler(this.btnModeratorQueue_Click);
            this.grpModerator.Controls.Add(this.btnModeratorQueue);

            // ===== POLICE =====
            this.grpPolice.Text = "Police";
            this.grpPolice.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.grpPolice.Location = new System.Drawing.Point(768, 236);
            this.grpPolice.Size = new System.Drawing.Size(350, 120);
            this.grpPolice.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

            ButtonStylePrimary(this.btnPoliceAssigned, "Assigned Complaints",
                new System.Drawing.Point(padX, 48));
            this.btnPoliceAssigned.Click += new EventHandler(this.btnPoliceAssigned_Click);
            this.grpPolice.Controls.Add(this.btnPoliceAssigned);

            // ===== JOURNALIST =====
            this.grpJournalist.Text = "Journalist";
            this.grpJournalist.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.grpJournalist.Location = new System.Drawing.Point(396, 420);
            this.grpJournalist.Size = new System.Drawing.Size(350, 120);
            this.grpJournalist.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            ButtonStyleSecondary(this.btnJournalistFeed, "Newsfeed",
                new System.Drawing.Point(padX, 48));
            this.btnJournalistFeed.Click += new EventHandler(this.btnJournalistFeed_Click);
            this.grpJournalist.Controls.Add(this.btnJournalistFeed);

            // ===== CITIZEN =====
            this.grpCitizen.Text = "Citizen";
            this.grpCitizen.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.grpCitizen.Location = new System.Drawing.Point(768, 380);
            this.grpCitizen.Size = new System.Drawing.Size(350, 160);
            this.grpCitizen.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

            ButtonStylePrimary(this.btnSubmitComplaint, "Submit Complaint",
                new System.Drawing.Point(padX, 44));
            this.btnSubmitComplaint.Click += new EventHandler(this.btnSubmitComplaint_Click);

            ButtonStyleSecondary(this.btnMyComplaints, "My Complaints",
                new System.Drawing.Point(padX, 92));
            this.btnMyComplaints.Click += new EventHandler(this.btnMyComplaints_Click);

            this.grpCitizen.Controls.Add(this.btnSubmitComplaint);
            this.grpCitizen.Controls.Add(this.btnMyComplaints);

            // ===== ADD TO FORM =====
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.grpShared);
            this.Controls.Add(this.grpAdmin);
            this.Controls.Add(this.grpModerator);
            this.Controls.Add(this.grpPolice);
            this.Controls.Add(this.grpJournalist);
            this.Controls.Add(this.grpCitizen);
        }

        // ---- Small helpers to keep style consistent (designer-safe) ----
        private void ButtonStylePrimary(Button b, string text, System.Drawing.Point location)
        {
            b.Text = text;
            b.Size = new System.Drawing.Size(300, 40);
            b.Location = location;
            b.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            b.ForeColor = System.Drawing.Color.White;
            b.FlatStyle = FlatStyle.Flat;
            b.FlatAppearance.BorderSize = 0;
            b.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
        }

        private void ButtonStyleSecondary(Button b, string text, System.Drawing.Point location)
        {
            b.Text = text;
            b.Size = new System.Drawing.Size(300, 40);
            b.Location = location;
            b.FlatStyle = FlatStyle.Flat;
            b.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            b.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        }
        #endregion
    }
}
