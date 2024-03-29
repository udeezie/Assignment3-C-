using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Loginform : Form
    {
       
        private const string userFilePath = @"C:\Users\vorti\Videos\Assignment2_N01624204 (1)\Assignment2_N01624204 (1)\Assignment2_N01624204\Assignment2\LAB4\Lab4\user.txt";

        private const string studentFilePath = "students.txt";
        private Dictionary<string, string> users = new Dictionary<string, string>();

        public Loginform()
        {
            InitializeComponent();
            LoadUsers();
        }

        private void LoadUsers()
        {
            if (File.Exists(userFilePath))
            {
                string[] lines = File.ReadAllLines(userFilePath);
                foreach (string line in lines)
                {
                    string[] parts = line.Split('|');
                    if (parts.Length == 2)
                    {
                        string username = parts[0];
                        string password = parts[1];
                        users[username] = password;
                    }
                }
            }
            else
            {
                // Create default admin user if user.txt does not exist
                users["ADMIN"] = "Password";
                File.WriteAllLines(userFilePath, new string[] { "ADMIN|Password" });
            }
        }

        private bool Authenticate(string username, string password)
        {
            if (users.ContainsKey(username))
            {
                return users[username] == password;
            }
            return false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            if (Authenticate(username, password))
            {
                MessageBox.Show("Login successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                OpenStudentManagementForm();
            }
            else
            {
                MessageBox.Show("Invalid username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OpenStudentManagementForm()
        {
            StudentManagement studentManagementForm = new StudentManagement();
            studentManagementForm.Show();
            this.Hide(); // Hide the login form
        }


        private void btnReset_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
        }

        public void RegisterUser(string username, string password)
        {
            try
            {
                // Encrypt the password (you can use any encryption method here)
                string encryptedPassword = EncryptPassword(password);

                // Add the new user to the dictionary
                users[username] = encryptedPassword;

                // Update the user.txt file
                using (StreamWriter writer = File.AppendText(userFilePath))
                {
                    writer.WriteLine($"{username}|{encryptedPassword}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error registering user: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }





        private string EncryptPassword(string password)
        {

            return Convert.ToBase64String(Encoding.UTF8.GetBytes(password));
        }


        public bool UserExists(string username)
        {
            return users.ContainsKey(username);
        }

        private void btnRegisterform(object sender, EventArgs e)
        {
            Register registerForm = new Register(this);
            registerForm.Show();
            this.Hide();
        }
    }
}

