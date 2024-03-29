namespace Lab4
{
    partial class Main
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
            this.listBox = new System.Windows.Forms.ListBox();
            this.Operations = new System.Windows.Forms.GroupBox();
            this.exit = new System.Windows.Forms.RadioButton();
            this.delete = new System.Windows.Forms.RadioButton();
            this.update = new System.Windows.Forms.RadioButton();
            this.addnew = new System.Windows.Forms.RadioButton();
            this.score = new System.Windows.Forms.TextBox();
            this.average = new System.Windows.Forms.TextBox();
            this.scoreCount = new System.Windows.Forms.TextBox();
            this.performbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exit_strip = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.add_strip = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.remove_strip = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAssignmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Operations.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 16;
            this.listBox.Location = new System.Drawing.Point(41, 67);
            this.listBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(421, 132);
            this.listBox.TabIndex = 0;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // Operations
            // 
            this.Operations.Controls.Add(this.exit);
            this.Operations.Controls.Add(this.delete);
            this.Operations.Controls.Add(this.update);
            this.Operations.Controls.Add(this.addnew);
            this.Operations.Location = new System.Drawing.Point(515, 58);
            this.Operations.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Operations.Name = "Operations";
            this.Operations.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Operations.Size = new System.Drawing.Size(185, 206);
            this.Operations.TabIndex = 1;
            this.Operations.TabStop = false;
            this.Operations.Text = "Operations";
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(13, 153);
            this.exit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(65, 29);
            this.exit.TabIndex = 9;
            this.exit.TabStop = true;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            // 
            // delete
            // 
            this.delete.AutoSize = true;
            this.delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.Location = new System.Drawing.Point(13, 113);
            this.delete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(89, 29);
            this.delete.TabIndex = 8;
            this.delete.TabStop = true;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            // 
            // update
            // 
            this.update.AutoSize = true;
            this.update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.Location = new System.Drawing.Point(13, 74);
            this.update.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(96, 29);
            this.update.TabIndex = 7;
            this.update.TabStop = true;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = true;
            // 
            // addnew
            // 
            this.addnew.AutoSize = true;
            this.addnew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addnew.Location = new System.Drawing.Point(13, 33);
            this.addnew.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addnew.Name = "addnew";
            this.addnew.Size = new System.Drawing.Size(113, 29);
            this.addnew.TabIndex = 6;
            this.addnew.TabStop = true;
            this.addnew.Text = "Add New";
            this.addnew.UseVisualStyleBackColor = true;
            // 
            // score
            // 
            this.score.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.score.Location = new System.Drawing.Point(368, 207);
            this.score.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.score.Multiline = true;
            this.score.Name = "score";
            this.score.ReadOnly = true;
            this.score.Size = new System.Drawing.Size(93, 31);
            this.score.TabIndex = 2;
            // 
            // average
            // 
            this.average.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.average.Location = new System.Drawing.Point(368, 287);
            this.average.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.average.Multiline = true;
            this.average.Name = "average";
            this.average.ReadOnly = true;
            this.average.Size = new System.Drawing.Size(93, 31);
            this.average.TabIndex = 3;
            // 
            // scoreCount
            // 
            this.scoreCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.scoreCount.Location = new System.Drawing.Point(368, 248);
            this.scoreCount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.scoreCount.Multiline = true;
            this.scoreCount.Name = "scoreCount";
            this.scoreCount.ReadOnly = true;
            this.scoreCount.Size = new System.Drawing.Size(93, 31);
            this.scoreCount.TabIndex = 4;
            // 
            // performbtn
            // 
            this.performbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.performbtn.Location = new System.Drawing.Point(515, 287);
            this.performbtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.performbtn.Name = "performbtn";
            this.performbtn.Size = new System.Drawing.Size(123, 44);
            this.performbtn.TabIndex = 5;
            this.performbtn.Text = "Perform";
            this.performbtn.UseVisualStyleBackColor = true;
            this.performbtn.Click += new System.EventHandler(this.performbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(235, 211);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Score Total";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(226, 254);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Score Count";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(263, 294);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Average";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(44, 49);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Students";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.viewAssignmentToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(778, 26);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exit_strip});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exit_strip
            // 
            this.exit_strip.Name = "exit_strip";
            this.exit_strip.Size = new System.Drawing.Size(116, 26);
            this.exit_strip.Text = "Exit";
            this.exit_strip.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.add_strip,
            this.removeToolStripMenuItem,
            this.remove_strip});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.optionsToolStripMenuItem.Text = "options";
            // 
            // add_strip
            // 
            this.add_strip.Name = "add_strip";
            this.add_strip.Size = new System.Drawing.Size(146, 26);
            this.add_strip.Text = "Add";
            this.add_strip.Click += new System.EventHandler(this.add_strip_Click);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(146, 26);
            this.removeToolStripMenuItem.Text = "Update";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.update_strip_Click);
            // 
            // remove_strip
            // 
            this.remove_strip.Name = "remove_strip";
            this.remove_strip.Size = new System.Drawing.Size(146, 26);
            this.remove_strip.Text = "Remove";
            this.remove_strip.Click += new System.EventHandler(this.delete_strip_Click);
            // 
            // viewAssignmentToolStripMenuItem
            // 
            this.viewAssignmentToolStripMenuItem.Name = "viewAssignmentToolStripMenuItem";
            this.viewAssignmentToolStripMenuItem.Size = new System.Drawing.Size(136, 24);
            this.viewAssignmentToolStripMenuItem.Text = "View Assignment";
            this.viewAssignmentToolStripMenuItem.Click += new System.EventHandler(this.viewAssignmentToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 442);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.performbtn);
            this.Controls.Add(this.scoreCount);
            this.Controls.Add(this.average);
            this.Controls.Add(this.score);
            this.Controls.Add(this.Operations);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Operations.ResumeLayout(false);
            this.Operations.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.GroupBox Operations;
        private System.Windows.Forms.TextBox score;
        private System.Windows.Forms.TextBox average;
        private System.Windows.Forms.TextBox scoreCount;
        private System.Windows.Forms.RadioButton addnew;
        private System.Windows.Forms.Button performbtn;
        private System.Windows.Forms.RadioButton exit;
        private System.Windows.Forms.RadioButton delete;
        private System.Windows.Forms.RadioButton update;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exit_strip;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem add_strip;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem remove_strip;
        private System.Windows.Forms.ToolStripMenuItem viewAssignmentToolStripMenuItem;
    }
}

