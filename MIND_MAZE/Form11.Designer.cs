namespace MIND_MAZE
{
    partial class Form11
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form11));
            this.panel1 = new System.Windows.Forms.Panel();
            this.close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHam = new System.Windows.Forms.PictureBox();
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.pnDashboard = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.menuContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.menu = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.submenu1 = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.submenu2 = new System.Windows.Forms.Button();
            this.pnAbout = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.pnSettings = new System.Windows.Forms.Panel();
            this.gf = new System.Windows.Forms.Button();
            this.pnLogout = new System.Windows.Forms.Panel();
            this.hh = new System.Windows.Forms.Button();
            this.menuTransition = new System.Windows.Forms.Timer(this.components);
            this.sidebarTransition = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHam)).BeginInit();
            this.sidebar.SuspendLayout();
            this.pnDashboard.SuspendLayout();
            this.menuContainer.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.pnAbout.SuspendLayout();
            this.pnSettings.SuspendLayout();
            this.pnLogout.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.close);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnHam);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(815, 36);
            this.panel1.TabIndex = 0;
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.Transparent;
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.FlatAppearance.BorderSize = 0;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.ForeColor = System.Drawing.Color.Black;
            this.close.Location = new System.Drawing.Point(774, 2);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(38, 34);
            this.close.TabIndex = 22;
            this.close.TabStop = false;
            this.close.Text = "X";
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "PLAYER MENU ǀ MIND MAZE";
            // 
            // btnHam
            // 
            this.btnHam.Image = ((System.Drawing.Image)(resources.GetObject("btnHam.Image")));
            this.btnHam.Location = new System.Drawing.Point(3, 3);
            this.btnHam.Name = "btnHam";
            this.btnHam.Size = new System.Drawing.Size(34, 30);
            this.btnHam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnHam.TabIndex = 1;
            this.btnHam.TabStop = false;
            this.btnHam.Click += new System.EventHandler(this.btnHam_Click);
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.sidebar.Controls.Add(this.pnDashboard);
            this.sidebar.Controls.Add(this.menuContainer);
            this.sidebar.Controls.Add(this.pnAbout);
            this.sidebar.Controls.Add(this.pnSettings);
            this.sidebar.Controls.Add(this.pnLogout);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.sidebar.Location = new System.Drawing.Point(0, 36);
            this.sidebar.Name = "sidebar";
            this.sidebar.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.sidebar.Size = new System.Drawing.Size(150, 539);
            this.sidebar.TabIndex = 1;
            // 
            // pnDashboard
            // 
            this.pnDashboard.Controls.Add(this.button1);
            this.pnDashboard.Location = new System.Drawing.Point(3, 33);
            this.pnDashboard.Name = "pnDashboard";
            this.pnDashboard.Size = new System.Drawing.Size(159, 33);
            this.pnDashboard.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(-11, -10);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(177, 52);
            this.button1.TabIndex = 4;
            this.button1.Text = "        Dashboard";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuContainer
            // 
            this.menuContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.menuContainer.Controls.Add(this.panel6);
            this.menuContainer.Controls.Add(this.panel7);
            this.menuContainer.Controls.Add(this.panel8);
            this.menuContainer.Location = new System.Drawing.Point(0, 69);
            this.menuContainer.Margin = new System.Windows.Forms.Padding(0);
            this.menuContainer.Name = "menuContainer";
            this.menuContainer.Size = new System.Drawing.Size(159, 33);
            this.menuContainer.TabIndex = 7;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.menu);
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(159, 33);
            this.panel6.TabIndex = 8;
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.menu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu.ForeColor = System.Drawing.Color.White;
            this.menu.Image = ((System.Drawing.Image)(resources.GetObject("menu.Image")));
            this.menu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu.Location = new System.Drawing.Point(-11, -10);
            this.menu.Name = "menu";
            this.menu.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.menu.Size = new System.Drawing.Size(177, 52);
            this.menu.TabIndex = 4;
            this.menu.Text = "        Menu";
            this.menu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu.UseVisualStyleBackColor = false;
            this.menu.Click += new System.EventHandler(this.menu_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.submenu1);
            this.panel7.Location = new System.Drawing.Point(0, 33);
            this.panel7.Margin = new System.Windows.Forms.Padding(0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(159, 33);
            this.panel7.TabIndex = 9;
            // 
            // submenu1
            // 
            this.submenu1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.submenu1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submenu1.ForeColor = System.Drawing.Color.White;
            this.submenu1.Image = ((System.Drawing.Image)(resources.GetObject("submenu1.Image")));
            this.submenu1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.submenu1.Location = new System.Drawing.Point(-11, -10);
            this.submenu1.Name = "submenu1";
            this.submenu1.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.submenu1.Size = new System.Drawing.Size(177, 52);
            this.submenu1.TabIndex = 4;
            this.submenu1.Text = "        Menu 1";
            this.submenu1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.submenu1.UseVisualStyleBackColor = false;
            this.submenu1.Click += new System.EventHandler(this.submenu1_Click);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.submenu2);
            this.panel8.Location = new System.Drawing.Point(0, 66);
            this.panel8.Margin = new System.Windows.Forms.Padding(0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(159, 33);
            this.panel8.TabIndex = 10;
            // 
            // submenu2
            // 
            this.submenu2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.submenu2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submenu2.ForeColor = System.Drawing.Color.White;
            this.submenu2.Image = ((System.Drawing.Image)(resources.GetObject("submenu2.Image")));
            this.submenu2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.submenu2.Location = new System.Drawing.Point(-11, -10);
            this.submenu2.Name = "submenu2";
            this.submenu2.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.submenu2.Size = new System.Drawing.Size(177, 52);
            this.submenu2.TabIndex = 4;
            this.submenu2.Text = "        Menu 2";
            this.submenu2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.submenu2.UseVisualStyleBackColor = false;
            this.submenu2.Click += new System.EventHandler(this.submenu2_Click);
            // 
            // pnAbout
            // 
            this.pnAbout.Controls.Add(this.button2);
            this.pnAbout.Location = new System.Drawing.Point(3, 105);
            this.pnAbout.Name = "pnAbout";
            this.pnAbout.Size = new System.Drawing.Size(159, 33);
            this.pnAbout.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(-12, -11);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(177, 52);
            this.button2.TabIndex = 5;
            this.button2.Text = "        About";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pnSettings
            // 
            this.pnSettings.Controls.Add(this.gf);
            this.pnSettings.Location = new System.Drawing.Point(3, 144);
            this.pnSettings.Name = "pnSettings";
            this.pnSettings.Size = new System.Drawing.Size(159, 33);
            this.pnSettings.TabIndex = 5;
            // 
            // gf
            // 
            this.gf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.gf.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gf.ForeColor = System.Drawing.Color.White;
            this.gf.Image = ((System.Drawing.Image)(resources.GetObject("gf.Image")));
            this.gf.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gf.Location = new System.Drawing.Point(-11, -10);
            this.gf.Name = "gf";
            this.gf.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.gf.Size = new System.Drawing.Size(177, 52);
            this.gf.TabIndex = 4;
            this.gf.Text = "        Settings";
            this.gf.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gf.UseVisualStyleBackColor = false;
            this.gf.Click += new System.EventHandler(this.gf_Click);
            // 
            // pnLogout
            // 
            this.pnLogout.Controls.Add(this.hh);
            this.pnLogout.Location = new System.Drawing.Point(3, 183);
            this.pnLogout.Name = "pnLogout";
            this.pnLogout.Size = new System.Drawing.Size(159, 33);
            this.pnLogout.TabIndex = 6;
            // 
            // hh
            // 
            this.hh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.hh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hh.ForeColor = System.Drawing.Color.White;
            this.hh.Image = ((System.Drawing.Image)(resources.GetObject("hh.Image")));
            this.hh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hh.Location = new System.Drawing.Point(-11, -10);
            this.hh.Name = "hh";
            this.hh.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.hh.Size = new System.Drawing.Size(177, 52);
            this.hh.TabIndex = 4;
            this.hh.Text = "        Logout";
            this.hh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hh.UseVisualStyleBackColor = false;
            this.hh.Click += new System.EventHandler(this.hh_Click);
            // 
            // menuTransition
            // 
            this.menuTransition.Interval = 10;
            this.menuTransition.Tick += new System.EventHandler(this.menuTransition_Tick);
            // 
            // sidebarTransition
            // 
            this.sidebarTransition.Interval = 10;
            this.sidebarTransition.Tick += new System.EventHandler(this.sidebarTransition_Tick);
            // 
            // Form11
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(815, 575);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "Form11";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form11";
            this.Load += new System.EventHandler(this.Form11_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHam)).EndInit();
            this.sidebar.ResumeLayout(false);
            this.pnDashboard.ResumeLayout(false);
            this.menuContainer.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.pnAbout.ResumeLayout(false);
            this.pnSettings.ResumeLayout(false);
            this.pnLogout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnHam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Panel pnDashboard;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pnSettings;
        private System.Windows.Forms.Button gf;
        private System.Windows.Forms.Panel pnLogout;
        private System.Windows.Forms.Button hh;
        private System.Windows.Forms.FlowLayoutPanel menuContainer;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button menu;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button submenu1;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button submenu2;
        private System.Windows.Forms.Timer menuTransition;
        private System.Windows.Forms.Timer sidebarTransition;
        private System.Windows.Forms.Panel pnAbout;
        private System.Windows.Forms.Button button2;
    }
}