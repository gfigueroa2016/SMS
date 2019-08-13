using SMS.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
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
            student.Courses = new List<string>();
            foreach (string checkedItem in checkedListCourses.Items)
            {
                student.Courses.Add(checkedItem.ToString());
            }
            DataGridViewRow row = (DataGridViewRow)studentGridView.Rows[0].Clone();
            row.Cells[0].Value = student.StudentId;
            row.Cells[1].Value = student.FirstName + " " + student.LastName;
            string courses = student.Courses.ToString();
            row.Cells[2].Value = courses;
            studentGridView.Rows.Add(row);
            students.Add(student);
            textFirstName.Text = "";
            textLastName.Text = "";
            textStudentId.Text = "";
            comboCourses.SelectedItem = "Select";
            checkedListCourses.Items.Clear();
            Log_Process(sender);
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

        private void ComboCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboCourses.SelectedItem.ToString() != "Select")
            {
                btnAddCourse.Visible = true;
            }
            else
            {
                comboCourses.SelectedItem = "Select";
                btnAddCourse.Visible = false;
            }
            Log_Process(sender);
        }

        private void BtnAddCourse_Click(object sender, EventArgs e)
        {
            checkedListCourses.Items.Add(comboCourses.SelectedItem.ToString());
            checkedListCourses.CheckedItems.Equals(comboCourses.SelectedItem.ToString());
            btnAddCourse.Visible = false;
            comboCourses.Items.Remove(comboCourses.SelectedItem.ToString());
            comboCourses.SelectedItem = "Select";
            Log_Process(sender);
        }

        private void BtnRemoveCourse_Click(object sender, EventArgs e)
        {
            List<object> itemsToRemove = new List<object>();
            foreach (var checkedCourse in checkedListCourses.CheckedItems)
            {
                comboCourses.Items.Add(checkedCourse);
                itemsToRemove.Add(checkedCourse);
            }
            foreach(var itemToRemove in itemsToRemove)
            {
                checkedListCourses.Items.Remove(itemToRemove);
            }
            Log_Process(sender);
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
            Log_Process(sender);
        }

        private void BtnGetAllStudents_Click(object sender, EventArgs e)
        {
            studentGridView.Rows.Clear();
            foreach (var student in students)
            {
                DataGridViewRow row = (DataGridViewRow)studentGridView.Rows[0].Clone();
                row.Cells[0].Value = student.StudentId;
                row.Cells[1].Value = student.FirstName + " " + student.LastName;
                string courses = student.Courses.ToString();
                row.Cells[2].Value = courses;
                studentGridView.Rows.Add(row);
            }
            Log_Process(sender);
        }
        private void Log_Process(object sender)
        {
            string path = ConfigurationManager.AppSettings["path"];
            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine(sender);
                }
            }
            else
            {
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine(sender);
                }
            }
        }

        private void CheckedListCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checkedListCourses.CheckedItems.Count > 0)
            {
                btnRemoveCourse.Visible = true;
            }
            else
            {
                btnRemoveCourse.Visible = false;
            }
            Log_Process(sender);
        }
    }
}
