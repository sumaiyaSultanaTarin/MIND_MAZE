namespace MIND_MAZE
{
    partial class AdminPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPanel));
            this.menuController = new System.Windows.Forms.FlowLayoutPanel();
            this.pnDeshboard = new System.Windows.Forms.Panel();
            this.pnFeed = new System.Windows.Forms.Panel();
            this.pnSettings = new System.Windows.Forms.Panel();
            this.ResultSection = new System.Windows.Forms.FlowLayoutPanel();
            this.pnResults = new System.Windows.Forms.Panel();
            this.pnEasy = new System.Windows.Forms.Panel();
            this.pnMedium = new System.Windows.Forms.Panel();
            this.pnhard = new System.Windows.Forms.Panel();
            this.pnLogout = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ResultTransition = new System.Windows.Forms.Timer(this.components);
            this.sidebarTrasition = new System.Windows.Forms.Timer(this.components);
            this.pnUpdate = new System.Windows.Forms.Panel();
            this.pnDelete = new System.Windows.Forms.Panel();
            this.pnInsert = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.Results = new System.Windows.Forms.Button();
            this.easy1 = new System.Windows.Forms.Button();
            this.medium1 = new System.Windows.Forms.Button();
            this.hard1 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.insert = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.Menu = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuController.SuspendLayout();
            this.pnDeshboard.SuspendLayout();
            this.pnFeed.SuspendLayout();
            this.pnSettings.SuspendLayout();
            this.ResultSection.SuspendLayout();
            this.pnResults.SuspendLayout();
            this.pnEasy.SuspendLayout();
            this.pnMedium.SuspendLayout();
            this.pnhard.SuspendLayout();
            this.pnLogout.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnUpdate.SuspendLayout();
            this.pnDelete.SuspendLayout();
            this.pnInsert.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuController
            // 
            this.menuController.BackColor = System.Drawing.Color.Turquoise;
            this.menuController.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.menuController.Controls.Add(this.pnDeshboard);
            this.menuController.Controls.Add(this.pnFeed);
            this.menuController.Controls.Add(this.pnSettings);
            this.menuController.Controls.Add(this.ResultSection);
            this.menuController.Controls.Add(this.pnLogout);
            this.menuController.Controls.Add(this.pnInsert);
            this.menuController.Controls.Add(this.pnUpdate);
            this.menuController.Controls.Add(this.pnDelete);
            this.menuController.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuController.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.menuController.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuController.Location = new System.Drawing.Point(0, 70);
            this.menuController.Name = "menuController";
            this.menuController.Size = new System.Drawing.Size(211, 638);
            this.menuController.TabIndex = 3;
            this.menuController.Paint += new System.Windows.Forms.PaintEventHandler(this.menuController_Paint);
            // 
            // pnDeshboard
            // 
            this.pnDeshboard.BackColor = System.Drawing.Color.Transparent;
            this.pnDeshboard.Controls.Add(this.button5);
            this.pnDeshboard.Location = new System.Drawing.Point(3, 3);
            this.pnDeshboard.Name = "pnDeshboard";
            this.pnDeshboard.Size = new System.Drawing.Size(207, 54);
            this.pnDeshboard.TabIndex = 18;
            // 
            // pnFeed
            // 
            this.pnFeed.Controls.Add(this.button19);
            this.pnFeed.Location = new System.Drawing.Point(3, 63);
            this.pnFeed.Name = "pnFeed";
            this.pnFeed.Size = new System.Drawing.Size(207, 54);
            this.pnFeed.TabIndex = 21;
            // 
            // pnSettings
            // 
            this.pnSettings.BackColor = System.Drawing.Color.Transparent;
            this.pnSettings.Controls.Add(this.button20);
            this.pnSettings.Location = new System.Drawing.Point(3, 123);
            this.pnSettings.Name = "pnSettings";
            this.pnSettings.Size = new System.Drawing.Size(207, 54);
            this.pnSettings.TabIndex = 20;
            // 
            // ResultSection
            // 
            this.ResultSection.BackColor = System.Drawing.Color.Transparent;
            this.ResultSection.Controls.Add(this.pnResults);
            this.ResultSection.Controls.Add(this.pnEasy);
            this.ResultSection.Controls.Add(this.pnMedium);
            this.ResultSection.Controls.Add(this.pnhard);
            this.ResultSection.Location = new System.Drawing.Point(0, 180);
            this.ResultSection.Margin = new System.Windows.Forms.Padding(0);
            this.ResultSection.Name = "ResultSection";
            this.ResultSection.Size = new System.Drawing.Size(206, 60);
            this.ResultSection.TabIndex = 22;
            // 
            // pnResults
            // 
            this.pnResults.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnResults.Controls.Add(this.Results);
            this.pnResults.Location = new System.Drawing.Point(3, 3);
            this.pnResults.Name = "pnResults";
            this.pnResults.Size = new System.Drawing.Size(207, 54);
            this.pnResults.TabIndex = 14;
            // 
            // pnEasy
            // 
            this.pnEasy.Controls.Add(this.easy1);
            this.pnEasy.Location = new System.Drawing.Point(3, 63);
            this.pnEasy.Name = "pnEasy";
            this.pnEasy.Size = new System.Drawing.Size(207, 54);
            this.pnEasy.TabIndex = 15;
            // 
            // pnMedium
            // 
            this.pnMedium.Controls.Add(this.medium1);
            this.pnMedium.Location = new System.Drawing.Point(3, 123);
            this.pnMedium.Name = "pnMedium";
            this.pnMedium.Size = new System.Drawing.Size(207, 54);
            this.pnMedium.TabIndex = 15;
            // 
            // pnhard
            // 
            this.pnhard.Controls.Add(this.hard1);
            this.pnhard.Location = new System.Drawing.Point(3, 183);
            this.pnhard.Name = "pnhard";
            this.pnhard.Size = new System.Drawing.Size(207, 54);
            this.pnhard.TabIndex = 16;
            // 
            // pnLogout
            // 
            this.pnLogout.BackColor = System.Drawing.Color.Transparent;
            this.pnLogout.Controls.Add(this.button6);
            this.pnLogout.Location = new System.Drawing.Point(3, 243);
            this.pnLogout.Name = "pnLogout";
            this.pnLogout.Size = new System.Drawing.Size(207, 54);
            this.pnLogout.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(22, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 28);
            this.label1.TabIndex = 28;
            this.label1.Text = "Admin Panel";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Turquoise;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.Menu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1087, 70);
            this.panel1.TabIndex = 1;
            // 
            // ResultTransition
            // 
            this.ResultTransition.Tick += new System.EventHandler(this.ResultTransition_Tick);
            // 
            // sidebarTrasition
            // 
            this.sidebarTrasition.Tick += new System.EventHandler(this.sidebarTrasition_Tick);
            // 
            // pnUpdate
            // 
            this.pnUpdate.BackColor = System.Drawing.Color.Transparent;
            this.pnUpdate.Controls.Add(this.update);
            this.pnUpdate.Location = new System.Drawing.Point(3, 363);
            this.pnUpdate.Name = "pnUpdate";
            this.pnUpdate.Size = new System.Drawing.Size(207, 54);
            this.pnUpdate.TabIndex = 20;
            // 
            // pnDelete
            // 
            this.pnDelete.BackColor = System.Drawing.Color.Transparent;
            this.pnDelete.Controls.Add(this.delete);
            this.pnDelete.Location = new System.Drawing.Point(3, 423);
            this.pnDelete.Name = "pnDelete";
            this.pnDelete.Size = new System.Drawing.Size(207, 54);
            this.pnDelete.TabIndex = 21;
            // 
            // pnInsert
            // 
            this.pnInsert.BackColor = System.Drawing.Color.Transparent;
            this.pnInsert.Controls.Add(this.insert);
            this.pnInsert.Location = new System.Drawing.Point(3, 303);
            this.pnInsert.Name = "pnInsert";
            this.pnInsert.Size = new System.Drawing.Size(207, 54);
            this.pnInsert.TabIndex = 22;
            // 
            // button5
            // 
            this.button5.AutoSize = true;
            this.button5.BackColor = System.Drawing.Color.Turquoise;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(0, 0);
            this.button5.Name = "button5";
            this.button5.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button5.Size = new System.Drawing.Size(207, 54);
            this.button5.TabIndex = 5;
            this.button5.Text = "         Dashboard";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button19
            // 
            this.button19.AutoSize = true;
            this.button19.BackColor = System.Drawing.Color.Turquoise;
            this.button19.FlatAppearance.BorderSize = 0;
            this.button19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button19.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button19.ForeColor = System.Drawing.Color.Black;
            this.button19.Image = ((System.Drawing.Image)(resources.GetObject("button19.Image")));
            this.button19.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button19.Location = new System.Drawing.Point(0, 0);
            this.button19.Name = "button19";
            this.button19.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.button19.Size = new System.Drawing.Size(207, 54);
            this.button19.TabIndex = 7;
            this.button19.Text = "          Feedbacks";
            this.button19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button19.UseVisualStyleBackColor = false;
            this.button19.Click += new System.EventHandler(this.button19_Click);
            // 
            // button20
            // 
            this.button20.AutoSize = true;
            this.button20.BackColor = System.Drawing.Color.Turquoise;
            this.button20.FlatAppearance.BorderSize = 0;
            this.button20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button20.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button20.ForeColor = System.Drawing.Color.Black;
            this.button20.Image = ((System.Drawing.Image)(resources.GetObject("button20.Image")));
            this.button20.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button20.Location = new System.Drawing.Point(0, 0);
            this.button20.Name = "button20";
            this.button20.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button20.Size = new System.Drawing.Size(207, 54);
            this.button20.TabIndex = 6;
            this.button20.Text = "         Settings";
            this.button20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button20.UseVisualStyleBackColor = false;
            this.button20.Click += new System.EventHandler(this.button20_Click);
            // 
            // Results
            // 
            this.Results.BackColor = System.Drawing.Color.Turquoise;
            this.Results.FlatAppearance.BorderSize = 0;
            this.Results.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Results.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Results.ForeColor = System.Drawing.Color.Black;
            this.Results.Image = global::MIND_MAZE.Properties.Resources.results;
            this.Results.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Results.Location = new System.Drawing.Point(-4, -1);
            this.Results.Name = "Results";
            this.Results.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Results.Size = new System.Drawing.Size(206, 54);
            this.Results.TabIndex = 10;
            this.Results.Text = "         Results";
            this.Results.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Results.UseVisualStyleBackColor = false;
            this.Results.Click += new System.EventHandler(this.Results_Click);
            // 
            // easy1
            // 
            this.easy1.AutoSize = true;
            this.easy1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.easy1.FlatAppearance.BorderSize = 0;
            this.easy1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.easy1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.easy1.ForeColor = System.Drawing.Color.Black;
            this.easy1.Image = ((System.Drawing.Image)(resources.GetObject("easy1.Image")));
            this.easy1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.easy1.Location = new System.Drawing.Point(0, 0);
            this.easy1.Name = "easy1";
            this.easy1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.easy1.Size = new System.Drawing.Size(207, 54);
            this.easy1.TabIndex = 12;
            this.easy1.Text = "        Beginner";
            this.easy1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.easy1.UseVisualStyleBackColor = false;
            this.easy1.Click += new System.EventHandler(this.easy1_Click);
            // 
            // medium1
            // 
            this.medium1.AutoSize = true;
            this.medium1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.medium1.FlatAppearance.BorderSize = 0;
            this.medium1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.medium1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medium1.ForeColor = System.Drawing.Color.Black;
            this.medium1.Image = ((System.Drawing.Image)(resources.GetObject("medium1.Image")));
            this.medium1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.medium1.Location = new System.Drawing.Point(0, 0);
            this.medium1.Name = "medium1";
            this.medium1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.medium1.Size = new System.Drawing.Size(207, 54);
            this.medium1.TabIndex = 13;
            this.medium1.Text = "        Medium";
            this.medium1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.medium1.UseVisualStyleBackColor = false;
            this.medium1.Click += new System.EventHandler(this.medium1_Click);
            // 
            // hard1
            // 
            this.hard1.AutoSize = true;
            this.hard1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.hard1.FlatAppearance.BorderSize = 0;
            this.hard1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hard1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hard1.ForeColor = System.Drawing.Color.Black;
            this.hard1.Image = ((System.Drawing.Image)(resources.GetObject("hard1.Image")));
            this.hard1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hard1.Location = new System.Drawing.Point(0, 0);
            this.hard1.Name = "hard1";
            this.hard1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.hard1.Size = new System.Drawing.Size(207, 54);
            this.hard1.TabIndex = 11;
            this.hard1.Text = "        Expert";
            this.hard1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hard1.UseVisualStyleBackColor = false;
            this.hard1.Click += new System.EventHandler(this.hard1_Click);
            // 
            // button6
            // 
            this.button6.AutoSize = true;
            this.button6.BackColor = System.Drawing.Color.Turquoise;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.Black;
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(0, 0);
            this.button6.Name = "button6";
            this.button6.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button6.Size = new System.Drawing.Size(207, 54);
            this.button6.TabIndex = 8;
            this.button6.Text = "         Logout";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // insert
            // 
            this.insert.AutoSize = true;
            this.insert.BackColor = System.Drawing.Color.Turquoise;
            this.insert.FlatAppearance.BorderSize = 0;
            this.insert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.insert.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insert.ForeColor = System.Drawing.Color.Black;
            this.insert.Image = ((System.Drawing.Image)(resources.GetObject("insert.Image")));
            this.insert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.insert.Location = new System.Drawing.Point(-3, 0);
            this.insert.Name = "insert";
            this.insert.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.insert.Size = new System.Drawing.Size(213, 54);
            this.insert.TabIndex = 8;
            this.insert.Text = "         Insert";
            this.insert.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.insert.UseVisualStyleBackColor = false;
            this.insert.Click += new System.EventHandler(this.button8_Click);
            // 
            // update
            // 
            this.update.AutoSize = true;
            this.update.BackColor = System.Drawing.Color.Turquoise;
            this.update.FlatAppearance.BorderSize = 0;
            this.update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.ForeColor = System.Drawing.Color.Black;
            this.update.Image = ((System.Drawing.Image)(resources.GetObject("update.Image")));
            this.update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.update.Location = new System.Drawing.Point(0, 0);
            this.update.Name = "update";
            this.update.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.update.Size = new System.Drawing.Size(207, 54);
            this.update.TabIndex = 8;
            this.update.Text = "         Update";
            this.update.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.update.UseVisualStyleBackColor = false;
            // 
            // delete
            // 
            this.delete.AutoSize = true;
            this.delete.BackColor = System.Drawing.Color.Turquoise;
            this.delete.FlatAppearance.BorderSize = 0;
            this.delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.ForeColor = System.Drawing.Color.Black;
            this.delete.Image = ((System.Drawing.Image)(resources.GetObject("delete.Image")));
            this.delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.delete.Location = new System.Drawing.Point(0, 0);
            this.delete.Name = "delete";
            this.delete.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.delete.Size = new System.Drawing.Size(207, 54);
            this.delete.TabIndex = 8;
            this.delete.Text = "         Delete";
            this.delete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.delete.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Turquoise;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::MIND_MAZE.Properties.Resources.Email;
            this.button2.Location = new System.Drawing.Point(965, 9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(52, 47);
            this.button2.TabIndex = 30;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Turquoise;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = global::MIND_MAZE.Properties.Resources.notification;
            this.button3.Location = new System.Drawing.Point(901, 7);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(58, 50);
            this.button3.TabIndex = 31;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Image = global::MIND_MAZE.Properties.Resources.admin;
            this.button4.Location = new System.Drawing.Point(1023, 9);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(52, 50);
            this.button4.TabIndex = 27;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.Color.Transparent;
            this.Menu.FlatAppearance.BorderSize = 0;
            this.Menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Menu.Image = global::MIND_MAZE.Properties.Resources.icons8_menu_50;
            this.Menu.Location = new System.Drawing.Point(181, 5);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(75, 54);
            this.Menu.TabIndex = 29;
            this.Menu.UseVisualStyleBackColor = false;
            this.Menu.Click += new System.EventHandler(this.Menu_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 708);
            this.ControlBox = false;
            this.Controls.Add(this.menuController);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "AdminPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminPanel";
            this.Load += new System.EventHandler(this.AdminPanel_Load);
            this.menuController.ResumeLayout(false);
            this.pnDeshboard.ResumeLayout(false);
            this.pnDeshboard.PerformLayout();
            this.pnFeed.ResumeLayout(false);
            this.pnFeed.PerformLayout();
            this.pnSettings.ResumeLayout(false);
            this.pnSettings.PerformLayout();
            this.ResultSection.ResumeLayout(false);
            this.pnResults.ResumeLayout(false);
            this.pnEasy.ResumeLayout(false);
            this.pnEasy.PerformLayout();
            this.pnMedium.ResumeLayout(false);
            this.pnMedium.PerformLayout();
            this.pnhard.ResumeLayout(false);
            this.pnhard.PerformLayout();
            this.pnLogout.ResumeLayout(false);
            this.pnLogout.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnUpdate.ResumeLayout(false);
            this.pnUpdate.PerformLayout();
            this.pnDelete.ResumeLayout(false);
            this.pnDelete.PerformLayout();
            this.pnInsert.ResumeLayout(false);
            this.pnInsert.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel menuController;
        private new System.Windows.Forms.Button Menu;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnDeshboard;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel pnFeed;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Panel pnSettings;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Panel pnLogout;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Timer ResultTransition;
        private System.Windows.Forms.Timer sidebarTrasition;
        private System.Windows.Forms.FlowLayoutPanel ResultSection;
        private System.Windows.Forms.Panel pnResults;
        private System.Windows.Forms.Button Results;
        private System.Windows.Forms.Panel pnEasy;
        private System.Windows.Forms.Button easy1;
        private System.Windows.Forms.Panel pnMedium;
        private System.Windows.Forms.Button medium1;
        private System.Windows.Forms.Panel pnhard;
        private System.Windows.Forms.Button hard1;
        private System.Windows.Forms.Panel pnUpdate;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Panel pnDelete;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Panel pnInsert;
        private System.Windows.Forms.Button insert;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}