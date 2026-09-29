using System;
using System.Windows.Forms;

namespace CivicLens
{
    partial class SubmitComplaintForm
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblTitle;
        private TextBox txtTitle;

        private Label lblDescription;
        private TextBox txtDescription;

        private Label lblCategory;
        private ComboBox cmbCategory;

        private Label lblDistrict;
        private ComboBox cmbDistrict;
        private Label lblCity;
        private ComboBox cmbCity;
        private Label lblArea;
        private ComboBox cmbArea;

        private Label lblPriority;
        private ComboBox cmbPriority;

        private GroupBox grpMedia;
        private ListView lvMedia;
        private ColumnHeader colPath;
        private ColumnHeader colType;
        private ColumnHeader colPrimary;
        private ColumnHeader colOrder;
        private Button btnAddMedia;
        private Button btnRemoveMedia;
        private Button btnSetPrimary;
        private Button btnMoveUp;
        private Button btnMoveDown;

        private Button btnSubmit;
        private Button btnCancel;

        // decorative header bar (no backend dependency)
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
            this.txtTitle = new TextBox();

            this.lblDescription = new Label();
            this.txtDescription = new TextBox();

            this.lblCategory = new Label();
            this.cmbCategory = new ComboBox();

            this.lblDistrict = new Label();
            this.cmbDistrict = new ComboBox();
            this.lblCity = new Label();
            this.cmbCity = new ComboBox();
            this.lblArea = new Label();
            this.cmbArea = new ComboBox();

            this.lblPriority = new Label();
            this.cmbPriority = new ComboBox();

            this.grpMedia = new GroupBox();
            this.lvMedia = new ListView();
            this.colPath = new ColumnHeader();
            this.colType = new ColumnHeader();
            this.colPrimary = new ColumnHeader();
            this.colOrder = new ColumnHeader();
            this.btnAddMedia = new Button();
            this.btnRemoveMedia = new Button();
            this.btnSetPrimary = new Button();
            this.btnMoveUp = new Button();
            this.btnMoveDown = new Button();

            this.btnSubmit = new Button();
            this.btnCancel = new Button();

            // ===== Form =====
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(248, 250, 253);
            this.ClientSize = new System.Drawing.Size(980, 640);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Submit Complaint - CivicLens";

            // ===== Header =====
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(235, 241, 250);
            this.panelHeader.Dock = DockStyle.Top;
            this.panelHeader.Height = 68;

            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(32, 56, 100);
            this.lblTitle.Location = new System.Drawing.Point(22, 18);
            this.lblTitle.Text = "Submit a Complaint";

            this.panelHeader.Controls.Add(this.lblTitle);

            // ===== Layout metrics =====
            int leftLabel = 26;
            int leftText = 150;
            int wText = 360;
            int rowH = 30;
            int gap = 40;
            int top = 92;

            int rightStart = 560;
            int rw = 340;

            var txtFont = new System.Drawing.Font("Segoe UI", 10F);

            // ===== Title =====
            var lblTitleField = new Label();
            lblTitleField.Location = new System.Drawing.Point(leftLabel, top);
            lblTitleField.Size = new System.Drawing.Size(110, 22);
            lblTitleField.Text = "Title *";

            this.txtTitle.Location = new System.Drawing.Point(leftText, top - 2);
            this.txtTitle.Size = new System.Drawing.Size(wText, rowH);
            this.txtTitle.Font = txtFont;
            this.txtTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            top += gap;

            // ===== Description =====
            this.lblDescription.Location = new System.Drawing.Point(leftLabel, top);
            this.lblDescription.Size = new System.Drawing.Size(110, 22);
            this.lblDescription.Text = "Description";
            this.txtDescription.Location = new System.Drawing.Point(leftText, top - 2);
            this.txtDescription.Size = new System.Drawing.Size(wText, 110);
            this.txtDescription.Multiline = true;
            this.txtDescription.ScrollBars = ScrollBars.Vertical;
            this.txtDescription.Font = txtFont;
            this.txtDescription.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            top += 118;

