using SMS.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMS
{
    public partial class Student_Registry_Form : Form
    {
        List<Students> students = new List<Students>();
        public Student_Registry_Form()
        {
            InitializeComponent();
            comboCourses.Items.AddRange(ReturnCoursesArray());
            
        }
        private void BtnRegistration_Click(object sender, EventArgs e)
        {
            Students student = new Students();
            student.FirstName = textFirstName.Text;
            student.LastName = textLastName.Text;
            student.StudentId = textStudentId.Text;
            foreach (string checkedItem in checkedListCourses.CheckedItems)
            {
                student.Courses.Add(checkedItem);
            }
            studentGridView.Rows.Add(student);
            students.Add(student);
            textFirstName.Text = "";
            textLastName.Text = "";
            textStudentId.Text = "";
            comboCourses.SelectedValue.Equals("Select");
            checkedListCourses.Items.Clear();
        }

        private string[] ReturnCoursesArray()
        {
            string[] courses = new string[]
            {
                "Select",
                "Python-101",
                "Java-101",
                "NodeJS-101",
                "Web-200"
            };
            return courses;
        }

        private void CheckedListCourses_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if(checkedListCourses.CheckedItems.Count > 0)
            {
                btnRemoveCourse.Visible = true;
            }
            else
            {
                btnRemoveCourse.Visible = false;
            }

        }

        private void ComboCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(!comboCourses.SelectedValue.Equals("Select"))
            {
                btnAddCourse.Visible = true;
            }
        }

        private void BtnAddCourse_Click(object sender, EventArgs e)
        {
            checkedListCourses.SelectedItems.Add(comboCourses.SelectedValue);
            btnAddCourse.Visible = false;
            comboCourses.SelectedValue.Equals("Select");
        }

        private void BtnRemoveCourse_Click(object sender, EventArgs e)
        {
            checkedListCourses.SelectedItems.Clear();
        }

        private void TextStudentSearch_TextChanged(object sender, EventArgs e)
        {
            studentGridView.Rows.Clear();
            foreach (var student in students)
            {
                if (student.FirstName.Equals(textStudentSearch.Text) || student.LastName.Equals(textStudentSearch.Text) || student.StudentId.Equals(textStudentSearch.Text))
                {
                    studentGridView.Rows.Add(student);
                }
            }
        }

        private void BtnGetAllStudents_Click(object sender, EventArgs e)
        {
            studentGridView.Rows.Clear();
            foreach (var student in students)
            {
                studentGridView.Rows.Add(student);
            }
        }
    }
}
