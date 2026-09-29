using System;
using System.Windows.Forms;

namespace CivicLens
{
    partial class AssignComplaintForm
    {
        private System.ComponentModel.IContainer components = null;

        // Complaint summary
        private GroupBox grpComplaint;
        private Label lblIdLabel;
        private Label lblIdValue;
        private Label lblTitleLabel;
        private TextBox txtTitle;
        private Label lblCategoryLabel;
        private TextBox txtCategory;
        private Label lblPriorityLabel;
        private TextBox txtPriority;
        private Label lblStatusLabel;
        private TextBox txtStatus;
        private Label lblCreatedAtLabel;
        private TextBox txtCreatedAt;
        private Label lblReporterLabel;
        private TextBox txtReporter;
        private Label lblLocationLabel;
        private TextBox txtLocation;

        // Assignment
        private GroupBox grpAssign;
        private Label lblRole;
        private ComboBox cmbRole;        // Police / Journalist
        private Label lblAssignee;
        private ComboBox cmbAssignee;    // Users filtered by role
        private Label lblNote;
        private TextBox txtNote;
        private Button btnRefreshCandidates;
        private Button btnAssign;
        private Button btnCancel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

            // ---------- Form ----------
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(248, 250, 253);
            this.ClientSize = new System.Drawing.Size(900, 560);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterParent;
            this.Name = "AssignComplaintForm";
            this.Text = "Assign Complaint - CivicLens";

            var fLabel = new System.Drawing.Font("Segoe UI", 10F);
            var fText = new System.Drawing.Font("Segoe UI", 10F);
            int H = 28;

            // ================== Complaint Summary ==================
            this.grpComplaint = new GroupBox();
            this.grpComplaint.Text = "Complaint Summary";
            this.grpComplaint.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpComplaint.Location = new System.Drawing.Point(16, 16);
            this.grpComplaint.Size = new System.Drawing.Size(868, 238);

            int L = 20; int LT = 130; int W = 320; int G = 34; int T = 34;
            int R = 460; int TR = R + 110; int T2 = 34;

            this.lblIdLabel = new Label { Font = fLabel, Location = new System.Drawing.Point(L, T), Size = new System.Drawing.Size(110, 22), Text = "Complaint ID:" };
            this.lblIdValue = new Label { Font = fText, Location = new System.Drawing.Point(LT, T), Size = new System.Drawing.Size(160, 22), Text = "#0" };
            T += G;

            this.lblTitleLabel = new Label { Font = fLabel, Location = new System.Drawing.Point(L, T), Size = new System.Drawing.Size(110, 22), Text = "Title:" };
            this.txtTitle = new TextBox { Font = fText, Location = new System.Drawing.Point(LT, T - 2), Size = new System.Drawing.Size(W, H), ReadOnly = true };

            this.lblCategoryLabel = new Label { Font = fLabel, Location = new System.Drawing.Point(R, T2), Size = new System.Drawing.Size(100, 22), Text = "Category:" };
            this.txtCategory = new TextBox { Font = fText, Location = new System.Drawing.Point(TR, T2 - 2), Size = new System.Drawing.Size(260, H), ReadOnly = true };
            T2 += G;

            this.lblPriorityLabel = new Label { Font = fLabel, Location = new System.Drawing.Point(R, T2), Size = new System.Drawing.Size(100, 22), Text = "Priority:" };
            this.txtPriority = new TextBox { Font = fText, Location = new System.Drawing.Point(TR, T2 - 2), Size = new System.Drawing.Size(260, H), ReadOnly = true };
            T2 += G;

            this.lblStatusLabel = new Label { Font = fLabel, Location = new System.Drawing.Point(R, T2), Size = new System.Drawing.Size(100, 22), Text = "Status:" };
            this.txtStatus = new TextBox { Font = fText, Location = new System.Drawing.Point(TR, T2 - 2), Size = new System.Drawing.Size(260, H), ReadOnly = true };
            T2 += G;

            this.lblCreatedAtLabel = new Label { Font = fLabel, Location = new System.Drawing.Point(L, T + G), Size = new System.Drawing.Size(110, 22), Text = "Created At:" };
            this.txtCreatedAt = new TextBox { Font = fText, Location = new System.Drawing.Point(LT, T + G - 2), Size = new System.Drawing.Size(W, H), ReadOnly = true };

            this.lblReporterLabel = new Label { Font = fLabel, Location = new System.Drawing.Point(L, T + 2 * G), Size = new System.Drawing.Size(110, 22), Text = "Reporter:" };
            this.txtReporter = new TextBox { Font = fText, Location = new System.Drawing.Point(LT, T + 2 * G - 2), Size = new System.Drawing.Size(W, H), ReadOnly = true };

