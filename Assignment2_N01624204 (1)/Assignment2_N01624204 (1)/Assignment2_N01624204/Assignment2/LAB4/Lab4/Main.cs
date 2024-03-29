using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Main : Form
    {
        public List<string> students = new List<string>();
        private string studentFilePath;

        public Main(string studentFilePath)
        {
            InitializeComponent();
            this.studentFilePath = studentFilePath; 
            AcceptButton = performbtn;
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            
            students.Add("Uriel|90|87|89");
            students.Add("Vortia|95|92|94");
            students.Add("Kweku|80|77|79");
            students.Add("Senam|85|82|84");
            LoadStudentListBox();


        }




        public void LoadStudentListBox(int selectedIndex = -1)
        {
            listBox.Items.Clear();
            listBox.Items.AddRange(students.ToArray());

            if (listBox.Items.Count > 0 && selectedIndex >= 0 && selectedIndex < listBox.Items.Count)
            {
                listBox.SelectedIndex = selectedIndex;
            }
            else
            {
                clear();
            }
        }

        public void clear()
        {
            score.Text = "";
            scoreCount.Text = "";
            average.Text = "";
        }

        public void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox.SelectedItem == null) return;

            string[] studentDetails = listBox.SelectedItem.ToString().Split('|');
            if (studentDetails.Length <= 1) return; 

            int sum = studentDetails.Skip(1).Sum(s => Convert.ToInt32(s));
            int count = studentDetails.Length - 1; 

            score.Text = sum.ToString();
            scoreCount.Text = count.ToString();
            average.Text = (sum / count).ToString();
        }

        private void performbtn_Click(object sender, EventArgs e)
        {
            if (addnew.Checked)
            {
                var frm = new AddNew(this, students);
                frm.Show();
                this.Hide();
            }
            else if (update.Checked)
            {
                if (listBox.SelectedIndex != -1)
                {
                    var updateFrm = new Update(this, listBox.SelectedIndex);
                    updateFrm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Please select a student to update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (delete.Checked)
            {
                if (listBox.SelectedIndex != -1)
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to delete this student?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        students.RemoveAt(listBox.SelectedIndex);
                        LoadStudentListBox();
                        MessageBox.Show("Successfully Deleted", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Please select a student to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (exit.Checked)
            {
                this.Close();
            }
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void add_strip_Click(object sender, EventArgs e)
        {
            addnew.Checked = true;
            performbtn_Click(sender, e);
        }

        private void update_strip_Click(object sender, EventArgs e)
        {
            update.Checked = true;
            performbtn_Click(sender, e);
        }

        private void delete_strip_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a student to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                delete.Checked = true;
                performbtn_Click(sender, e);
            }
            
        }

        private void viewAssignmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 myform = new Form1();
            myform.Show();
            this.Hide();

        }
    }
}
