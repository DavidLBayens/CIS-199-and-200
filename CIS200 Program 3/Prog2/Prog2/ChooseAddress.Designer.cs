
namespace UPVApp
{
    partial class ChooseAddressForm
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
            this.components = new System.ComponentModel.Container();
            this.CALabel = new System.Windows.Forms.Label();
            this.CAComboBox = new System.Windows.Forms.ComboBox();
            this.CAOKButton = new System.Windows.Forms.Button();
            this.CACancelButton = new System.Windows.Forms.Button();
            this.CAerrorProv = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.CAerrorProv)).BeginInit();
            this.SuspendLayout();
            // 
            // CALabel
            // 
            this.CALabel.AutoSize = true;
            this.CALabel.Location = new System.Drawing.Point(93, 27);
            this.CALabel.Name = "CALabel";
            this.CALabel.Size = new System.Drawing.Size(105, 13);
            this.CALabel.TabIndex = 0;
            this.CALabel.Text = "Type Address to Edit";
            // 
            // CAComboBox
            // 
            this.CAComboBox.FormattingEnabled = true;
            this.CAComboBox.Location = new System.Drawing.Point(86, 60);
            this.CAComboBox.Name = "CAComboBox";
            this.CAComboBox.Size = new System.Drawing.Size(121, 21);
            this.CAComboBox.TabIndex = 1;
            this.CAComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.CAComboBox_Validating);
            this.CAComboBox.Validated += new System.EventHandler(this.CAComboBox_Validated);
            // 
            // CAOKButton
            // 
            this.CAOKButton.Location = new System.Drawing.Point(34, 101);
            this.CAOKButton.Name = "CAOKButton";
            this.CAOKButton.Size = new System.Drawing.Size(87, 36);
            this.CAOKButton.TabIndex = 2;
            this.CAOKButton.Text = "OK";
            this.CAOKButton.UseVisualStyleBackColor = true;
            this.CAOKButton.Click += new System.EventHandler(this.CAOKButton_Click);
            // 
            // CACancelButton
            // 
            this.CACancelButton.Location = new System.Drawing.Point(178, 101);
            this.CACancelButton.Name = "CACancelButton";
            this.CACancelButton.Size = new System.Drawing.Size(83, 36);
            this.CACancelButton.TabIndex = 3;
            this.CACancelButton.Text = "Cancel";
            this.CACancelButton.UseVisualStyleBackColor = true;
            this.CACancelButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CACancelButton_MouseDown);
            // 
            // CAerrorProv
            // 
            this.CAerrorProv.ContainerControl = this;
            // 
            // ChooseAddressForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 177);
            this.Controls.Add(this.CACancelButton);
            this.Controls.Add(this.CAOKButton);
            this.Controls.Add(this.CAComboBox);
            this.Controls.Add(this.CALabel);
            this.Name = "ChooseAddressForm";
            this.Text = "Choose Address";
            this.Load += new System.EventHandler(this.ChooseAddressForm_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.CAerrorProv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CALabel;
        private System.Windows.Forms.ComboBox CAComboBox;
        private System.Windows.Forms.Button CAOKButton;
        private System.Windows.Forms.Button CACancelButton;
        private System.Windows.Forms.ErrorProvider CAerrorProv;
    }
}