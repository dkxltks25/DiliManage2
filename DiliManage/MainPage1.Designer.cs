namespace DiliManage
{
    partial class MainPage1
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.sta = new System.Windows.Forms.Button();
            this.apt = new System.Windows.Forms.Button();
            this.ft = new System.Windows.Forms.Button();
            this.stu = new System.Windows.Forms.Button();
            this.re = new System.Windows.Forms.Button();
            this.cou = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(935, 60);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
            this.panel5.Controls.Add(this.sta);
            this.panel5.Controls.Add(this.apt);
            this.panel5.Controls.Add(this.ft);
            this.panel5.Controls.Add(this.stu);
            this.panel5.Controls.Add(this.re);
            this.panel5.Controls.Add(this.cou);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(935, 31);
            this.panel5.TabIndex = 2;
            // 
            // sta
            // 
            this.sta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
            this.sta.Dock = System.Windows.Forms.DockStyle.Left;
            this.sta.FlatAppearance.BorderSize = 0;
            this.sta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sta.ForeColor = System.Drawing.Color.White;
            this.sta.Location = new System.Drawing.Point(590, 0);
            this.sta.Name = "sta";
            this.sta.Size = new System.Drawing.Size(118, 31);
            this.sta.TabIndex = 8;
            this.sta.Text = "통계";
            this.sta.UseVisualStyleBackColor = false;
            this.sta.Click += new System.EventHandler(this.Sta_Click);
            // 
            // apt
            // 
            this.apt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
            this.apt.Dock = System.Windows.Forms.DockStyle.Left;
            this.apt.FlatAppearance.BorderSize = 0;
            this.apt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.apt.ForeColor = System.Drawing.Color.White;
            this.apt.Location = new System.Drawing.Point(472, 0);
            this.apt.Name = "apt";
            this.apt.Size = new System.Drawing.Size(118, 31);
            this.apt.TabIndex = 5;
            this.apt.Text = "실습생관리";
            this.apt.UseVisualStyleBackColor = false;
            this.apt.Click += new System.EventHandler(this.Apt_Click);
            // 
            // ft
            // 
            this.ft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
            this.ft.Dock = System.Windows.Forms.DockStyle.Left;
            this.ft.FlatAppearance.BorderSize = 0;
            this.ft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ft.ForeColor = System.Drawing.Color.White;
            this.ft.Location = new System.Drawing.Point(354, 0);
            this.ft.Name = "ft";
            this.ft.Size = new System.Drawing.Size(118, 31);
            this.ft.TabIndex = 4;
            this.ft.Text = "출결관리";
            this.ft.UseVisualStyleBackColor = false;
            this.ft.Click += new System.EventHandler(this.ft_Click);
            // 
            // stu
            // 
            this.stu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
            this.stu.Dock = System.Windows.Forms.DockStyle.Left;
            this.stu.FlatAppearance.BorderSize = 0;
            this.stu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stu.ForeColor = System.Drawing.Color.White;
            this.stu.Location = new System.Drawing.Point(236, 0);
            this.stu.Name = "stu";
            this.stu.Size = new System.Drawing.Size(118, 31);
            this.stu.TabIndex = 3;
            this.stu.Text = "학생관리";
            this.stu.UseVisualStyleBackColor = false;
            this.stu.Click += new System.EventHandler(this.stu_Click);
            // 
            // re
            // 
            this.re.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
            this.re.Dock = System.Windows.Forms.DockStyle.Left;
            this.re.FlatAppearance.BorderSize = 0;
            this.re.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.re.ForeColor = System.Drawing.Color.White;
            this.re.Location = new System.Drawing.Point(118, 0);
            this.re.Name = "re";
            this.re.Size = new System.Drawing.Size(118, 31);
            this.re.TabIndex = 2;
            this.re.Text = "신청관리";
            this.re.UseVisualStyleBackColor = false;
            this.re.Click += new System.EventHandler(this.re_Click);
            // 
            // cou
            // 
            this.cou.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
            this.cou.Dock = System.Windows.Forms.DockStyle.Left;
            this.cou.FlatAppearance.BorderSize = 0;
            this.cou.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cou.ForeColor = System.Drawing.Color.White;
            this.cou.Location = new System.Drawing.Point(0, 0);
            this.cou.Name = "cou";
            this.cou.Size = new System.Drawing.Size(118, 31);
            this.cou.TabIndex = 1;
            this.cou.Text = "코스관리";
            this.cou.UseVisualStyleBackColor = false;
            this.cou.Click += new System.EventHandler(this.cou_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(935, 609);
            this.panel1.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.listView1);
            this.panel7.Controls.Add(this.panel3);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 60);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(935, 549);
            this.panel7.TabIndex = 4;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(935, 489);
            this.listView1.TabIndex = 28;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.Leave += new System.EventHandler(this.listView1_Leave);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "근무일자";
            this.columnHeader1.Width = 210;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "학번";
            this.columnHeader2.Width = 252;
            // 
            // columnHeader3
            // 
            this.columnHeader3.DisplayIndex = 3;
            this.columnHeader3.Text = "출근시간";
            this.columnHeader3.Width = 157;
            // 
            // columnHeader4
            // 
            this.columnHeader4.DisplayIndex = 4;
            this.columnHeader4.Text = "퇴근시간";
            this.columnHeader4.Width = 158;
            // 
            // columnHeader5
            // 
            this.columnHeader5.DisplayIndex = 2;
            this.columnHeader5.Text = "이름";
            this.columnHeader5.Width = 153;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 489);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(935, 60);
            this.panel3.TabIndex = 27;
            // 
            // MainPage1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 609);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Location = new System.Drawing.Point(0, 100);
            this.Name = "MainPage1";
            this.Text = "MainPage1";
            this.Load += new System.EventHandler(this.MainPage1_Load);
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button ft;
        private System.Windows.Forms.Button stu;
        private System.Windows.Forms.Button re;
        private System.Windows.Forms.Button cou;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button apt;
        private System.Windows.Forms.Button sta;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}