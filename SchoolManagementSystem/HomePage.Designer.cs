namespace SchoolManagementSystem
{
    partial class HomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.panel1 = new System.Windows.Forms.Panel();
            this.closeBtn = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dashboardBtn = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.studentBtn = new System.Windows.Forms.Button();
            this.professorBtn = new System.Windows.Forms.Button();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dashboard2 = new SchoolManagementSystem.dashboard();
            this.addStudent1 = new SchoolManagementSystem.AddStudent();
            this.addProfessor1 = new SchoolManagementSystem.AddProfessor();
            this.dashboard1 = new SchoolManagementSystem.dashboard();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panel1.Controls.Add(this.closeBtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1100, 40);
            this.panel1.TabIndex = 0;
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBtn.AutoSize = true;
            this.closeBtn.BackColor = System.Drawing.Color.Red;
            this.closeBtn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.closeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBtn.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.closeBtn.Location = new System.Drawing.Point(1068, 8);
            this.closeBtn.Margin = new System.Windows.Forms.Padding(0);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Padding = new System.Windows.Forms.Padding(1, 0, 0, 1);
            this.closeBtn.Size = new System.Drawing.Size(23, 24);
            this.closeBtn.TabIndex = 3;
            this.closeBtn.Text = "X";
            this.closeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(44, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "School Management System |  Home";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ImageLocation = "D:\\Visual Studio C# .NET C++\\SchoolManagementSystem\\SchoolManagementSystem\\Assets" +
    "\\CDM.png";
            this.pictureBox1.Location = new System.Drawing.Point(4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // dashboardBtn
            // 
            this.dashboardBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dashboardBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray;
            this.dashboardBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.dashboardBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboardBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardBtn.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.dashboardBtn.Image = ((System.Drawing.Image)(resources.GetObject("dashboardBtn.Image")));
            this.dashboardBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboardBtn.Location = new System.Drawing.Point(43, 323);
            this.dashboardBtn.Name = "dashboardBtn";
            this.dashboardBtn.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.dashboardBtn.Size = new System.Drawing.Size(160, 45);
            this.dashboardBtn.TabIndex = 4;
            this.dashboardBtn.Text = "Dashboard";
            this.dashboardBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.dashboardBtn.UseVisualStyleBackColor = true;
            this.dashboardBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.ImageLocation = "D:\\Visual Studio C# .NET C++\\SchoolManagementSystem\\SchoolManagementSystem\\Assets" +
    "\\CDM.png";
            this.pictureBox3.Location = new System.Drawing.Point(48, 64);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(150, 150);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox2.Location = new System.Drawing.Point(0, 40);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(250, 560);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // studentBtn
            // 
            this.studentBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.studentBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray;
            this.studentBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.studentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.studentBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentBtn.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.studentBtn.Image = ((System.Drawing.Image)(resources.GetObject("studentBtn.Image")));
            this.studentBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.studentBtn.Location = new System.Drawing.Point(43, 377);
            this.studentBtn.Name = "studentBtn";
            this.studentBtn.Size = new System.Drawing.Size(160, 45);
            this.studentBtn.TabIndex = 5;
            this.studentBtn.Text = "Add Student";
            this.studentBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.studentBtn.UseVisualStyleBackColor = true;
            this.studentBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // professorBtn
            // 
            this.professorBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.professorBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray;
            this.professorBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.professorBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.professorBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.professorBtn.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.professorBtn.Image = ((System.Drawing.Image)(resources.GetObject("professorBtn.Image")));
            this.professorBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.professorBtn.Location = new System.Drawing.Point(43, 428);
            this.professorBtn.Name = "professorBtn";
            this.professorBtn.Size = new System.Drawing.Size(160, 45);
            this.professorBtn.TabIndex = 6;
            this.professorBtn.Text = "Add Professor";
            this.professorBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.professorBtn.UseVisualStyleBackColor = true;
            this.professorBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // logoutBtn
            // 
            this.logoutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoutBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.logoutBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.logoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBtn.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.logoutBtn.Image = ((System.Drawing.Image)(resources.GetObject("logoutBtn.Image")));
            this.logoutBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logoutBtn.Location = new System.Drawing.Point(2, 558);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(100, 40);
            this.logoutBtn.TabIndex = 7;
            this.logoutBtn.Text = "Logout";
            this.logoutBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.logoutBtn.UseVisualStyleBackColor = true;
            this.logoutBtn.Click += new System.EventHandler(this.button4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.label2.Location = new System.Drawing.Point(14, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 37);
            this.label2.TabIndex = 8;
            this.label2.Text = "Welcome Admin";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dashboard2);
            this.panel2.Controls.Add(this.addStudent1);
            this.panel2.Controls.Add(this.addProfessor1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(250, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(850, 560);
            this.panel2.TabIndex = 9;
            // 
            // dashboard2
            // 
            this.dashboard2.BackColor = System.Drawing.Color.MediumTurquoise;
            this.dashboard2.Location = new System.Drawing.Point(0, 1);
            this.dashboard2.Name = "dashboard2";
            this.dashboard2.Size = new System.Drawing.Size(850, 560);
            this.dashboard2.TabIndex = 2;
            // 
            // addStudent1
            // 
            this.addStudent1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.addStudent1.Location = new System.Drawing.Point(0, 1);
            this.addStudent1.Name = "addStudent1";
            this.addStudent1.Size = new System.Drawing.Size(850, 560);
            this.addStudent1.TabIndex = 1;
            // 
            // addProfessor1
            // 
            this.addProfessor1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.addProfessor1.Location = new System.Drawing.Point(0, 1);
            this.addProfessor1.Name = "addProfessor1";
            this.addProfessor1.Size = new System.Drawing.Size(850, 560);
            this.addProfessor1.TabIndex = 0;
            // 
            // dashboard1
            // 
            this.dashboard1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.dashboard1.Location = new System.Drawing.Point(249, 41);
            this.dashboard1.Name = "dashboard1";
            this.dashboard1.Size = new System.Drawing.Size(850, 560);
            this.dashboard1.TabIndex = 0;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1100, 600);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.logoutBtn);
            this.Controls.Add(this.professorBtn);
            this.Controls.Add(this.studentBtn);
            this.Controls.Add(this.dashboardBtn);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomePage";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label closeBtn;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button dashboardBtn;
        private dashboard dashboard1;
        private System.Windows.Forms.Button studentBtn;
        private System.Windows.Forms.Button professorBtn;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private AddProfessor addProfessor1;
        private AddStudent addStudent1;
        private dashboard dashboard2;
    }
}