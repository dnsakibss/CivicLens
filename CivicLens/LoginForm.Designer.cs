using System;
using System.Windows.Forms;

namespace CivicLens
{
    partial class LoginForm
    {
 
        private System.ComponentModel.IContainer components = null;

  
        private Panel panelCard;
        private Label lblTitle;
        private Label lblUsername;
        private TextBox txtUsername;
        private Label lblPassword;
        private TextBox txtPassword;
        private CheckBox chkShowPassword;
        private Button btnLogin;
        private LinkLabel linkSignup;
        private Label lblSubtitle;

     
        private LinkLabel linkForgot;

        
        private TableLayoutPanel tlRoot;
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

           
            this.tlRoot = new TableLayoutPanel();
            this.panelHeader = new Panel();
            this.panelCard = new Panel();

            this.lblTitle = new Label();
            this.lblSubtitle = new Label();

            this.lblUsername = new Label();
            this.txtUsername = new TextBox();

            this.lblPassword = new Label();
            this.txtPassword = new TextBox();
            this.chkShowPassword = new CheckBox();

            this.btnLogin = new Button();
            this.linkSignup = new LinkLabel();
            this.linkForgot = new LinkLabel(); 

            
            this.AutoScaleMode = AutoScaleMode.Font;
            // soft gradient-ish palette (solid color here)
            this.BackColor = System.Drawing.Color.FromArgb(238, 245, 255);
          
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.tlRoot);
            this.FormBorderStyle = FormBorderStyle.Sizable;   
            this.MaximizeBox = true;                          
            this.MinimizeBox = true;                           
            this.Name = "LoginForm";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "CivicLens_Login";

           
            this.tlRoot.ColumnCount = 3;
            this.tlRoot.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            this.tlRoot.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            this.tlRoot.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            this.tlRoot.RowCount = 3;
            this.tlRoot.RowStyles.Add(new RowStyle(SizeType.Percent, 35F));
            this.tlRoot.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            this.tlRoot.RowStyles.Add(new RowStyle(SizeType.Percent, 65F));
            this.tlRoot.Dock = DockStyle.Fill;
            this.tlRoot.BackColor = System.Drawing.Color.Transparent;

            // Optional header strip across the top
            this.panelHeader.Dock = DockStyle.Top;
            this.panelHeader.Height = 8;
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(25, 118, 210);
            this.Controls.Add(this.panelHeader);
            this.panelHeader.BringToFront();

            // ===== Card =====
            this.panelCard.Anchor = AnchorStyles.None; // stays centered by table layout
            this.panelCard.BackColor = System.Drawing.Color.White;
            this.panelCard.BorderStyle = BorderStyle.None;
            this.panelCard.Margin = new Padding(0);
            this.panelCard.Padding = new Padding(28);
            // width scales a bit with window; height fixed-ish
            this.panelCard.MinimumSize = new System.Drawing.Size(380, 360);
            this.panelCard.MaximumSize = new System.Drawing.Size(520, 460);
            this.panelCard.Size = new System.Drawing.Size(460, 400);

            // subtle border
            this.panelCard.Paint += (s, e) =>
            {
                using (var pen = new System.Drawing.Pen(System.Drawing.Color.FromArgb(230, 235, 242)))
                {
                    e.Graphics.DrawRectangle(pen, 0, 0, this.panelCard.Width - 1, this.panelCard.Height - 1);
                }
            };

            // add card to center cell
            this.tlRoot.Controls.Add(this.panelCard, 1, 1);

            // ===== Title =====
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
            this.lblTitle.Location = new System.Drawing.Point(4, 6);
            this.lblTitle.Text = "CivicLens";

            // ===== Subtitle =====
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(108, 117, 125);
            this.lblSubtitle.Location = new System.Drawing.Point(6, 44);
            this.lblSubtitle.Text = "Multimedia Complaint Management";

            // ===== Username =====
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblUsername.Location = new System.Drawing.Point(8, 88);
            this.lblUsername.Text = "Username";

            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtUsername.Location = new System.Drawing.Point(12, 108);
            this.txtUsername.MaxLength = 100;
            this.txtUsername.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.txtUsername.Width = this.panelCard.Width - 24;

            // ===== Password =====
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPassword.Location = new System.Drawing.Point(8, 148);
            this.lblPassword.Text = "Password";

            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPassword.Location = new System.Drawing.Point(12, 168);
            this.txtPassword.MaxLength = 200;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.txtPassword.Width = this.panelCard.Width - 24;

            // ===== Show password =====
            this.chkShowPassword.AutoSize = true;
            this.chkShowPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.chkShowPassword.Location = new System.Drawing.Point(12, 200);
            this.chkShowPassword.Text = "Show password";
            this.chkShowPassword.UseVisualStyleBackColor = true;
            this.chkShowPassword.CheckedChanged += new EventHandler(this.chkShowPassword_CheckedChanged);

            // ===== Login button =====
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnLogin.Location = new System.Drawing.Point(12, 234);
            this.btnLogin.Height = 36;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.btnLogin.Width = this.panelCard.Width - 24;
            this.btnLogin.Click += new EventHandler(this.btnLogin_Click);

            // Colorful primary-style look
            this.btnLogin.FlatStyle = FlatStyle.Standard;
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(25, 118, 210);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(21, 101, 192);

            // ===== Forgot password (NEW) =====
            this.linkForgot.AutoSize = true;
            this.linkForgot.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.linkForgot.LinkColor = System.Drawing.Color.FromArgb(25, 118, 210);
            this.linkForgot.Location = new System.Drawing.Point(12, 280);
            this.linkForgot.Text = "Forgot password?";
            this.linkForgot.LinkClicked += new LinkLabelLinkClickedEventHandler(this.linkForgot_LinkClicked);

            // ===== Signup link =====
            this.linkSignup.AutoSize = true;
            this.linkSignup.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.linkSignup.LinkColor = System.Drawing.Color.FromArgb(25, 118, 210);
            this.linkSignup.Location = new System.Drawing.Point(12, 305);
            this.linkSignup.Text = "Create a new account (Sign up)";
            this.linkSignup.LinkClicked += new LinkLabelLinkClickedEventHandler(this.linkSignup_LinkClicked);

            // Add children to card
            this.panelCard.Controls.Add(this.lblTitle);
            this.panelCard.Controls.Add(this.lblSubtitle);
            this.panelCard.Controls.Add(this.lblUsername);
            this.panelCard.Controls.Add(this.txtUsername);
            this.panelCard.Controls.Add(this.lblPassword);
            this.panelCard.Controls.Add(this.txtPassword);
            this.panelCard.Controls.Add(this.chkShowPassword);
            this.panelCard.Controls.Add(this.btnLogin);
            this.panelCard.Controls.Add(this.linkForgot); // NEW
            this.panelCard.Controls.Add(this.linkSignup);

            // Make inputs resize with the card
            this.panelCard.Resize += (s, e) =>
            {
                int innerW = this.panelCard.Width - 24;
                this.txtUsername.Width = innerW;
                this.txtPassword.Width = innerW;
                this.btnLogin.Width = innerW;
            };

            // AcceptButton (set after btnLogin exists)
            this.AcceptButton = this.btnLogin;
        }
        #endregion
    }
}
