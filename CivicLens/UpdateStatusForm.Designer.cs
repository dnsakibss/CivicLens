using System;
using System.Windows.Forms;

namespace CivicLens
{
    partial class UpdateStatusForm
    {
        private System.ComponentModel.IContainer components = null;

        // Decorative header (safe addition — no backend dependencies)
        private Panel panelHeader;
        private Label lblHeaderTitle;

        // Summary
        private GroupBox grpSummary;
        private Label lblIdLabel;
        private Label lblIdValue;
        private Label lblTitleLabel;
        private TextBox txtTitle;
        private Label lblCategoryLabel;
        private TextBox txtCategory;
        private Label lblPriorityLabel;
        private TextBox txtPriority;
        private Label lblReporterLabel;
        private TextBox txtReporter;
        private Label lblCreatedAtLabel;
        private TextBox txtCreatedAt;

        // Status change
        private GroupBox grpStatus;
        private Label lblCurrentStatus;
        private TextBox txtCurrentStatus;
        private Label lblNewStatus;
        private ComboBox cmbNewStatus;
        private Label lblNote;
        private TextBox txtNote;
        private Label lblWhen;
        private DateTimePicker dtWhen;

        private Button btnSave;
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

            // ===== Form =====
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(248, 250, 253);
            this.ClientSize = new System.Drawing.Size(820, 560);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterParent;
            this.Name = "UpdateStatusForm";
            this.Text = "Update Status - CivicLens";

            // ===== Header (visual only) =====
            this.panelHeader = new Panel();
            this.lblHeaderTitle = new Label();

            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(235, 241, 250);
            this.panelHeader.Dock = DockStyle.Top;
            this.panelHeader.Height = 70;

            this.lblHeaderTitle.AutoSize = true;
            this.lblHeaderTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.lblHeaderTitle.ForeColor = System.Drawing.Color.FromArgb(32, 56, 100);
            this.lblHeaderTitle.Location = new System.Drawing.Point(18, 18);
            this.lblHeaderTitle.Text = "Update Status";

            this.panelHeader.Controls.Add(this.lblHeaderTitle);

            // Common metrics
            var fLabel = new System.Drawing.Font("Segoe UI", 10F);
            var fText = new System.Drawing.Font("Segoe UI", 10F);
            int H = 28;   // input height

            // ===== Summary =====
            this.grpSummary = new GroupBox();
            this.grpSummary.Text = "Complaint Summary";
            this.grpSummary.Location = new System.Drawing.Point(16, 86);
            this.grpSummary.Size = new System.Drawing.Size(788, 180);
            this.grpSummary.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

            int L = 20;     // left label
            int LT = 140;   // left text
            int W = 290;    // input width
            int G = 34;     // vertical gap
            int T = 32;     // start top

            this.lblIdLabel = new Label();
            this.lblIdLabel.Font = fLabel;
            this.lblIdLabel.Location = new System.Drawing.Point(L, T);
            this.lblIdLabel.Size = new System.Drawing.Size(110, 22);
            this.lblIdLabel.Text = "Complaint ID:";

            this.lblIdValue = new Label();
            this.lblIdValue.Font = fText;
            this.lblIdValue.Location = new System.Drawing.Point(LT, T);
            this.lblIdValue.Size = new System.Drawing.Size(150, 22);
            this.lblIdValue.Text = "#?";

            this.lblTitleLabel = new Label();
            this.lblTitleLabel.Font = fLabel;
            this.lblTitleLabel.Location = new System.Drawing.Point(L, T + G);
            this.lblTitleLabel.Size = new System.Drawing.Size(110, 22);
            this.lblTitleLabel.Text = "Title:";

            this.txtTitle = new TextBox();
            this.txtTitle.Font = fText;
            this.txtTitle.Location = new System.Drawing.Point(LT, T + G - 2);
            this.txtTitle.Size = new System.Drawing.Size(W, H);
            this.txtTitle.ReadOnly = true;