            // ===== Category =====
            this.lblCategory.Location = new System.Drawing.Point(leftLabel, top);
            this.lblCategory.Size = new System.Drawing.Size(110, 22);
            this.lblCategory.Text = "Category *";
            this.cmbCategory.Location = new System.Drawing.Point(leftText, top - 2);
            this.cmbCategory.Size = new System.Drawing.Size(wText, rowH);
            this.cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbCategory.Font = txtFont;
            this.cmbCategory.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

            // ===== Right Column: Location + Priority =====
            int topRight = 92;

            this.lblDistrict.Location = new System.Drawing.Point(rightStart, topRight);
            this.lblDistrict.Size = new System.Drawing.Size(110, 22);
            this.lblDistrict.Text = "District";
            this.cmbDistrict.Location = new System.Drawing.Point(rightStart + 116, topRight - 2);
            this.cmbDistrict.Size = new System.Drawing.Size(rw, rowH);
            this.cmbDistrict.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbDistrict.Font = txtFont;
            this.cmbDistrict.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            topRight += gap;

            this.lblCity.Location = new System.Drawing.Point(rightStart, topRight);
            this.lblCity.Size = new System.Drawing.Size(110, 22);
            this.lblCity.Text = "City";
            this.cmbCity.Location = new System.Drawing.Point(rightStart + 116, topRight - 2);
            this.cmbCity.Size = new System.Drawing.Size(rw, rowH);
            this.cmbCity.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbCity.Font = txtFont;
            this.cmbCity.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            topRight += gap;

            this.lblArea.Location = new System.Drawing.Point(rightStart, topRight);
            this.lblArea.Size = new System.Drawing.Size(110, 22);
            this.lblArea.Text = "Area";
            this.cmbArea.Location = new System.Drawing.Point(rightStart + 116, topRight - 2);
            this.cmbArea.Size = new System.Drawing.Size(rw, rowH);
            this.cmbArea.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbArea.Font = txtFont;
            this.cmbArea.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            topRight += gap;

            this.lblPriority.Location = new System.Drawing.Point(rightStart, topRight);
            this.lblPriority.Size = new System.Drawing.Size(110, 22);
            this.lblPriority.Text = "Priority *";
            this.cmbPriority.Location = new System.Drawing.Point(rightStart + 116, topRight - 2);
            this.cmbPriority.Size = new System.Drawing.Size(rw, rowH);
            this.cmbPriority.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbPriority.Items.AddRange(new object[] { "Low", "Normal", "High" });
            this.cmbPriority.Font = txtFont;
            this.cmbPriority.Anchor = AnchorStyles.Top | AnchorStyles.Right;

            // ===== Media Group =====
            this.grpMedia.Text = "Media (Images / Videos)";
            this.grpMedia.Location = new System.Drawing.Point(22, 310);
            this.grpMedia.Size = new System.Drawing.Size(936, 242);
            this.grpMedia.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

            this.lvMedia.Location = new System.Drawing.Point(16, 28);
            this.lvMedia.Size = new System.Drawing.Size(694, 190);
            this.lvMedia.View = View.Details;
            this.lvMedia.FullRowSelect = true;
            this.lvMedia.GridLines = true;
            this.lvMedia.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

            this.colPath.Text = "File Path";
            this.colPath.Width = 430;
            this.colType.Text = "Type";
            this.colType.Width = 90;
            this.colPrimary.Text = "Primary";
            this.colPrimary.Width = 90;
            this.colOrder.Text = "Order";
            this.colOrder.Width = 70;

            this.lvMedia.Columns.AddRange(new ColumnHeader[] { colPath, colType, colPrimary, colOrder });

            // right button column inside group
            int bx = 720;
            int by = 28;
            int bw = 190;
            int bh = 30;
            int bg = 36;

