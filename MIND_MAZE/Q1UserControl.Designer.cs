﻿namespace MIND_MAZE
{
    partial class Q1UserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.finish1 = new System.Windows.Forms.Button();
            this.RESET1 = new System.Windows.Forms.Button();
            this.next1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.types = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvInsertQuestions = new System.Windows.Forms.DataGridView();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.TYPES_TXT = new System.Windows.Forms.TextBox();
            this.Qtext = new System.Windows.Forms.TextBox();
            this.O1txt = new System.Windows.Forms.TextBox();
            this.O2txt = new System.Windows.Forms.TextBox();
            this.O3txt = new System.Windows.Forms.TextBox();
            this.Atxt = new System.Windows.Forms.TextBox();
            this.q1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInsertQuestions)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.q1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.Atxt);
            this.panel1.Controls.Add(this.O3txt);
            this.panel1.Controls.Add(this.O2txt);
            this.panel1.Controls.Add(this.O1txt);
            this.panel1.Controls.Add(this.Qtext);
            this.panel1.Controls.Add(this.TYPES_TXT);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.finish1);
            this.panel1.Controls.Add(this.RESET1);
            this.panel1.Controls.Add(this.next1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.types);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(726, 698);
            this.panel1.TabIndex = 0;
            // 
            // finish1
            // 
            this.finish1.BackColor = System.Drawing.Color.LightCoral;
            this.finish1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.finish1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finish1.Location = new System.Drawing.Point(453, 653);
            this.finish1.Name = "finish1";
            this.finish1.Size = new System.Drawing.Size(267, 34);
            this.finish1.TabIndex = 29;
            this.finish1.Text = "Finish";
            this.finish1.UseVisualStyleBackColor = false;
            this.finish1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // RESET1
            // 
            this.RESET1.BackColor = System.Drawing.Color.IndianRed;
            this.RESET1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RESET1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RESET1.Location = new System.Drawing.Point(618, 579);
            this.RESET1.Name = "RESET1";
            this.RESET1.Size = new System.Drawing.Size(75, 34);
            this.RESET1.TabIndex = 28;
            this.RESET1.Text = "RESET";
            this.RESET1.UseVisualStyleBackColor = false;
            // 
            // next1
            // 
            this.next1.BackColor = System.Drawing.Color.IndianRed;
            this.next1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.next1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.next1.Location = new System.Drawing.Point(478, 579);
            this.next1.Name = "next1";
            this.next1.Size = new System.Drawing.Size(75, 34);
            this.next1.TabIndex = 27;
            this.next1.Text = "NEXT";
            this.next1.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(538, 489);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 19);
            this.label5.TabIndex = 26;
            this.label5.Text = "Answer";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 321);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 19);
            this.label4.TabIndex = 24;
            this.label4.Text = "Question:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 433);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 19);
            this.label3.TabIndex = 22;
            this.label3.Text = "Options 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 540);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 19);
            this.label2.TabIndex = 20;
            this.label2.Text = "Options 2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 631);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 19);
            this.label1.TabIndex = 18;
            this.label1.Text = "Options 3";
            // 
            // types
            // 
            this.types.AutoSize = true;
            this.types.BackColor = System.Drawing.Color.Transparent;
            this.types.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.types.Location = new System.Drawing.Point(39, 196);
            this.types.Name = "types";
            this.types.Size = new System.Drawing.Size(56, 19);
            this.types.TabIndex = 16;
            this.types.Text = "Types";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(163, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(360, 40);
            this.label6.TabIndex = 30;
            this.label6.Text = "Insert New Questions";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.dgvInsertQuestions);
            this.panel2.Location = new System.Drawing.Point(744, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(541, 698);
            this.panel2.TabIndex = 1;
            // 
            // dgvInsertQuestions
            // 
            this.dgvInsertQuestions.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dgvInsertQuestions.AllowUserToDeleteRows = false;
            this.dgvInsertQuestions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvInsertQuestions.ColumnHeadersHeight = 35;
            this.dgvInsertQuestions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Type,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInsertQuestions.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInsertQuestions.Location = new System.Drawing.Point(-1, 105);
            this.dgvInsertQuestions.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvInsertQuestions.Name = "dgvInsertQuestions";
            this.dgvInsertQuestions.ReadOnly = true;
            this.dgvInsertQuestions.RowHeadersWidth = 51;
            this.dgvInsertQuestions.RowTemplate.Height = 24;
            this.dgvInsertQuestions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInsertQuestions.Size = new System.Drawing.Size(537, 592);
            this.dgvInsertQuestions.TabIndex = 0;
            // 
            // Type
            // 
            this.Type.HeaderText = "Types";
            this.Type.MinimumWidth = 6;
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            this.Type.Width = 125;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Question";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Option 1";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Option 2";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Option 3";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Answer";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 125;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(103, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(285, 40);
            this.label7.TabIndex = 31;
            this.label7.Text = "List Of Questions";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // TYPES_TXT
            // 
            this.TYPES_TXT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TYPES_TXT.Location = new System.Drawing.Point(43, 239);
            this.TYPES_TXT.Multiline = true;
            this.TYPES_TXT.Name = "TYPES_TXT";
            this.TYPES_TXT.Size = new System.Drawing.Size(230, 30);
            this.TYPES_TXT.TabIndex = 31;
            // 
            // Qtext
            // 
            this.Qtext.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Qtext.Location = new System.Drawing.Point(32, 360);
            this.Qtext.Multiline = true;
            this.Qtext.Name = "Qtext";
            this.Qtext.Size = new System.Drawing.Size(374, 30);
            this.Qtext.TabIndex = 32;
            // 
            // O1txt
            // 
            this.O1txt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.O1txt.Location = new System.Drawing.Point(28, 478);
            this.O1txt.Multiline = true;
            this.O1txt.Name = "O1txt";
            this.O1txt.Size = new System.Drawing.Size(230, 30);
            this.O1txt.TabIndex = 33;
            this.O1txt.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // O2txt
            // 
            this.O2txt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.O2txt.Location = new System.Drawing.Point(28, 579);
            this.O2txt.Multiline = true;
            this.O2txt.Name = "O2txt";
            this.O2txt.Size = new System.Drawing.Size(230, 30);
            this.O2txt.TabIndex = 34;
            // 
            // O3txt
            // 
            this.O3txt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.O3txt.Location = new System.Drawing.Point(28, 657);
            this.O3txt.Multiline = true;
            this.O3txt.Name = "O3txt";
            this.O3txt.Size = new System.Drawing.Size(230, 30);
            this.O3txt.TabIndex = 35;
            // 
            // Atxt
            // 
            this.Atxt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Atxt.Location = new System.Drawing.Point(463, 529);
            this.Atxt.Multiline = true;
            this.Atxt.Name = "Atxt";
            this.Atxt.Size = new System.Drawing.Size(230, 30);
            this.Atxt.TabIndex = 36;
            // 
            // q1
            // 
            this.q1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.q1.Location = new System.Drawing.Point(463, 239);
            this.q1.Name = "q1";
            this.q1.Size = new System.Drawing.Size(45, 22);
            this.q1.TabIndex = 38;
            this.q1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(459, 196);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 19);
            this.label8.TabIndex = 37;
            this.label8.Text = "Q No.";
            // 
            // Q1UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Q1UserControl";
            this.Size = new System.Drawing.Size(1285, 708);
            this.Load += new System.EventHandler(this.Q1UserControl_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInsertQuestions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button finish1;
        private System.Windows.Forms.Button RESET1;
        private System.Windows.Forms.Button next1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label types;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvInsertQuestions;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.TextBox O3txt;
        private System.Windows.Forms.TextBox O2txt;
        private System.Windows.Forms.TextBox O1txt;
        private System.Windows.Forms.TextBox Qtext;
        private System.Windows.Forms.TextBox TYPES_TXT;
        private System.Windows.Forms.TextBox Atxt;
        private System.Windows.Forms.TextBox q1;
        private System.Windows.Forms.Label label8;
    }
}
