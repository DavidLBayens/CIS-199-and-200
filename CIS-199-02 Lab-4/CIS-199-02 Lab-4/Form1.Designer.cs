
namespace CIS_199_02_Lab_4
{
    partial class Lab4
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
            this.GPAinput = new System.Windows.Forms.TextBox();
            this.ATSinput = new System.Windows.Forms.TextBox();
            this.Title = new System.Windows.Forms.Label();
            this.TestButton = new System.Windows.Forms.Button();
            this.Accepted = new System.Windows.Forms.Label();
            this.HSGPA = new System.Windows.Forms.Label();
            this.ATS = new System.Windows.Forms.Label();
            this.Rejected = new System.Windows.Forms.Label();
            this.AcceptedLabel = new System.Windows.Forms.Label();
            this.RejectedLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GPAinput
            // 
            this.GPAinput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.GPAinput.Location = new System.Drawing.Point(174, 62);
            this.GPAinput.Name = "GPAinput";
            this.GPAinput.Size = new System.Drawing.Size(100, 20);
            this.GPAinput.TabIndex = 0;
            // 
            // ATSinput
            // 
            this.ATSinput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ATSinput.Location = new System.Drawing.Point(174, 117);
            this.ATSinput.Name = "ATSinput";
            this.ATSinput.Size = new System.Drawing.Size(100, 20);
            this.ATSinput.TabIndex = 1;
            // 
            // Title
            // 
            this.Title.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(12, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(293, 18);
            this.Title.TabIndex = 2;
            this.Title.Text = "Hypothetical University Admissions\r\n\r\n";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TestButton
            // 
            this.TestButton.Location = new System.Drawing.Point(101, 179);
            this.TestButton.Name = "TestButton";
            this.TestButton.Size = new System.Drawing.Size(120, 23);
            this.TestButton.TabIndex = 3;
            this.TestButton.Text = "Submit Credentials\r\n";
            this.TestButton.UseVisualStyleBackColor = true;
            this.TestButton.Click += new System.EventHandler(this.TestButton_Click);
            // 
            // Accepted
            // 
            this.Accepted.BackColor = System.Drawing.Color.Lime;
            this.Accepted.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Accepted.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Accepted.Location = new System.Drawing.Point(191, 253);
            this.Accepted.Name = "Accepted";
            this.Accepted.Size = new System.Drawing.Size(100, 23);
            this.Accepted.TabIndex = 4;
            this.Accepted.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HSGPA
            // 
            this.HSGPA.AutoSize = true;
            this.HSGPA.Location = new System.Drawing.Point(33, 65);
            this.HSGPA.Name = "HSGPA";
            this.HSGPA.Size = new System.Drawing.Size(88, 13);
            this.HSGPA.TabIndex = 6;
            this.HSGPA.Text = "Highschool GPA:";
            // 
            // ATS
            // 
            this.ATS.AutoSize = true;
            this.ATS.Location = new System.Drawing.Point(33, 120);
            this.ATS.Name = "ATS";
            this.ATS.Size = new System.Drawing.Size(112, 13);
            this.ATS.TabIndex = 7;
            this.ATS.Text = "Admission Test Score:\r\n";
            // 
            // Rejected
            // 
            this.Rejected.BackColor = System.Drawing.Color.Red;
            this.Rejected.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Rejected.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rejected.Location = new System.Drawing.Point(191, 286);
            this.Rejected.Name = "Rejected";
            this.Rejected.Size = new System.Drawing.Size(100, 23);
            this.Rejected.TabIndex = 8;
            this.Rejected.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AcceptedLabel
            // 
            this.AcceptedLabel.AutoSize = true;
            this.AcceptedLabel.Location = new System.Drawing.Point(52, 254);
            this.AcceptedLabel.Name = "AcceptedLabel";
            this.AcceptedLabel.Size = new System.Drawing.Size(96, 13);
            this.AcceptedLabel.TabIndex = 9;
            this.AcceptedLabel.Text = "Number Accepted:\r\n";
            // 
            // RejectedLabel
            // 
            this.RejectedLabel.AutoSize = true;
            this.RejectedLabel.Location = new System.Drawing.Point(52, 287);
            this.RejectedLabel.Name = "RejectedLabel";
            this.RejectedLabel.Size = new System.Drawing.Size(93, 13);
            this.RejectedLabel.TabIndex = 10;
            this.RejectedLabel.Text = "Number Rejected:";
            // 
            // Lab4
            // 
            this.AcceptButton = this.TestButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 332);
            this.Controls.Add(this.RejectedLabel);
            this.Controls.Add(this.AcceptedLabel);
            this.Controls.Add(this.Rejected);
            this.Controls.Add(this.ATS);
            this.Controls.Add(this.HSGPA);
            this.Controls.Add(this.Accepted);
            this.Controls.Add(this.TestButton);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.ATSinput);
            this.Controls.Add(this.GPAinput);
            this.Name = "Lab4";
            this.Text = "Lab 4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox GPAinput;
        private System.Windows.Forms.TextBox ATSinput;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button TestButton;
        private System.Windows.Forms.Label Accepted;
        private System.Windows.Forms.Label HSGPA;
        private System.Windows.Forms.Label ATS;
        private System.Windows.Forms.Label Rejected;
        private System.Windows.Forms.Label AcceptedLabel;
        private System.Windows.Forms.Label RejectedLabel;
    }
}

