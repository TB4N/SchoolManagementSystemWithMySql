namespace SchoolManagementSystem
{
    partial class AddStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddStudent));
            this.panel1 = new System.Windows.Forms.Panel();
            this.student_gridData = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.student_image = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.student_status = new System.Windows.Forms.ComboBox();
            this.student_address = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.student_section = new System.Windows.Forms.ComboBox();
            this.student_CsYr = new System.Windows.Forms.ComboBox();
            this.student_gender = new System.Windows.Forms.ComboBox();
            this.student_ID = new System.Windows.Forms.TextBox();
            this.student_LName = new System.Windows.Forms.TextBox();
            this.student_MName = new System.Windows.Forms.TextBox();
            this.student_FName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.student_Import = new System.Windows.Forms.Button();
            this.student_Delete = new System.Windows.Forms.Button();
            this.student_Clear = new System.Windows.Forms.Button();
            this.student_Update = new System.Windows.Forms.Button();
            this.student_Add = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.student_gridData)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.student_image)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.student_gridData);
            this.panel1.Location = new System.Drawing.Point(5, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(840, 240);
            this.panel1.TabIndex = 0;
            // 
            // student_gridData
            // 
            this.student_gridData.AllowUserToAddRows = false;
            this.student_gridData.AllowUserToDeleteRows = false;
            this.student_gridData.AllowUserToResizeRows = false;
            this.student_gridData.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.student_gridData.CausesValidation = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.student_gridData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.student_gridData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.student_gridData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.student_gridData.EnableHeadersVisualStyles = false;
            this.student_gridData.Location = new System.Drawing.Point(0, 0);
            this.student_gridData.Name = "student_gridData";
            this.student_gridData.ReadOnly = true;
            this.student_gridData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.student_gridData.RowHeadersVisible = false;
            this.student_gridData.Size = new System.Drawing.Size(838, 238);
            this.student_gridData.TabIndex = 1;
            this.student_gridData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.student_gridData_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.student_status);
            this.panel2.Controls.Add(this.student_address);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.student_section);
            this.panel2.Controls.Add(this.student_CsYr);
            this.panel2.Controls.Add(this.student_gender);
            this.panel2.Controls.Add(this.student_ID);
            this.panel2.Controls.Add(this.student_LName);
            this.panel2.Controls.Add(this.student_MName);
            this.panel2.Controls.Add(this.student_FName);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.student_Import);
            this.panel2.Controls.Add(this.student_Delete);
            this.panel2.Controls.Add(this.student_Clear);
            this.panel2.Controls.Add(this.student_Update);
            this.panel2.Controls.Add(this.student_Add);
            this.panel2.Location = new System.Drawing.Point(5, 276);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(840, 280);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.student_image);
            this.panel3.Location = new System.Drawing.Point(645, 66);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(185, 160);
            this.panel3.TabIndex = 24;
            // 
            // student_image
            // 
            this.student_image.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("student_image.BackgroundImage")));
            this.student_image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.student_image.Dock = System.Windows.Forms.DockStyle.Fill;
            this.student_image.Location = new System.Drawing.Point(0, 0);
            this.student_image.Name = "student_image";
            this.student_image.Size = new System.Drawing.Size(183, 158);
            this.student_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.student_image.TabIndex = 0;
            this.student_image.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label8.Location = new System.Drawing.Point(407, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 21);
            this.label8.TabIndex = 13;
            this.label8.Text = "Present Address :";
            // 
            // student_status
            // 
            this.student_status.Cursor = System.Windows.Forms.Cursors.Hand;
            this.student_status.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.student_status.FormattingEnabled = true;
            this.student_status.Items.AddRange(new object[] {
            "Enrolled",
            "Pending",
            "Graduated"});
            this.student_status.Location = new System.Drawing.Point(260, 198);
            this.student_status.Name = "student_status";
            this.student_status.Size = new System.Drawing.Size(135, 29);
            this.student_status.TabIndex = 23;
            // 
            // student_address
            // 
            this.student_address.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.student_address.Location = new System.Drawing.Point(411, 32);
            this.student_address.Multiline = true;
            this.student_address.Name = "student_address";
            this.student_address.Size = new System.Drawing.Size(226, 196);
            this.student_address.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label10.Location = new System.Drawing.Point(257, 175);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 21);
            this.label10.TabIndex = 22;
            this.label10.Text = "Status :";
            // 
            // student_section
            // 
            this.student_section.Cursor = System.Windows.Forms.Cursors.Hand;
            this.student_section.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.student_section.FormattingEnabled = true;
            this.student_section.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G"});
            this.student_section.Location = new System.Drawing.Point(260, 144);
            this.student_section.Name = "student_section";
            this.student_section.Size = new System.Drawing.Size(135, 29);
            this.student_section.TabIndex = 21;
            // 
            // student_CsYr
            // 
            this.student_CsYr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.student_CsYr.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.student_CsYr.FormattingEnabled = true;
            this.student_CsYr.Items.AddRange(new object[] {
            "BSIT 1st Year",
            "BSIT 2nd Year",
            "BSIT 3rd Year",
            "BSIT 4th Year",
            "BEED 1st Year",
            "BEED 2nd Year",
            "BEED 3rd Year",
            "BEED 4th Year",
            "BSBA 1st Year",
            "BSBA 2nd Year",
            "BSBA 3rd Year",
            "BSBA 4th Year",
            "BSCpE 1st Year",
            "BSCpE 2nd Year",
            "BSCpE 3rd Year",
            "BSCpE 4th Year",
            "BSEntrep 1st Year",
            "BSEntrep 2nd Year",
            "BSEntrep 3rdYear",
            "BSEntrep 4th Year"});
            this.student_CsYr.Location = new System.Drawing.Point(260, 90);
            this.student_CsYr.Name = "student_CsYr";
            this.student_CsYr.Size = new System.Drawing.Size(135, 29);
            this.student_CsYr.TabIndex = 20;
            // 
            // student_gender
            // 
            this.student_gender.Cursor = System.Windows.Forms.Cursors.Hand;
            this.student_gender.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.student_gender.FormattingEnabled = true;
            this.student_gender.Items.AddRange(new object[] {
            "Female",
            "Male",
            "Others"});
            this.student_gender.Location = new System.Drawing.Point(261, 36);
            this.student_gender.Name = "student_gender";
            this.student_gender.Size = new System.Drawing.Size(135, 29);
            this.student_gender.TabIndex = 19;
            // 
            // student_ID
            // 
            this.student_ID.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.student_ID.Location = new System.Drawing.Point(645, 30);
            this.student_ID.MaxLength = 10;
            this.student_ID.Multiline = true;
            this.student_ID.Name = "student_ID";
            this.student_ID.Size = new System.Drawing.Size(185, 30);
            this.student_ID.TabIndex = 18;
            // 
            // student_LName
            // 
            this.student_LName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.student_LName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.student_LName.Location = new System.Drawing.Point(15, 185);
            this.student_LName.Multiline = true;
            this.student_LName.Name = "student_LName";
            this.student_LName.Size = new System.Drawing.Size(225, 30);
            this.student_LName.TabIndex = 16;
            // 
            // student_MName
            // 
            this.student_MName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.student_MName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.student_MName.Location = new System.Drawing.Point(15, 120);
            this.student_MName.Multiline = true;
            this.student_MName.Name = "student_MName";
            this.student_MName.Size = new System.Drawing.Size(225, 30);
            this.student_MName.TabIndex = 15;
            // 
            // student_FName
            // 
            this.student_FName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.student_FName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.student_FName.Location = new System.Drawing.Point(15, 55);
            this.student_FName.Multiline = true;
            this.student_FName.Name = "student_FName";
            this.student_FName.Size = new System.Drawing.Size(225, 30);
            this.student_FName.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label7.Location = new System.Drawing.Point(642, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 21);
            this.label7.TabIndex = 12;
            this.label7.Text = "Student ID :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label6.Location = new System.Drawing.Point(257, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 21);
            this.label6.TabIndex = 11;
            this.label6.Text = "Section :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label5.Location = new System.Drawing.Point(257, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = "Course and Year :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label4.Location = new System.Drawing.Point(258, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "Gender :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(10, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Last Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(10, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Middle Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(10, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "First Name :";
            // 
            // student_Import
            // 
            this.student_Import.BackColor = System.Drawing.Color.DarkCyan;
            this.student_Import.Cursor = System.Windows.Forms.Cursors.Hand;
            this.student_Import.FlatAppearance.BorderSize = 0;
            this.student_Import.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.student_Import.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.student_Import.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.student_Import.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.student_Import.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.student_Import.Location = new System.Drawing.Point(645, 226);
            this.student_Import.Name = "student_Import";
            this.student_Import.Size = new System.Drawing.Size(185, 40);
            this.student_Import.TabIndex = 4;
            this.student_Import.Text = "Import";
            this.student_Import.UseVisualStyleBackColor = false;
            this.student_Import.Click += new System.EventHandler(this.student_Import_Click);
            // 
            // student_Delete
            // 
            this.student_Delete.BackColor = System.Drawing.Color.DarkCyan;
            this.student_Delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.student_Delete.FlatAppearance.BorderSize = 0;
            this.student_Delete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.student_Delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.student_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.student_Delete.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.student_Delete.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.student_Delete.Location = new System.Drawing.Point(490, 235);
            this.student_Delete.Name = "student_Delete";
            this.student_Delete.Size = new System.Drawing.Size(120, 40);
            this.student_Delete.TabIndex = 3;
            this.student_Delete.Text = "Delete";
            this.student_Delete.UseVisualStyleBackColor = false;
            this.student_Delete.Click += new System.EventHandler(this.student_Delete_Click);
            // 
            // student_Clear
            // 
            this.student_Clear.BackColor = System.Drawing.Color.DarkCyan;
            this.student_Clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.student_Clear.FlatAppearance.BorderSize = 0;
            this.student_Clear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.student_Clear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.student_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.student_Clear.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.student_Clear.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.student_Clear.Location = new System.Drawing.Point(350, 235);
            this.student_Clear.Name = "student_Clear";
            this.student_Clear.Size = new System.Drawing.Size(120, 40);
            this.student_Clear.TabIndex = 2;
            this.student_Clear.Text = "Clear";
            this.student_Clear.UseVisualStyleBackColor = false;
            this.student_Clear.Click += new System.EventHandler(this.student_Clear_Click);
            // 
            // student_Update
            // 
            this.student_Update.BackColor = System.Drawing.Color.DarkCyan;
            this.student_Update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.student_Update.FlatAppearance.BorderSize = 0;
            this.student_Update.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.student_Update.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.student_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.student_Update.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.student_Update.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.student_Update.Location = new System.Drawing.Point(210, 235);
            this.student_Update.Name = "student_Update";
            this.student_Update.Size = new System.Drawing.Size(120, 40);
            this.student_Update.TabIndex = 1;
            this.student_Update.Text = "Update";
            this.student_Update.UseVisualStyleBackColor = false;
            this.student_Update.Click += new System.EventHandler(this.student_Update_Click);
            // 
            // student_Add
            // 
            this.student_Add.BackColor = System.Drawing.Color.DarkCyan;
            this.student_Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.student_Add.FlatAppearance.BorderSize = 0;
            this.student_Add.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.student_Add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.student_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.student_Add.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.student_Add.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.student_Add.Location = new System.Drawing.Point(70, 235);
            this.student_Add.Name = "student_Add";
            this.student_Add.Size = new System.Drawing.Size(120, 40);
            this.student_Add.TabIndex = 0;
            this.student_Add.Text = "Add";
            this.student_Add.UseVisualStyleBackColor = false;
            this.student_Add.Click += new System.EventHandler(this.student_Add_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.MediumTurquoise;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label9.Location = new System.Drawing.Point(3, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(129, 25);
            this.label9.TabIndex = 10;
            this.label9.Text = "Student Data";
            // 
            // AddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AddStudent";
            this.Size = new System.Drawing.Size(850, 560);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.student_gridData)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.student_image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel imagePath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button student_Import;
        private System.Windows.Forms.Button student_Delete;
        private System.Windows.Forms.Button student_Clear;
        private System.Windows.Forms.Button student_Update;
        private System.Windows.Forms.Button student_Add;
        private System.Windows.Forms.TextBox student_ID;
        private System.Windows.Forms.TextBox student_address;
        private System.Windows.Forms.TextBox student_LName;
        private System.Windows.Forms.TextBox student_MName;
        private System.Windows.Forms.TextBox student_FName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox student_section;
        private System.Windows.Forms.ComboBox student_CsYr;
        private System.Windows.Forms.ComboBox student_gender;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox student_status;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView student_gridData;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox student_image;
    }
}