            this.lblLocationLabel = new Label { Font = fLabel, Location = new System.Drawing.Point(L, T + 3 * G), Size = new System.Drawing.Size(110, 22), Text = "Location:" };
            this.txtLocation = new TextBox { Font = fText, Location = new System.Drawing.Point(LT, T + 3 * G - 2), Size = new System.Drawing.Size(W, H), ReadOnly = true };

            this.grpComplaint.Controls.Add(this.lblIdLabel);
            this.grpComplaint.Controls.Add(this.lblIdValue);
            this.grpComplaint.Controls.Add(this.lblTitleLabel);
            this.grpComplaint.Controls.Add(this.txtTitle);
            this.grpComplaint.Controls.Add(this.lblCategoryLabel);
            this.grpComplaint.Controls.Add(this.txtCategory);
            this.grpComplaint.Controls.Add(this.lblPriorityLabel);
            this.grpComplaint.Controls.Add(this.txtPriority);
            this.grpComplaint.Controls.Add(this.lblStatusLabel);
            this.grpComplaint.Controls.Add(this.txtStatus);
            this.grpComplaint.Controls.Add(this.lblCreatedAtLabel);
            this.grpComplaint.Controls.Add(this.txtCreatedAt);
            this.grpComplaint.Controls.Add(this.lblReporterLabel);
            this.grpComplaint.Controls.Add(this.txtReporter);
            this.grpComplaint.Controls.Add(this.lblLocationLabel);
            this.grpComplaint.Controls.Add(this.txtLocation);

            // ================== Assign Group ==================
            this.grpAssign = new GroupBox();
            this.grpAssign.Text = "Assign To";
            this.grpAssign.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpAssign.Location = new System.Drawing.Point(16, 264);
            this.grpAssign.Size = new System.Drawing.Size(868, 230);

            int A = 24; int AT = 140; int AW = 340; int ATOP = 40;

            this.lblRole = new Label { Font = fLabel, Location = new System.Drawing.Point(A, ATOP), Size = new System.Drawing.Size(110, 22), Text = "Role:" };
            this.cmbRole = new ComboBox { Font = fText, Location = new System.Drawing.Point(AT, ATOP - 2), Size = new System.Drawing.Size(200, H), DropDownStyle = ComboBoxStyle.DropDownList };

            this.btnRefreshCandidates = new Button { Location = new System.Drawing.Point(AT + 210, ATOP - 2), Size = new System.Drawing.Size(160, 28), Text = "Refresh Candidates" };
            this.btnRefreshCandidates.Click += new EventHandler(this.btnRefreshCandidates_Click);

            this.lblAssignee = new Label { Font = fLabel, Location = new System.Drawing.Point(A, ATOP + G), Size = new System.Drawing.Size(110, 22), Text = "Assignee:" };
            this.cmbAssignee = new ComboBox { Font = fText, Location = new System.Drawing.Point(AT, ATOP + G - 2), Size = new System.Drawing.Size(AW, H), DropDownStyle = ComboBoxStyle.DropDownList };

            this.lblNote = new Label { Font = fLabel, Location = new System.Drawing.Point(520, ATOP), Size = new System.Drawing.Size(110, 22), Text = "Note:" };

            // ↓ Shorter height so buttons fit clearly beneath (no overlap)
            this.txtNote = new TextBox
            {
                Font = fText,
                Location = new System.Drawing.Point(520, ATOP + 24),
                Size = new System.Drawing.Size(330, 100),   // height reduced from 110 to 100
                Multiline = true,
                ScrollBars = ScrollBars.Vertical
            };

            // Buttons placed well below the note box
            int btnTop = ATOP + 24 + 100 + 12; // bottom of note + spacing (≈ 136)
            this.btnAssign = new Button { Location = new System.Drawing.Point(670, btnTop), Size = new System.Drawing.Size(90, 30), Text = "Assign" };
            this.btnAssign.Click += new EventHandler(this.btnAssign_Click);

            this.btnCancel = new Button { Location = new System.Drawing.Point(760, btnTop), Size = new System.Drawing.Size(90, 30), Text = "Cancel" };
            this.btnCancel.Click += new EventHandler(this.btnCancel_Click);

            this.grpAssign.Controls.Add(this.lblRole);
            this.grpAssign.Controls.Add(this.cmbRole);
            this.grpAssign.Controls.Add(this.lblAssignee);
            this.grpAssign.Controls.Add(this.cmbAssignee);
            this.grpAssign.Controls.Add(this.lblNote);
            this.grpAssign.Controls.Add(this.txtNote);
            this.grpAssign.Controls.Add(this.btnRefreshCandidates);
            this.grpAssign.Controls.Add(this.btnAssign);
            this.grpAssign.Controls.Add(this.btnCancel);

            // ---------- Add groups ----------
            this.Controls.Add(this.grpComplaint);
            this.Controls.Add(this.grpAssign);
        }
        #endregion
    }
}
