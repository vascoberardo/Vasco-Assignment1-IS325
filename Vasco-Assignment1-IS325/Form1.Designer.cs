namespace Vasco_Assignment1_IS325
{
    partial class Assignment1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblFirstName = new Label();
            lblLastName = new Label();
            lblHoursWorked = new Label();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtHoursWorked = new TextBox();
            btnSummarize = new Button();
            btnClear = new Button();
            lblOutput = new Label();
            SuspendLayout();
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(161, 77);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(64, 15);
            lblFirstName.TabIndex = 0;
            lblFirstName.Text = "&First Name";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(380, 77);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(63, 15);
            lblLastName.TabIndex = 1;
            lblLastName.Text = "&Last Name";
            // 
            // lblHoursWorked
            // 
            lblHoursWorked.AutoSize = true;
            lblHoursWorked.Location = new Point(611, 77);
            lblHoursWorked.Name = "lblHoursWorked";
            lblHoursWorked.Size = new Size(83, 15);
            lblHoursWorked.TabIndex = 2;
            lblHoursWorked.Text = "&Hours Worked";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(158, 112);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(100, 23);
            txtFirstName.TabIndex = 3;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(350, 112);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(100, 23);
            txtLastName.TabIndex = 4;
            // 
            // txtHoursWorked
            // 
            txtHoursWorked.Location = new Point(583, 112);
            txtHoursWorked.Name = "txtHoursWorked";
            txtHoursWorked.Size = new Size(100, 23);
            txtHoursWorked.TabIndex = 5;
            // 
            // btnSummarize
            // 
            btnSummarize.Location = new Point(182, 257);
            btnSummarize.Name = "btnSummarize";
            btnSummarize.Size = new Size(75, 23);
            btnSummarize.TabIndex = 6;
            btnSummarize.Text = "&Summarize";
            btnSummarize.UseVisualStyleBackColor = true;
            btnSummarize.Click += summarizeButton_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(281, 257);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 7;
            btnClear.Text = "&Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // lblOutput
            // 
            lblOutput.AutoSize = true;
            lblOutput.BorderStyle = BorderStyle.FixedSingle;
            lblOutput.ForeColor = SystemColors.InfoText;
            lblOutput.Location = new Point(230, 337);
            lblOutput.Name = "lblOutput";
            lblOutput.Padding = new Padding(150, 20, 150, 20);
            lblOutput.Size = new Size(302, 57);
            lblOutput.TabIndex = 8;
            lblOutput.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Assignment1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblOutput);
            Controls.Add(btnClear);
            Controls.Add(btnSummarize);
            Controls.Add(txtHoursWorked);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(lblHoursWorked);
            Controls.Add(lblLastName);
            Controls.Add(lblFirstName);
            Name = "Assignment1";
            Text = "Assignment1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFirstName;
        private Label lblLastName;
        private Label lblHoursWorked;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtHoursWorked;
        private Button btnSummarize;
        private Button btnClear;
        private Label lblOutput;
    }
}
