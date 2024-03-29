using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class AddNew : Form
    {
        bool isExist = false;
        private Main frm;
        private List<string> students;

        public AddNew(Main main, List<string> students)
        {
            InitializeComponent();
            this.frm = main;
            this.students = students;
        }

        private void add_Click(object sender, EventArgs e)
        {
            string name = _name.Text.Trim();
            string score1 = _score1.Text.Trim();
            string score2 = _score2.Text.Trim();
            string score3 = _score3.Text.Trim();
            if (name == "" || score1 == "" || score2 == "" || score3 == "")
            {
                MessageBox.Show("Please fill all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            } else if (Convert.ToInt32(score1) < 0 || Convert.ToInt32(score1) > 100
                || Convert.ToInt32(score2) < 0 || Convert.ToInt32(score2) > 100
                || Convert.ToInt32(score3) < 0 || Convert.ToInt32(score3) > 100)
            {
                MessageBox.Show("Please enter a valid score", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            } else
            {
                foreach (string s in frm.students)
                {
                    string[] student = s.Split('|');
                    if (student[0] == name)
                    {
                        isExist = true;
                        MessageBox.Show("Student already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close();
                        frm.Show();
                        return;
                    }
                }

                if (isExist == false)
                {
                    string new_student = name + "|" + score1 + "|" + score2 + "|" + score3;
                    frm.students.Add(new_student);
                    frm.LoadStudentListBox();
                    MessageBox.Show("Student Added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    frm.Show();
                }
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {

            this.Close();
            frm.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
