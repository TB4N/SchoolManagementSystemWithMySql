namespace SchoolManagementSystem
{
    partial class AddProfessor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProfessor));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label9 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.professor_image = new System.Windows.Forms.PictureBox();
            this.professor_status = new System.Windows.Forms.ComboBox();
            this.professor_subject = new System.Windows.Forms.ComboBox();
            this.professor_gender = new System.Windows.Forms.ComboBox();
            this.professor_ID = new System.Windows.Forms.TextBox();
            this.professor_address = new System.Windows.Forms.TextBox();
            this.professor_LName = new System.Windows.Forms.TextBox();
            this.professor_MName = new System.Windows.Forms.TextBox();
            this.professor_FName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.professor_import = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.professor_clearBtn = new System.Windows.Forms.Button();
            this.professor_updateBtn = new System.Windows.Forms.Button();
            this.professor_addBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.professor_gridData = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.professor_image)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.professor_gridData)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label9.Location = new System.Drawing.Point(3, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(143, 25);
            this.label9.TabIndex = 13;
            this.label9.Text = "Professor Data";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.professor_status);
            this.panel2.Controls.Add(this.professor_subject);
            this.panel2.Controls.Add(this.professor_gender);
            this.panel2.Controls.Add(this.professor_ID);
            this.panel2.Controls.Add(this.professor_address);
            this.panel2.Controls.Add(this.professor_LName);
            this.panel2.Controls.Add(this.professor_MName);
            this.panel2.Controls.Add(this.professor_FName);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.professor_import);
            this.panel2.Controls.Add(this.deleteBtn);
            this.panel2.Controls.Add(this.professor_clearBtn);
            this.panel2.Controls.Add(this.professor_updateBtn);
            this.panel2.Controls.Add(this.professor_addBtn);
            this.panel2.Location = new System.Drawing.Point(5, 276);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(840, 280);
            this.panel2.TabIndex = 12;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.professor_image);
            this.panel3.Location = new System.Drawing.Point(645, 66);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(185, 160);
            this.panel3.TabIndex = 22;
            // 
            // professor_image
            // 
            this.professor_image.BackColor = System.Drawing.Color.DimGray;
            this.professor_image.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("professor_image.BackgroundImage")));
            this.professor_image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.professor_image.Dock = System.Windows.Forms.DockStyle.Fill;
            this.professor_image.Location = new System.Drawing.Point(0, 0);
            this.professor_image.Name = "professor_image";
            this.professor_image.Size = new System.Drawing.Size(183, 158);
            this.professor_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.professor_image.TabIndex = 0;
            this.professor_image.TabStop = false;
            // 
            // professor_status
            // 
            this.professor_status.Cursor = System.Windows.Forms.Cursors.Hand;
            this.professor_status.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.professor_status.FormattingEnabled = true;
            this.professor_status.ImeMode = System.Windows.Forms.ImeMode.On;
            this.professor_status.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.professor_status.Location = new System.Drawing.Point(250, 131);
            this.professor_status.Name = "professor_status";
            this.professor_status.Size = new System.Drawing.Size(121, 29);
            this.professor_status.TabIndex = 21;
            // 
            // professor_subject
            // 
            this.professor_subject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.professor_subject.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.professor_subject.FormattingEnabled = true;
            this.professor_subject.ImeMode = System.Windows.Forms.ImeMode.On;
            this.professor_subject.Items.AddRange(new object[] {
            "Introduction to Information Technology",
            "Programming Fundamentals",
            "Database Management Systems",
            "Computer Networks",
            "Web Development",
            "Software Engineering",
            "Operating Systems",
            "Information Security",
            "Human-Computer Interaction",
            "Data Structures and Algorithms",
            "Digital Logic Design",
            "Computer Architecture",
            "Programming Fundamentals",
            "Data Structures and Algorithms",
            "Microprocessors and Microcontrollers",
            "Operating Systems",
            "Embedded Systems",
            "Signals and Systems",
            "Electronics",
            "Network Engineering",
            "Child and Adolescent Development",
            "Educational Technology",
            "Principles of Teaching",
            "Curriculum Development",
            "Assessment and Evaluation",
            "Educational Psychology",
            "Classroom Management",
            "Content and Pedagogy for Elementary Grades",
            "Special Education",
            "Field Study and Practice Teaching",
            "Introduction to Entrepreneurship",
            "Business Planning and Development",
            "Marketing for Entrepreneurs",
            "Financial Management",
            "Innovation and Technology Management",
            "Operations Management",
            "Legal Aspects of Business",
            "Human Resource Management",
            "Social Entrepreneurship",
            "Strategic Management"});
            this.professor_subject.Location = new System.Drawing.Point(250, 198);
            this.professor_subject.Name = "professor_subject";
            this.professor_subject.Size = new System.Drawing.Size(387, 29);
            this.professor_subject.TabIndex = 20;
            // 
            // professor_gender
            // 
            this.professor_gender.Cursor = System.Windows.Forms.Cursors.Hand;
            this.professor_gender.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.professor_gender.FormattingEnabled = true;
            this.professor_gender.ImeMode = System.Windows.Forms.ImeMode.On;
            this.professor_gender.Items.AddRange(new object[] {
            "Female",
            "Male",
            "Others"});
            this.professor_gender.Location = new System.Drawing.Point(250, 64);
            this.professor_gender.Name = "professor_gender";
            this.professor_gender.Size = new System.Drawing.Size(121, 29);
            this.professor_gender.TabIndex = 19;
            // 
            // professor_ID
            // 
            this.professor_ID.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.professor_ID.Location = new System.Drawing.Point(645, 30);
            this.professor_ID.MaxLength = 10;
            this.professor_ID.Multiline = true;
            this.professor_ID.Name = "professor_ID";
            this.professor_ID.Size = new System.Drawing.Size(185, 30);
            this.professor_ID.TabIndex = 18;
            this.professor_ID.TextChanged += new System.EventHandler(this.professor_ID_TextChanged);
            // 
            // professor_address
            // 
            this.professor_address.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.professor_address.Location = new System.Drawing.Point(379, 38);
            this.professor_address.Multiline = true;
            this.professor_address.Name = "professor_address";
            this.professor_address.Size = new System.Drawing.Size(258, 152);
            this.professor_address.TabIndex = 17;
            // 
            // professor_LName
            // 
            this.professor_LName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.professor_LName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.professor_LName.Location = new System.Drawing.Point(15, 185);
            this.professor_LName.Multiline = true;
            this.professor_LName.Name = "professor_LName";
            this.professor_LName.Size = new System.Drawing.Size(225, 30);
            this.professor_LName.TabIndex = 16;
            // 
            // professor_MName
            // 
            this.professor_MName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.professor_MName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.professor_MName.Location = new System.Drawing.Point(15, 120);
            this.professor_MName.Multiline = true;
            this.professor_MName.Name = "professor_MName";
            this.professor_MName.Size = new System.Drawing.Size(225, 30);
            this.professor_MName.TabIndex = 15;
            // 
            // professor_FName
            // 
            this.professor_FName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.professor_FName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.professor_FName.Location = new System.Drawing.Point(15, 55);
            this.professor_FName.Multiline = true;
            this.professor_FName.Name = "professor_FName";
            this.professor_FName.Size = new System.Drawing.Size(225, 30);
            this.professor_FName.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label8.Location = new System.Drawing.Point(375, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 21);
            this.label8.TabIndex = 13;
            this.label8.Text = "Present Address :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label7.Location = new System.Drawing.Point(642, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 21);
            this.label7.TabIndex = 12;
            this.label7.Text = "Professor ID :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label6.Location = new System.Drawing.Point(246, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 21);
            this.label6.TabIndex = 11;
            this.label6.Text = "Status :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label5.Location = new System.Drawing.Point(246, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = "Subject :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label4.Location = new System.Drawing.Point(246, 40);
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
            // professor_import
            // 
            this.professor_import.BackColor = System.Drawing.Color.DarkCyan;
            this.professor_import.Cursor = System.Windows.Forms.Cursors.Hand;
            this.professor_import.FlatAppearance.BorderSize = 0;
            this.professor_import.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.professor_import.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.professor_import.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.professor_import.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.professor_import.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.professor_import.Location = new System.Drawing.Point(645, 226);
            this.professor_import.Name = "professor_import";
            this.professor_import.Size = new System.Drawing.Size(185, 40);
            this.professor_import.TabIndex = 4;
            this.professor_import.Text = "Import";
            this.professor_import.UseVisualStyleBackColor = false;
            this.professor_import.Click += new System.EventHandler(this.professor_import_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.DarkCyan;
            this.deleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteBtn.FlatAppearance.BorderSize = 0;
            this.deleteBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.deleteBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.deleteBtn.Location = new System.Drawing.Point(490, 235);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(120, 40);
            this.deleteBtn.TabIndex = 3;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // professor_clearBtn
            // 
            this.professor_clearBtn.BackColor = System.Drawing.Color.DarkCyan;
            this.professor_clearBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.professor_clearBtn.FlatAppearance.BorderSize = 0;
            this.professor_clearBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.professor_clearBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.professor_clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.professor_clearBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.professor_clearBtn.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.professor_clearBtn.Location = new System.Drawing.Point(350, 235);
            this.professor_clearBtn.Name = "professor_clearBtn";
            this.professor_clearBtn.Size = new System.Drawing.Size(120, 40);
            this.professor_clearBtn.TabIndex = 2;
            this.professor_clearBtn.Text = "Clear";
            this.professor_clearBtn.UseVisualStyleBackColor = false;
            this.professor_clearBtn.Click += new System.EventHandler(this.professor_clearBtn_Click);
            // 
            // professor_updateBtn
            // 
            this.professor_updateBtn.BackColor = System.Drawing.Color.DarkCyan;
            this.professor_updateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.professor_updateBtn.FlatAppearance.BorderSize = 0;
            this.professor_updateBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.professor_updateBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.professor_updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.professor_updateBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.professor_updateBtn.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.professor_updateBtn.Location = new System.Drawing.Point(210, 235);
            this.professor_updateBtn.Name = "professor_updateBtn";
            this.professor_updateBtn.Size = new System.Drawing.Size(120, 40);
            this.professor_updateBtn.TabIndex = 1;
            this.professor_updateBtn.Text = "Update";
            this.professor_updateBtn.UseVisualStyleBackColor = false;
            this.professor_updateBtn.Click += new System.EventHandler(this.professor_updateBtn_Click);
            // 
            // professor_addBtn
            // 
            this.professor_addBtn.BackColor = System.Drawing.Color.DarkCyan;
            this.professor_addBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.professor_addBtn.FlatAppearance.BorderSize = 0;
            this.professor_addBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.professor_addBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.professor_addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.professor_addBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.professor_addBtn.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.professor_addBtn.Location = new System.Drawing.Point(70, 235);
            this.professor_addBtn.Name = "professor_addBtn";
            this.professor_addBtn.Size = new System.Drawing.Size(120, 40);
            this.professor_addBtn.TabIndex = 0;
            this.professor_addBtn.Text = "Add";
            this.professor_addBtn.UseVisualStyleBackColor = false;
            this.professor_addBtn.Click += new System.EventHandler(this.professor_addBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.professor_gridData);
            this.panel1.Location = new System.Drawing.Point(5, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(840, 240);
            this.panel1.TabIndex = 11;
            // 
            // professor_gridData
            // 
            this.professor_gridData.AllowUserToAddRows = false;
            this.professor_gridData.AllowUserToDeleteRows = false;
            this.professor_gridData.AllowUserToResizeRows = false;
            this.professor_gridData.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.professor_gridData.CausesValidation = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.professor_gridData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.professor_gridData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.professor_gridData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.professor_gridData.EnableHeadersVisualStyles = false;
            this.professor_gridData.Location = new System.Drawing.Point(0, 0);
            this.professor_gridData.Name = "professor_gridData";
            this.professor_gridData.ReadOnly = true;
            this.professor_gridData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.professor_gridData.RowHeadersVisible = false;
            this.professor_gridData.RowHeadersWidth = 350;
            this.professor_gridData.Size = new System.Drawing.Size(838, 238);
            this.professor_gridData.TabIndex = 1;
            this.professor_gridData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.professor_gridData_CellContentClick);
            // 
            // AddProfessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AddProfessor";
            this.Size = new System.Drawing.Size(850, 560);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.professor_image)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.professor_gridData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox professor_status;
        private System.Windows.Forms.ComboBox professor_subject;
        private System.Windows.Forms.ComboBox professor_gender;
        private System.Windows.Forms.TextBox professor_ID;
        private System.Windows.Forms.TextBox professor_address;
        private System.Windows.Forms.TextBox professor_LName;
        private System.Windows.Forms.TextBox professor_MName;
        private System.Windows.Forms.TextBox professor_FName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button professor_import;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button professor_clearBtn;
        private System.Windows.Forms.Button professor_updateBtn;
        private System.Windows.Forms.Button professor_addBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView professor_gridData;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox professor_image;
    }
}