            int R = 420;  // right column x
            int TR = R + 110;
            int T2 = 32;

            this.lblCategoryLabel = new Label();
            this.lblCategoryLabel.Font = fLabel;
            this.lblCategoryLabel.Location = new System.Drawing.Point(R, T2);
            this.lblCategoryLabel.Size = new System.Drawing.Size(100, 22);
            this.lblCategoryLabel.Text = "Category:";

            this.txtCategory = new TextBox();
            this.txtCategory.Font = fText;
            this.txtCategory.Location = new System.Drawing.Point(TR, T2 - 2);
            this.txtCategory.Size = new System.Drawing.Size(240, H);
            this.txtCategory.ReadOnly = true;

            this.lblPriorityLabel = new Label();
            this.lblPriorityLabel.Font = fLabel;
            this.lblPriorityLabel.Location = new System.Drawing.Point(R, T2 + G);
            this.lblPriorityLabel.Size = new System.Drawing.Size(100, 22);
            this.lblPriorityLabel.Text = "Priority:";

            this.txtPriority = new TextBox();
            this.txtPriority.Font = fText;
            this.txtPriority.Location = new System.Drawing.Point(TR, T2 + G - 2);
            this.txtPriority.Size = new System.Drawing.Size(240, H);
            this.txtPriority.ReadOnly = true;

            this.lblReporterLabel = new Label();
            this.lblReporterLabel.Font = fLabel;
            this.lblReporterLabel.Location = new System.Drawing.Point(L, T + 2 * G);
            this.lblReporterLabel.Size = new System.Drawing.Size(110, 22);
            this.lblReporterLabel.Text = "Reporter:";

            this.txtReporter = new TextBox();
            this.txtReporter.Font = fText;
            this.txtReporter.Location = new System.Drawing.Point(LT, T + 2 * G - 2);
            this.txtReporter.Size = new System.Drawing.Size(W, H);
            this.txtReporter.ReadOnly = true;

            this.lblCreatedAtLabel = new Label();
            this.lblCreatedAtLabel.Font = fLabel;
            this.lblCreatedAtLabel.Location = new System.Drawing.Point(R, T2 + 2 * G);
            this.lblCreatedAtLabel.Size = new System.Drawing.Size(100, 22);
            this.lblCreatedAtLabel.Text = "Created At:";

            this.txtCreatedAt = new TextBox();
            this.txtCreatedAt.Font = fText;
            this.txtCreatedAt.Location = new System.Drawing.Point(TR, T2 + 2 * G - 2);
            this.txtCreatedAt.Size = new System.Drawing.Size(240, H);
            this.txtCreatedAt.ReadOnly = true;

            this.grpSummary.Controls.Add(this.lblIdLabel);
            this.grpSummary.Controls.Add(this.lblIdValue);
            this.grpSummary.Controls.Add(this.lblTitleLabel);
            this.grpSummary.Controls.Add(this.txtTitle);
            this.grpSummary.Controls.Add(this.lblCategoryLabel);
            this.grpSummary.Controls.Add(this.txtCategory);
            this.grpSummary.Controls.Add(this.lblPriorityLabel);
            this.grpSummary.Controls.Add(this.txtPriority);
            this.grpSummary.Controls.Add(this.lblReporterLabel);
            this.grpSummary.Controls.Add(this.txtReporter);
            this.grpSummary.Controls.Add(this.lblCreatedAtLabel);
            this.grpSummary.Controls.Add(this.txtCreatedAt);

            // ===== Status Change =====
            this.grpStatus = new GroupBox();
            this.grpStatus.Text = "Change Status";
            this.grpStatus.Location = new System.Drawing.Point(16, 276);
            this.grpStatus.Size = new System.Drawing.Size(788, 200);
            this.grpStatus.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

            int S = 24;     // label x inside group
            int ST = 170;   // input x
            int SW = 360;   // input width
            int STOP = 34;  // start top inside group

