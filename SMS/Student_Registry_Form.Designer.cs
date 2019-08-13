namespace SMS
{
    partial class Student_Registry_Form
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
            this.btnStudentRegister = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textFirstName = new System.Windows.Forms.TextBox();
            this.textLastName = new System.Windows.Forms.TextBox();
            this.textStudentId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.studentGridView = new System.Windows.Forms.DataGridView();
            this.Student_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Student_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Course = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textStudentSearch = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboCourses = new System.Windows.Forms.ComboBox();
            this.checkedListCourses = new System.Windows.Forms.CheckedListBox();
            this.btnRemoveCourse = new System.Windows.Forms.Button();
            this.btnAddCourse = new System.Windows.Forms.Button();
            this.btnGetAllStudents = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.studentGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStudentRegister
            // 
            this.btnStudentRegister.Location = new System.Drawing.Point(246, 156);
            this.btnStudentRegister.Name = "btnStudentRegister";
            this.btnStudentRegister.Size = new System.Drawing.Size(101, 23);
            this.btnStudentRegister.TabIndex = 0;
            this.btnStudentRegister.Text = "Register";
            this.btnStudentRegister.UseVisualStyleBackColor = true;
            this.btnStudentRegister.Click += new System.EventHandler(this.BtnRegistration_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Student Registration:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "First Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(184, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Last Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(197, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Course:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Student Id:";
            // 
            // textFirstName
            // 
            this.textFirstName.Location = new System.Drawing.Point(81, 43);
            this.textFirstName.Name = "textFirstName";
            this.textFirstName.Size = new System.Drawing.Size(100, 20);
            this.textFirstName.TabIndex = 7;
            // 
            // textLastName
            // 
            this.textLastName.Location = new System.Drawing.Point(247, 42);
            this.textLastName.Name = "textLastName";
            this.textLastName.Size = new System.Drawing.Size(100, 20);
            this.textLastName.TabIndex = 8;
            // 
            // textStudentId
            // 
            this.textStudentId.Location = new System.Drawing.Point(81, 72);
            this.textStudentId.Name = "textStudentId";
            this.textStudentId.Size = new System.Drawing.Size(99, 20);
            this.textStudentId.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 212);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Student List:";
            // 
            // studentGridView
            // 
            this.studentGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Student_Id,
            this.Student_Name,
            this.Course});
            this.studentGridView.Location = new System.Drawing.Point(21, 235);
            this.studentGridView.Name = "studentGridView";
            this.studentGridView.Size = new System.Drawing.Size(326, 150);
            this.studentGridView.TabIndex = 13;
            // 
            // Student_Id
            // 
            this.Student_Id.DataPropertyName = "Student_Id";
            this.Student_Id.HeaderText = "Student Id";
            this.Student_Id.Name = "Student_Id";
            // 
            // Student_Name
            // 
            this.Student_Name.DataPropertyName = "Student_Name";
            this.Student_Name.HeaderText = "Student Name";
            this.Student_Name.Name = "Student_Name";
            // 
            // Course
            // 
            this.Course.DataPropertyName = "Course";
            this.Course.HeaderText = "Course";
            this.Course.Name = "Course";
            // 
            // textStudentSearch
            // 
            this.textStudentSearch.Location = new System.Drawing.Point(264, 209);
            this.textStudentSearch.Name = "textStudentSearch";
            this.textStudentSearch.Size = new System.Drawing.Size(83, 20);
            this.textStudentSearch.TabIndex = 14;
            this.textStudentSearch.TextChanged += new System.EventHandler(this.TextStudentSearch_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(197, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Search:";
            // 
            // comboCourses
            // 
            this.comboCourses.FormattingEnabled = true;
            this.comboCourses.Location = new System.Drawing.Point(246, 68);
            this.comboCourses.Name = "comboCourses";
            this.comboCourses.Size = new System.Drawing.Size(101, 21);
            this.comboCourses.TabIndex = 16;
            this.comboCourses.SelectedIndexChanged += new System.EventHandler(this.ComboCourses_SelectedIndexChanged);
            // 
            // checkedListCourses
            // 
            this.checkedListCourses.FormattingEnabled = true;
            this.checkedListCourses.Location = new System.Drawing.Point(21, 98);
            this.checkedListCourses.Name = "checkedListCourses";
            this.checkedListCourses.Size = new System.Drawing.Size(219, 79);
            this.checkedListCourses.TabIndex = 17;
            this.checkedListCourses.SelectedIndexChanged += new System.EventHandler(this.CheckedListCourses_SelectedIndexChanged);
            // 
            // btnRemoveCourse
            // 
            this.btnRemoveCourse.Location = new System.Drawing.Point(246, 127);
            this.btnRemoveCourse.Name = "btnRemoveCourse";
            this.btnRemoveCourse.Size = new System.Drawing.Size(101, 23);
            this.btnRemoveCourse.TabIndex = 18;
            this.btnRemoveCourse.Text = "Remove Course";
            this.btnRemoveCourse.UseVisualStyleBackColor = true;
            this.btnRemoveCourse.Visible = false;
            this.btnRemoveCourse.Click += new System.EventHandler(this.BtnRemoveCourse_Click);
            // 
            // btnAddCourse
            // 
            this.btnAddCourse.Location = new System.Drawing.Point(246, 98);
            this.btnAddCourse.Name = "btnAddCourse";
            this.btnAddCourse.Size = new System.Drawing.Size(101, 23);
            this.btnAddCourse.TabIndex = 19;
            this.btnAddCourse.Text = "Add Course";
            this.btnAddCourse.UseVisualStyleBackColor = true;
            this.btnAddCourse.Visible = false;
            this.btnAddCourse.Click += new System.EventHandler(this.BtnAddCourse_Click);
            // 
            // btnGetAllStudents
            // 
            this.btnGetAllStudents.Location = new System.Drawing.Point(21, 391);
            this.btnGetAllStudents.Name = "btnGetAllStudents";
            this.btnGetAllStudents.Size = new System.Drawing.Size(85, 23);
            this.btnGetAllStudents.TabIndex = 20;
            this.btnGetAllStudents.Text = "Get All Students";
            this.btnGetAllStudents.UseVisualStyleBackColor = true;
            this.btnGetAllStudents.Click += new System.EventHandler(this.BtnGetAllStudents_Click);
            // 
            // Student_Registry_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 430);
            this.Controls.Add(this.btnGetAllStudents);
            this.Controls.Add(this.btnAddCourse);
            this.Controls.Add(this.btnRemoveCourse);
            this.Controls.Add(this.checkedListCourses);
            this.Controls.Add(this.comboCourses);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textStudentSearch);
            this.Controls.Add(this.studentGridView);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textStudentId);
            this.Controls.Add(this.textLastName);
            this.Controls.Add(this.textFirstName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStudentRegister);
            this.Name = "Student_Registry_Form";
            this.Text = "Student Registry Form";
            ((System.ComponentModel.ISupportInitialize)(this.studentGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStudentRegister;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textFirstName;
        private System.Windows.Forms.TextBox textLastName;
        private System.Windows.Forms.TextBox textStudentId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView studentGridView;
        private System.Windows.Forms.TextBox textStudentSearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Student_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Student_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Course;
        private System.Windows.Forms.ComboBox comboCourses;
        private System.Windows.Forms.CheckedListBox checkedListCourses;
        private System.Windows.Forms.Button btnRemoveCourse;
        private System.Windows.Forms.Button btnAddCourse;
        private System.Windows.Forms.Button btnGetAllStudents;
    }
}

