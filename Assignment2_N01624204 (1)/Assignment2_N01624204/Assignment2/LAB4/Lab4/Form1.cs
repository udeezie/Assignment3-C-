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
    public partial class Form1 : Form
    {
        private List<TestScore> testScores = new List<TestScore>();
        public Form1()
        {
            InitializeComponent();
        }

        private void AddTestScoreButton_Click(object sender, EventArgs e)
        {
            // Input validation
            if (!int.TryParse(txtTestId.Text, out int testId) || !int.TryParse(txtScore.Text, out int score) || !int.TryParse(txtMaxScore.Text, out int maxScore))
            {
                MessageBox.Show("Please enter valid numeric values for Test ID, Score, and Max Score.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if test ID already exists
            if (testScores.Any(ts => ts.TestId == testId))
            {
                MessageBox.Show("Test ID already exists. Use the update or insert operation.", "Duplicate Test ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Add the test score to the list
            testScores.Add(new TestScore { TestId = testId, Score = score, MaxScore = maxScore });

            // Update the display
            DisplayTestScores();
        }

        private void updateTestScoreButton_Click(object sender, EventArgs e)
        {
            // Input validation
            if (!int.TryParse(txtTestId.Text, out int testId) || !int.TryParse(txtScore.Text, out int score) || !int.TryParse(txtMaxScore.Text, out int maxScore))
            {
                MessageBox.Show("Please enter valid numeric values for Test ID, Score, and Max Score.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Find the test score by ID
            var testScoreToUpdate = testScores.Find(ts => ts.TestId == testId);

            if (testScoreToUpdate != null)
            {
                // Update the test score
                testScoreToUpdate.Score = score;
                testScoreToUpdate.MaxScore = maxScore;

                // Update the display
                DisplayTestScores();
            }
            else
            {
                MessageBox.Show("Test ID not found. Use the add operation to add a new test.", "Test Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void InsertTestScoreButton_Click(object sender, EventArgs e)
        {
            // Input validation
            if (!int.TryParse(txtTestId.Text, out int testId) || !int.TryParse(txtScore.Text, out int score) || !int.TryParse(txtMaxScore.Text, out int maxScore))
            {
                MessageBox.Show("Please enter valid numeric values for Test ID, Score, and Max Score.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if test ID already exists
            if (testScores.Any(ts => ts.TestId == testId))
            {
                MessageBox.Show("Test ID already exists. Use the update or insert operation.", "Duplicate Test ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Insert the test score to maintain the sequence of test IDs
            testScores.Add(new TestScore { TestId = testId, Score = score, MaxScore = maxScore });
            testScores.Sort((ts1, ts2) => ts1.TestId.CompareTo(ts2.TestId));

            // Update the display
            DisplayTestScores();
        }

        private void RemoveTestScoreButton_Click(object sender, EventArgs e)
        {
            // Input validation
            if (!int.TryParse(txtTestId.Text, out int testId))
            {
                MessageBox.Show("Please enter a valid numeric value for Test ID.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Find and remove the test score by ID
            var testScoreToRemove = testScores.Find(ts => ts.TestId == testId);

            if (testScoreToRemove != null)
            {
                testScores.Remove(testScoreToRemove);

                // Update the display
                DisplayTestScores();
            }
            else
            {
                MessageBox.Show("Test ID not found. No test removed.", "Test Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DisplayTestScores()
        {
            // Display all tests along with the average score
            listBoxTestScores.Items.Clear();

            foreach (var testScore in testScores)
            {
                listBoxTestScores.Items.Add($"Test ID: {testScore.TestId}, Score: {testScore.Score}/{testScore.MaxScore}");
            }

            // Display the average score
            if (testScores.Count > 0)
            {
                decimal averageScore = testScores.Average(ts => (decimal)ts.Score / ts.MaxScore) * 100;
                lblAverageScore.Text = $"Average Score: {averageScore:F2}%";
            }
            else
            {
                lblAverageScore.Text = "Average Score: N/A";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main home = new Main();
            home.Show();
            this.Hide();   
        }
    }



    // Class to represent a test score
    public class TestScore
    {
        public int TestId { get; set; }
        public int Score { get; set; }
        public int MaxScore { get; set; }
    }
}
