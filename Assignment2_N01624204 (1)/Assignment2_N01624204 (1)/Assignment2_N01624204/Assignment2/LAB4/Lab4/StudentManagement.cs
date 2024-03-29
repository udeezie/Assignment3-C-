using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class StudentManagement : Form
    {
        private const string studentFilePath = @"C:\Users\vorti\Videos\Assignment2_N01624204 (1)\Assignment2_N01624204 (1)\Assignment2_N01624204\Assignment2\LAB4\Lab4\user.txt";

        private List<Studentsystem> students = new List<Studentsystem>();

        public StudentManagement()
        {
            InitializeComponent();
            InitializeDataGridView();
            LoadStudents();
        }

        private void InitializeDataGridView()
        {
            // Add columns to the DataGridView
            dataGridView1.Columns.Add("StudentID", "Student ID");
            dataGridView1.Columns.Add("FirstName", "First Name");
            dataGridView1.Columns.Add("LastName", "Last Name");
            dataGridView1.Columns.Add("Age", "Age");
            dataGridView1.Columns.Add("Gender", "Gender");
            dataGridView1.Columns.Add("ClassName", "Class Name");
            dataGridView1.Columns.Add("Grade", "Grade");

            // Set DataGridView properties
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.MultiSelect = false;
        }

        private void LoadStudents()
        {
            if (File.Exists(studentFilePath))
            {
                string[] lines = File.ReadAllLines(studentFilePath);
                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length == 7)
                    {
                        Studentsystem student = new Studentsystem
                        {
                            StudentID = parts[0],
                            FirstName = parts[1],
                            LastName = parts[2],
                            Age = Convert.ToInt32(parts[3]),
                            Gender = parts[4],
                            ClassName = parts[5],
                            Grade = Convert.ToDouble(parts[6])
                        };
                        students.Add(student);
                    }
                }
                DisplayStudents();
            }
        }

        private void DisplayStudents()
        {
            dataGridView1.Rows.Clear();
            foreach (var student in students)
            {
                dataGridView1.Rows.Add(student.StudentID, student.FirstName, student.LastName,
                                        student.Age, student.Gender, student.ClassName, student.Grade);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked cell is in a valid row (not a header row)
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                // Populate the textboxes with the selected student's information
                txtStudentID.Text = selectedRow.Cells["StudentID"].Value.ToString();
                txtFirstName.Text = selectedRow.Cells["FirstName"].Value.ToString();
                txtLastName.Text = selectedRow.Cells["LastName"].Value.ToString();
                txtAge.Text = selectedRow.Cells["Age"].Value.ToString();
                txtGender.Text = selectedRow.Cells["Gender"].Value.ToString();
                txtClassName.Text = selectedRow.Cells["ClassName"].Value.ToString();
                txtGrade.Text = selectedRow.Cells["Grade"].Value.ToString();
            }
        }


        private void btnClear_click(object sender, EventArgs e)
        {
            // Clear all textboxes
            ClearTextBoxes();
        }

        private void btnDelete_click(object sender, EventArgs e)
        {
            // Check if a row is selected
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a student to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Get the index of the selected row
            int selectedIndex = dataGridView1.SelectedRows[0].Index;

            // Remove the corresponding student object from the list
            students.RemoveAt(selectedIndex);

            // Remove the selected row from the DataGridView
            dataGridView1.Rows.RemoveAt(selectedIndex);

            // Save the updated list of students to the file
            SaveStudentsToFile();

            MessageBox.Show("Student record deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void btnEdit_click(object sender, EventArgs e)
        {
            // Check if a row is selected
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a student to edit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Get the index of the selected row
            int selectedIndex = dataGridView1.SelectedRows[0].Index;

            // Retrieve the data of the selected student from the textboxes
            string studentID = txtStudentID.Text;
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            int age;
            if (!int.TryParse(txtAge.Text, out age))
            {
                MessageBox.Show("Please enter a valid age.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string gender = txtGender.Text;
            string className = txtClassName.Text;
            double grade;
            if (!double.TryParse(txtGrade.Text, out grade))
            {
                MessageBox.Show("Please enter a valid grade.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Update the student object in the list
            students[selectedIndex].StudentID = studentID;
            students[selectedIndex].FirstName = firstName;
            students[selectedIndex].LastName = lastName;
            students[selectedIndex].Age = age;
            students[selectedIndex].Gender = gender;
            students[selectedIndex].ClassName = className;
            students[selectedIndex].Grade = grade;

            // Update DataGridView to reflect the changes
            dataGridView1.Rows[selectedIndex].SetValues(studentID, firstName, lastName, age, gender, className, grade);

            // Save the updated list of students to the file
            SaveStudentsToFile();

            // Clear textboxes
            ClearTextBoxes();

            MessageBox.Show("Student details updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void btnAdd_click(object sender, EventArgs e)
        {
            // Retrieve input data from textboxes
            string studentID = txtStudentID.Text;
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            int age;
            if (!int.TryParse(txtAge.Text, out age))
            {
                MessageBox.Show("Please enter a valid age.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string gender = txtGender.Text;
            string className = txtClassName.Text;
            double grade;
            if (!double.TryParse(txtGrade.Text, out grade))
            {
                MessageBox.Show("Please enter a valid grade.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate input data
            if (!ValidateInputData(studentID, firstName, lastName, age, gender, className, grade))
            {
                return;
            }

            // Create a new student object
            Studentsystem newStudent = new Studentsystem(studentID, firstName, lastName, age, gender, className, grade);

            // Add the new student to the list
            students.Add(newStudent);

            // Update DataGridView to reflect the changes
            dataGridView1.Rows.Add(newStudent.StudentID, newStudent.FirstName, newStudent.LastName,
                                    newStudent.Age, newStudent.Gender, newStudent.ClassName, newStudent.Grade);

            // Save the updated list of students to the file
            SaveStudentsToFile();

            // Clear textboxes
            ClearTextBoxes();
        }

        private bool ValidateInputData(string studentID, string firstName, string lastName, int age, string gender, string className, double grade)
        {
            // Check if any of the required fields are empty
            if (string.IsNullOrEmpty(studentID) || string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(gender) || string.IsNullOrEmpty(className))
            {
                MessageBox.Show("Please fill in all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Validate age
            if (age <= 0 || age > 120)
            {
                MessageBox.Show("Please enter a valid age.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Validate grade
            if (grade < 0 || grade > 100)
            {
                MessageBox.Show("Please enter a valid grade (0-100).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            

            // If all validation passes, return true
            return true;
        }

        private void SaveStudentsToFile()
        {
            try
            {
                // Create a list of strings to hold student records
                List<string> studentRecords = new List<string>();

                // Convert each student object to a string and add it to the list
                foreach (var student in students)
                {
                    string studentRecord = $"{student.StudentID},{student.FirstName},{student.LastName},{student.Age},{student.Gender},{student.ClassName},{student.Grade}";
                    studentRecords.Add(studentRecord);
                }

                // Write the list of student records to the file
                File.WriteAllLines(studentFilePath, studentRecords);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving student data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void ClearTextBoxes()
        {
            // Clear all textboxes
            txtStudentID.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtAge.Text = "";
            txtGender.Text = "";
            txtClassName.Text = "";
            txtGrade.Text = "";
        }

        private void btnAddScore_click(object sender, EventArgs e)
        {
            // Close the current form
            this.Close();

            // Show the main form
            Main mainForm = new Main(studentFilePath);
            mainForm.Show();
        }

    }
}
