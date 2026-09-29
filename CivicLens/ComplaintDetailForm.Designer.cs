using System;
using System.Windows.Forms;

namespace CivicLens
{
    partial class ComplaintDetailForm
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblHeader;

        private Label lblTitle;
        private TextBox txtTitle;

        private Label lblCategory;
        private TextBox txtCategory;

        private Label lblPriority;
        private TextBox txtPriority;

        private Label lblStatus;
        private TextBox txtStatus;

        private Label lblCreatedAt;
        private TextBox txtCreatedAt;

        private Label lblLocation;
        private TextBox txtDistrict;
        private TextBox txtCity;
        private TextBox txtArea;

        private Label lblDescription;
        private TextBox txtDescription;

        private GroupBox grpMedia;
        private ListView lvMedia;
        private ColumnHeader colPath;
        private ColumnHeader colType;
        private ColumnHeader colPrimary;
        private PictureBox pbPreview;
        private Label lblPreviewNote;

        private GroupBox grpTimeline;
        private ListBox lstTimeline;

        private Button btnRefresh;
        private Button btnSave;
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

            this.lblHeader = new Label();
            this.lblTitle = new Label();
            this.txtTitle = new TextBox();
            this.lblCategory = new Label();
            this.txtCategory = new TextBox();
            this.lblPriority = new Label();
            this.txtPriority = new TextBox();
            this.lblStatus = new Label();
            this.txtStatus = new TextBox();
            this.lblCreatedAt = new Label();
            this.txtCreatedAt = new TextBox();
            this.lblLocation = new Label();
            this.txtDistrict = new TextBox();
            this.txtCity = new TextBox();
            this.txtArea = new TextBox();
            this.lblDescription = new Label();
            this.txtDescription = new TextBox();
            this.grpMedia = new GroupBox();
            this.lvMedia = new ListView();
            this.colPath = new ColumnHeader();
            this.colType = new ColumnHeader();
            this.colPrimary = new ColumnHeader();
            this.pbPreview = new PictureBox();
            this.lblPreviewNote = new Label();
            this.grpTimeline = new GroupBox();
            this.lstTimeline = new ListBox();
            this.btnRefresh = new Button();
            this.btnSave = new Button();
            this.btnClose = new Button();

            // ===== Form =====
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(248, 250, 253);
            this.ClientSize = new System.Drawing.Size(980, 650);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Complaint Detail - CivicLens";

            // ===== Header =====
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.FromArgb(32, 56, 100);
            this.lblHeader.Location = new System.Drawing.Point(20, 16);
            this.lblHeader.Text = "Complaint Details";

            // Common styling
            var fLabel = new System.Drawing.Font("Segoe UI", 10F);
            var fText = new System.Drawing.Font("Segoe UI", 10F);
            int H = 28;
            int leftLabel = 22;
            int leftText = 140;
            int wText = 340;
            int gap = 34;
            int top = 86;

            // ===== Title =====
            this.lblTitle.Font = fLabel;
            this.lblTitle.Location = new System.Drawing.Point(leftLabel, top);
            this.lblTitle.Size = new System.Drawing.Size(110, 22);
            this.lblTitle.Text = "Title:";
            this.txtTitle.Font = fText;
            this.txtTitle.Location = new System.Drawing.Point(leftText, top - 2);
            this.txtTitle.Size = new System.Drawing.Size(wText, H);
            this.txtTitle.ReadOnly = true;
            top += gap;

            // ===== Category + Priority =====
            this.lblCategory.Font = fLabel;
            this.lblCategory.Location = new System.Drawing.Point(leftLabel, top);
            this.lblCategory.Size = new System.Drawing.Size(110, 22);
            this.lblCategory.Text = "Category:";
            this.txtCategory.Font = fText;
            this.txtCategory.Location = new System.Drawing.Point(leftText, top - 2);
            this.txtCategory.Size = new System.Drawing.Size(155, H);
            this.txtCategory.ReadOnly = true;

            this.lblPriority.Font = fLabel;
            this.lblPriority.Location = new System.Drawing.Point(leftText + 180, top);
            this.lblPriority.Size = new System.Drawing.Size(65, 22);
            this.lblPriority.Text = "Priority:";
            this.txtPriority.Font = fText;
            this.txtPriority.Location = new System.Drawing.Point(leftText + 245, top - 2);
            this.txtPriority.Size = new System.Drawing.Size(110, H);
            this.txtPriority.ReadOnly = true;
            top += gap;

            // ===== Status + CreatedAt =====
            this.lblStatus.Font = fLabel;
            this.lblStatus.Location = new System.Drawing.Point(leftLabel, top);
            this.lblStatus.Size = new System.Drawing.Size(110, 22);
            this.lblStatus.Text = "Status:";
            this.txtStatus.Font = fText;
            this.txtStatus.Location = new System.Drawing.Point(leftText, top - 2);
            this.txtStatus.Size = new System.Drawing.Size(160, H);
            this.txtStatus.ReadOnly = true;

            this.lblCreatedAt.Font = fLabel;
            this.lblCreatedAt.Location = new System.Drawing.Point(leftText + 180, top);
            this.lblCreatedAt.Size = new System.Drawing.Size(85, 22);
            this.lblCreatedAt.Text = "Created At:";
            this.txtCreatedAt.Font = fText;
            this.txtCreatedAt.Location = new System.Drawing.Point(leftText + 265, top - 2);
            this.txtCreatedAt.Size = new System.Drawing.Size(140, H);
            this.txtCreatedAt.ReadOnly = true;
            top += gap;

