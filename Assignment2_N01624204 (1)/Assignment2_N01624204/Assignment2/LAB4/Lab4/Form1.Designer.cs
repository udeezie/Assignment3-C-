namespace Lab4
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTestId = new System.Windows.Forms.TextBox();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.txtMaxScore = new System.Windows.Forms.TextBox();
            this.listBoxTestScores = new System.Windows.Forms.ListBox();
            this.AddTestScoreButton = new System.Windows.Forms.Button();
            this.updateTestScoreButton = new System.Windows.Forms.Button();
            this.InsertTestScoreButton = new System.Windows.Forms.Button();
            this.RemoveTestScoreButton = new System.Windows.Forms.Button();
            this.lblAverageScore = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Assignment_ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 116);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Score";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 168);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Max_Score";
            // 
            // txtTestId
            // 
            this.txtTestId.Location = new System.Drawing.Point(193, 53);
            this.txtTestId.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTestId.Name = "txtTestId";
            this.txtTestId.Size = new System.Drawing.Size(76, 20);
            this.txtTestId.TabIndex = 3;
            // 
            // txtScore
            // 
            this.txtScore.Location = new System.Drawing.Point(193, 116);
            this.txtScore.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(76, 20);
            this.txtScore.TabIndex = 4;
            // 
            // txtMaxScore
            // 
            this.txtMaxScore.Location = new System.Drawing.Point(193, 168);
            this.txtMaxScore.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMaxScore.Name = "txtMaxScore";
            this.txtMaxScore.Size = new System.Drawing.Size(76, 20);
            this.txtMaxScore.TabIndex = 5;
            // 
            // listBoxTestScores
            // 
            this.listBoxTestScores.FormattingEnabled = true;
            this.listBoxTestScores.Location = new System.Drawing.Point(411, 53);
            this.listBoxTestScores.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBoxTestScores.Name = "listBoxTestScores";
            this.listBoxTestScores.Size = new System.Drawing.Size(168, 147);
            this.listBoxTestScores.TabIndex = 6;
            // 
            // AddTestScoreButton
            // 
            this.AddTestScoreButton.Location = new System.Drawing.Point(67, 280);
            this.AddTestScoreButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddTestScoreButton.Name = "AddTestScoreButton";
            this.AddTestScoreButton.Size = new System.Drawing.Size(56, 19);
            this.AddTestScoreButton.TabIndex = 7;
            this.AddTestScoreButton.Text = "Add";
            this.AddTestScoreButton.UseVisualStyleBackColor = true;
            this.AddTestScoreButton.Click += new System.EventHandler(this.AddTestScoreButton_Click);
            // 
            // updateTestScoreButton
            // 
            this.updateTestScoreButton.Location = new System.Drawing.Point(182, 280);
            this.updateTestScoreButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.updateTestScoreButton.Name = "updateTestScoreButton";
            this.updateTestScoreButton.Size = new System.Drawing.Size(56, 19);
            this.updateTestScoreButton.TabIndex = 8;
            this.updateTestScoreButton.Text = "Update";
            this.updateTestScoreButton.UseVisualStyleBackColor = true;
            this.updateTestScoreButton.Click += new System.EventHandler(this.updateTestScoreButton_Click);
            // 
            // InsertTestScoreButton
            // 
            this.InsertTestScoreButton.Location = new System.Drawing.Point(322, 280);
            this.InsertTestScoreButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.InsertTestScoreButton.Name = "InsertTestScoreButton";
            this.InsertTestScoreButton.Size = new System.Drawing.Size(56, 19);
            this.InsertTestScoreButton.TabIndex = 9;
            this.InsertTestScoreButton.Text = "Insert";
            this.InsertTestScoreButton.UseVisualStyleBackColor = true;
            this.InsertTestScoreButton.Click += new System.EventHandler(this.InsertTestScoreButton_Click);
            // 
            // RemoveTestScoreButton
            // 
            this.RemoveTestScoreButton.Location = new System.Drawing.Point(485, 280);
            this.RemoveTestScoreButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RemoveTestScoreButton.Name = "RemoveTestScoreButton";
            this.RemoveTestScoreButton.Size = new System.Drawing.Size(56, 19);
            this.RemoveTestScoreButton.TabIndex = 10;
            this.RemoveTestScoreButton.Text = "Remove";
            this.RemoveTestScoreButton.UseVisualStyleBackColor = true;
            this.RemoveTestScoreButton.Click += new System.EventHandler(this.RemoveTestScoreButton_Click);
            // 
            // lblAverageScore
            // 
            this.lblAverageScore.AutoSize = true;
            this.lblAverageScore.Location = new System.Drawing.Point(452, 223);
            this.lblAverageScore.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAverageScore.Name = "lblAverageScore";
            this.lblAverageScore.Size = new System.Drawing.Size(86, 15);
            this.lblAverageScore.TabIndex = 11;
            this.lblAverageScore.Text = "Average Score";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(303, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Home";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblAverageScore);
            this.Controls.Add(this.RemoveTestScoreButton);
            this.Controls.Add(this.InsertTestScoreButton);
            this.Controls.Add(this.updateTestScoreButton);
            this.Controls.Add(this.AddTestScoreButton);
            this.Controls.Add(this.listBoxTestScores);
            this.Controls.Add(this.txtMaxScore);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.txtTestId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTestId;
        private System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.TextBox txtMaxScore;
        private System.Windows.Forms.ListBox listBoxTestScores;
        private System.Windows.Forms.Button AddTestScoreButton;
        private System.Windows.Forms.Button updateTestScoreButton;
        private System.Windows.Forms.Button InsertTestScoreButton;
        private System.Windows.Forms.Button RemoveTestScoreButton;
        private System.Windows.Forms.Label lblAverageScore;
        private System.Windows.Forms.Button button1;
    }
}