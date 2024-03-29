using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Update : Form
    {
        Main frm;
        int selectedIndex = 0;

        public Update(Main mainForm, int selectedIndex)
        {
            InitializeComponent();
            this.frm = mainForm;
            this.selectedIndex = selectedIndex;
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            string name = _name.Text;
            string score1 = _score1.Text;
            string score2 = _score2.Text;
            string score3 = _score3.Text;

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(score1) || string.IsNullOrEmpty(score2) || string.IsNullOrEmpty(score3))
            {
                MessageBox.Show("Please fill all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!ValidateScores(score1, score2, score3))
            {
                MessageBox.Show("Scores must be numeric and between 0 and 100.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string student = $"{name}|{score1}|{score2}|{score3}";
            frm.students[selectedIndex] = student;
            frm.LoadStudentListBox();
            this.Close();
            frm.Show();
            MessageBox.Show("Student Updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private bool ValidateScores(params string[] scores)
        {
            foreach (var score in scores)
            {
                if (!int.TryParse(score, out int result) || result < 0 || result > 100)
                {
                    return false;
                }
            }
            return true;
        }

        private void Update_Load(object sender, EventArgs e)
        {
            MessageBox.Show($"Index: {selectedIndex} Student Details: {frm.students.ElementAt(selectedIndex)}");

            string[] student = frm.students[selectedIndex].Split('|');
            _name.Text = student[0];
            _score1.Text = student[1];
            _score2.Text = student[2];
            _score3.Text = student[3];
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            frm.Show();
        }
    }
}