            // ===== Location =====
            this.lblLocation.Font = fLabel;
            this.lblLocation.Location = new System.Drawing.Point(leftLabel, top);
            this.lblLocation.Size = new System.Drawing.Size(110, 22);
            this.lblLocation.Text = "Location:";
            this.txtDistrict.Font = fText;
            this.txtDistrict.Location = new System.Drawing.Point(leftText, top - 2);
            this.txtDistrict.Size = new System.Drawing.Size(115, H);
            this.txtDistrict.ReadOnly = true;
            this.txtCity.Font = fText;
            this.txtCity.Location = new System.Drawing.Point(leftText + 125, top - 2);
            this.txtCity.Size = new System.Drawing.Size(115, H);
            this.txtCity.ReadOnly = true;
            this.txtArea.Font = fText;
            this.txtArea.Location = new System.Drawing.Point(leftText + 250, top - 2);
            this.txtArea.Size = new System.Drawing.Size(115, H);
            this.txtArea.ReadOnly = true;
            top += gap;

            // ===== Description =====
            this.lblDescription.Font = fLabel;
            this.lblDescription.Location = new System.Drawing.Point(leftLabel, top);
            this.lblDescription.Size = new System.Drawing.Size(110, 22);
            this.lblDescription.Text = "Description:";
            this.txtDescription.Font = fText;
            this.txtDescription.Location = new System.Drawing.Point(leftText, top - 2);
            this.txtDescription.Size = new System.Drawing.Size(wText, 120);
            this.txtDescription.ReadOnly = true;
            this.txtDescription.Multiline = true;
            this.txtDescription.ScrollBars = ScrollBars.Vertical;

            // ===== Media =====
            this.grpMedia.Text = "Media";
            this.grpMedia.Location = new System.Drawing.Point(620, 86);
            this.grpMedia.Size = new System.Drawing.Size(340, 300);

            this.lvMedia.Location = new System.Drawing.Point(14, 26);
            this.lvMedia.Size = new System.Drawing.Size(312, 120);
            this.lvMedia.View = View.Details;
            this.lvMedia.FullRowSelect = true;
            this.lvMedia.GridLines = true;
            this.lvMedia.MultiSelect = false;
            this.lvMedia.HideSelection = false;
            this.lvMedia.SelectedIndexChanged += new EventHandler(this.lvMedia_SelectedIndexChanged);

            this.colPath.Text = "File Path";
            this.colPath.Width = 190;
            this.colType.Text = "Type";
            this.colType.Width = 60;
            this.colPrimary.Text = "Primary";
            this.colPrimary.Width = 60;
            this.lvMedia.Columns.AddRange(new ColumnHeader[] { colPath, colType, colPrimary });

            this.pbPreview.Location = new System.Drawing.Point(14, 154);
            this.pbPreview.Size = new System.Drawing.Size(312, 100);
            this.pbPreview.BorderStyle = BorderStyle.FixedSingle;
            this.pbPreview.SizeMode = PictureBoxSizeMode.Zoom;

            this.lblPreviewNote.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblPreviewNote.ForeColor = System.Drawing.Color.FromArgb(108, 117, 125);
            this.lblPreviewNote.Location = new System.Drawing.Point(14, 258);
            this.lblPreviewNote.Size = new System.Drawing.Size(312, 30);
            this.lblPreviewNote.AutoEllipsis = true;
            this.lblPreviewNote.Text = "If selected item is a video, preview is not shown. Open file externally.";

            this.grpMedia.Controls.Add(this.lvMedia);
            this.grpMedia.Controls.Add(this.pbPreview);
            this.grpMedia.Controls.Add(this.lblPreviewNote);

            // ===== Timeline =====
            this.grpTimeline.Text = "Timeline / Notes";
            this.grpTimeline.Location = new System.Drawing.Point(20, 410);
            this.grpTimeline.Size = new System.Drawing.Size(940, 180);
            this.lstTimeline.Location = new System.Drawing.Point(16, 26);
            this.lstTimeline.Size = new System.Drawing.Size(908, 140);
            this.grpTimeline.Controls.Add(this.lstTimeline);

            // ===== Buttons =====
            int btnY = 605;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Location = new System.Drawing.Point(680, btnY);
            this.btnRefresh.Size = new System.Drawing.Size(100, 32);
            this.btnRefresh.Click += new EventHandler(this.btnRefresh_Click);

            this.btnSave.Name = "btnSave";
            this.btnSave.Text = "Save";
            this.btnSave.Location = new System.Drawing.Point(785, btnY);
            this.btnSave.Size = new System.Drawing.Size(90, 32);
            this.btnSave.Click += new EventHandler(this.btnSave_Click);
            this.btnSave.Visible = false;

            this.btnClose.Text = "Close";
            this.btnClose.Location = new System.Drawing.Point(880, btnY);
            this.btnClose.Size = new System.Drawing.Size(80, 32);
            this.btnClose.Click += new EventHandler(this.btnClose_Click);

            // ===== Add controls =====
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.lblPriority);
            this.Controls.Add(this.txtPriority);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.lblCreatedAt);
            this.Controls.Add(this.txtCreatedAt);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.txtDistrict);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.grpMedia);
            this.Controls.Add(this.grpTimeline);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
        }
        #endregion
    }
}