            this.btnAddMedia.Text = "Add...";
            this.btnAddMedia.Location = new System.Drawing.Point(bx, by);
            this.btnAddMedia.Size = new System.Drawing.Size(bw, bh);
            this.btnAddMedia.FlatStyle = FlatStyle.Flat;
            this.btnAddMedia.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnAddMedia.Click += new EventHandler(this.btnAddMedia_Click);

            this.btnRemoveMedia.Text = "Remove";
            this.btnRemoveMedia.Location = new System.Drawing.Point(bx, by + bg);
            this.btnRemoveMedia.Size = new System.Drawing.Size(bw, bh);
            this.btnRemoveMedia.FlatStyle = FlatStyle.Flat;
            this.btnRemoveMedia.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnRemoveMedia.Click += new EventHandler(this.btnRemoveMedia_Click);

            this.btnSetPrimary.Text = "Set Primary";
            this.btnSetPrimary.Location = new System.Drawing.Point(bx, by + bg * 2);
            this.btnSetPrimary.Size = new System.Drawing.Size(bw, bh);
            this.btnSetPrimary.FlatStyle = FlatStyle.Flat;
            this.btnSetPrimary.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnSetPrimary.Click += new EventHandler(this.btnSetPrimary_Click);

            this.btnMoveUp.Text = "Move Up";
            this.btnMoveUp.Location = new System.Drawing.Point(bx, by + bg * 3);
            this.btnMoveUp.Size = new System.Drawing.Size(bw, bh);
            this.btnMoveUp.FlatStyle = FlatStyle.Flat;
            this.btnMoveUp.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnMoveUp.Click += new EventHandler(this.btnMoveUp_Click);

            this.btnMoveDown.Text = "Move Down";
            this.btnMoveDown.Location = new System.Drawing.Point(bx, by + bg * 4);
            this.btnMoveDown.Size = new System.Drawing.Size(bw, bh);
            this.btnMoveDown.FlatStyle = FlatStyle.Flat;
            this.btnMoveDown.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnMoveDown.Click += new EventHandler(this.btnMoveDown_Click);

            this.grpMedia.Controls.Add(this.lvMedia);
            this.grpMedia.Controls.Add(this.btnAddMedia);
            this.grpMedia.Controls.Add(this.btnRemoveMedia);
            this.grpMedia.Controls.Add(this.btnSetPrimary);
            this.grpMedia.Controls.Add(this.btnMoveUp);
            this.grpMedia.Controls.Add(this.btnMoveDown);

            // ===== Bottom Buttons =====
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.Size = new System.Drawing.Size(130, 38);
            this.btnSubmit.Location = new System.Drawing.Point(700, 566);
            this.btnSubmit.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(33, 150, 243);
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.FlatStyle = FlatStyle.Flat;
            this.btnSubmit.FlatAppearance.BorderSize = 0;
            this.btnSubmit.Click += new EventHandler(this.btnSubmit_Click);

            this.btnCancel.Text = "Cancel";
            this.btnCancel.Size = new System.Drawing.Size(130, 38);
            this.btnCancel.Location = new System.Drawing.Point(828, 566);
            this.btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
            this.btnCancel.FlatStyle = FlatStyle.Flat;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnCancel.Click += new EventHandler(this.btnCancel_Click);

            // ===== Add to form =====
            this.Controls.Add(this.panelHeader);

            this.Controls.Add(lblTitleField);
            this.Controls.Add(this.txtTitle);

            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtDescription);

            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.cmbCategory);

            this.Controls.Add(this.lblDistrict);
            this.Controls.Add(this.cmbDistrict);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.cmbCity);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.cmbArea);

            this.Controls.Add(this.lblPriority);
            this.Controls.Add(this.cmbPriority);

            this.Controls.Add(this.grpMedia);

            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnCancel);
        }
        #endregion
    }
}