            this.lblCurrentStatus = new Label();
            this.lblCurrentStatus.Font = fLabel;
            this.lblCurrentStatus.Location = new System.Drawing.Point(S, STOP);
            this.lblCurrentStatus.Size = new System.Drawing.Size(140, 22);
            this.lblCurrentStatus.Text = "Current Status:";

            this.txtCurrentStatus = new TextBox();
            this.txtCurrentStatus.Font = fText;
            this.txtCurrentStatus.Location = new System.Drawing.Point(ST, STOP - 2);
            this.txtCurrentStatus.Size = new System.Drawing.Size(180, H);
            this.txtCurrentStatus.ReadOnly = true;

            this.lblNewStatus = new Label();
            this.lblNewStatus.Font = fLabel;
            this.lblNewStatus.Location = new System.Drawing.Point(S, STOP + 36);
            this.lblNewStatus.Size = new System.Drawing.Size(140, 22);
            this.lblNewStatus.Text = "New Status:";

            this.cmbNewStatus = new ComboBox();
            this.cmbNewStatus.Font = fText;
            this.cmbNewStatus.Location = new System.Drawing.Point(ST, STOP + 34);
            this.cmbNewStatus.Size = new System.Drawing.Size(180, H);
            this.cmbNewStatus.DropDownStyle = ComboBoxStyle.DropDownList;

            this.lblWhen = new Label();
            this.lblWhen.Font = fLabel;
            this.lblWhen.Location = new System.Drawing.Point(S, STOP + 72);
            this.lblWhen.Size = new System.Drawing.Size(140, 22);
            this.lblWhen.Text = "When:";

            this.dtWhen = new DateTimePicker();
            this.dtWhen.Font = fText;
            this.dtWhen.Location = new System.Drawing.Point(ST, STOP + 70);
            this.dtWhen.Size = new System.Drawing.Size(220, H);
            this.dtWhen.Format = DateTimePickerFormat.Custom;
            this.dtWhen.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dtWhen.ShowUpDown = true;

            this.lblNote = new Label();
            this.lblNote.Font = fLabel;
            this.lblNote.Location = new System.Drawing.Point(S, STOP + 110);
            this.lblNote.Size = new System.Drawing.Size(140, 22);
            this.lblNote.Text = "Action Note:";

            this.txtNote = new TextBox();
            this.txtNote.Font = fText;
            this.txtNote.Location = new System.Drawing.Point(ST, STOP + 108);
            this.txtNote.Size = new System.Drawing.Size(SW, 70);
            this.txtNote.Multiline = true;
            this.txtNote.ScrollBars = ScrollBars.Vertical;

            this.grpStatus.Controls.Add(this.lblCurrentStatus);
            this.grpStatus.Controls.Add(this.txtCurrentStatus);
            this.grpStatus.Controls.Add(this.lblNewStatus);
            this.grpStatus.Controls.Add(this.cmbNewStatus);
            this.grpStatus.Controls.Add(this.lblWhen);
            this.grpStatus.Controls.Add(this.dtWhen);
            this.grpStatus.Controls.Add(this.lblNote);
            this.grpStatus.Controls.Add(this.txtNote);

            // ===== Buttons =====
            this.btnSave = new Button();
            this.btnSave.Location = new System.Drawing.Point(608, 490);
            this.btnSave.Size = new System.Drawing.Size(100, 34);
            this.btnSave.Text = "Save";
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(33, 150, 243);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.FlatStyle = FlatStyle.Flat;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.Click += new EventHandler(this.btnSave_Click);

            this.btnCancel = new Button();
            this.btnCancel.Location = new System.Drawing.Point(724, 490);
            this.btnCancel.Size = new System.Drawing.Size(80, 34);
            this.btnCancel.Text = "Cancel";
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
            this.btnCancel.FlatStyle = FlatStyle.Flat;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnCancel.Click += new EventHandler(this.btnCancel_Click);

            // ===== Add to form =====
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.grpSummary);
            this.Controls.Add(this.grpStatus);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
        }
        #endregion
    }
}
