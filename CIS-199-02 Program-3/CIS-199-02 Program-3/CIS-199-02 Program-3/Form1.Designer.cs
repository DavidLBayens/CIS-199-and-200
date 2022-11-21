
namespace CIS_199_02_Program_3
{
    partial class Program3
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
            this.FarmCombo = new System.Windows.Forms.ComboBox();
            this.QuantityText = new System.Windows.Forms.TextBox();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.FarmLabel = new System.Windows.Forms.Label();
            this.ItemLabel = new System.Windows.Forms.Label();
            this.QuantityLabel = new System.Windows.Forms.Label();
            this.CostLabel = new System.Windows.Forms.Label();
            this.DiscountLabel = new System.Windows.Forms.Label();
            this.ShipmentLabel = new System.Windows.Forms.Label();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.CostBox = new System.Windows.Forms.Label();
            this.DiscountBox = new System.Windows.Forms.Label();
            this.ShipmentBox = new System.Windows.Forms.Label();
            this.TotalBox = new System.Windows.Forms.Label();
            this.ItemCombo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // FarmCombo
            // 
            this.FarmCombo.BackColor = System.Drawing.Color.SandyBrown;
            this.FarmCombo.FormattingEnabled = true;
            this.FarmCombo.Items.AddRange(new object[] {
            "NE",
            "NW",
            "SE",
            "SW"});
            this.FarmCombo.Location = new System.Drawing.Point(162, 67);
            this.FarmCombo.Name = "FarmCombo";
            this.FarmCombo.Size = new System.Drawing.Size(100, 21);
            this.FarmCombo.TabIndex = 0;
            // 
            // QuantityText
            // 
            this.QuantityText.BackColor = System.Drawing.Color.SandyBrown;
            this.QuantityText.Location = new System.Drawing.Point(162, 157);
            this.QuantityText.Name = "QuantityText";
            this.QuantityText.Size = new System.Drawing.Size(100, 20);
            this.QuantityText.TabIndex = 2;
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(73, 217);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(189, 23);
            this.CalculateButton.TabIndex = 3;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // FarmLabel
            // 
            this.FarmLabel.AutoSize = true;
            this.FarmLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FarmLabel.Location = new System.Drawing.Point(70, 70);
            this.FarmLabel.Name = "FarmLabel";
            this.FarmLabel.Size = new System.Drawing.Size(38, 13);
            this.FarmLabel.TabIndex = 4;
            this.FarmLabel.Text = "Farm:";
            // 
            // ItemLabel
            // 
            this.ItemLabel.AutoSize = true;
            this.ItemLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemLabel.Location = new System.Drawing.Point(70, 117);
            this.ItemLabel.Name = "ItemLabel";
            this.ItemLabel.Size = new System.Drawing.Size(35, 13);
            this.ItemLabel.TabIndex = 5;
            this.ItemLabel.Text = "Item:";
            // 
            // QuantityLabel
            // 
            this.QuantityLabel.AutoSize = true;
            this.QuantityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityLabel.Location = new System.Drawing.Point(70, 160);
            this.QuantityLabel.Name = "QuantityLabel";
            this.QuantityLabel.Size = new System.Drawing.Size(86, 13);
            this.QuantityLabel.TabIndex = 6;
            this.QuantityLabel.Text = "Quantity (lbs):";
            // 
            // CostLabel
            // 
            this.CostLabel.AutoSize = true;
            this.CostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CostLabel.Location = new System.Drawing.Point(70, 275);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(71, 13);
            this.CostLabel.TabIndex = 7;
            this.CostLabel.Text = "Initial Cost:";
            // 
            // DiscountLabel
            // 
            this.DiscountLabel.AutoSize = true;
            this.DiscountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiscountLabel.Location = new System.Drawing.Point(70, 319);
            this.DiscountLabel.Name = "DiscountLabel";
            this.DiscountLabel.Size = new System.Drawing.Size(104, 13);
            this.DiscountLabel.TabIndex = 8;
            this.DiscountLabel.Text = "Discounted Cost:";
            // 
            // ShipmentLabel
            // 
            this.ShipmentLabel.AutoSize = true;
            this.ShipmentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShipmentLabel.Location = new System.Drawing.Point(70, 357);
            this.ShipmentLabel.Name = "ShipmentLabel";
            this.ShipmentLabel.Size = new System.Drawing.Size(92, 13);
            this.ShipmentLabel.TabIndex = 9;
            this.ShipmentLabel.Text = "Shipment Cost:";
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalLabel.Location = new System.Drawing.Point(70, 399);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(69, 13);
            this.TotalLabel.TabIndex = 10;
            this.TotalLabel.Text = "Total Cost:";
            // 
            // CostBox
            // 
            this.CostBox.BackColor = System.Drawing.Color.SandyBrown;
            this.CostBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CostBox.Location = new System.Drawing.Point(194, 274);
            this.CostBox.Name = "CostBox";
            this.CostBox.Size = new System.Drawing.Size(90, 23);
            this.CostBox.TabIndex = 11;
            // 
            // DiscountBox
            // 
            this.DiscountBox.BackColor = System.Drawing.Color.SandyBrown;
            this.DiscountBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DiscountBox.Location = new System.Drawing.Point(194, 318);
            this.DiscountBox.Name = "DiscountBox";
            this.DiscountBox.Size = new System.Drawing.Size(90, 22);
            this.DiscountBox.TabIndex = 12;
            // 
            // ShipmentBox
            // 
            this.ShipmentBox.BackColor = System.Drawing.Color.SandyBrown;
            this.ShipmentBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ShipmentBox.Location = new System.Drawing.Point(194, 356);
            this.ShipmentBox.Name = "ShipmentBox";
            this.ShipmentBox.Size = new System.Drawing.Size(90, 24);
            this.ShipmentBox.TabIndex = 13;
            // 
            // TotalBox
            // 
            this.TotalBox.BackColor = System.Drawing.Color.SandyBrown;
            this.TotalBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TotalBox.Location = new System.Drawing.Point(194, 398);
            this.TotalBox.Name = "TotalBox";
            this.TotalBox.Size = new System.Drawing.Size(90, 23);
            this.TotalBox.TabIndex = 14;
            // 
            // ItemCombo
            // 
            this.ItemCombo.BackColor = System.Drawing.Color.SandyBrown;
            this.ItemCombo.FormattingEnabled = true;
            this.ItemCombo.Items.AddRange(new object[] {
            "10001",
            "10002",
            "10003",
            "10004",
            "10005",
            "10006",
            "10007"});
            this.ItemCombo.Location = new System.Drawing.Point(162, 114);
            this.ItemCombo.Name = "ItemCombo";
            this.ItemCombo.Size = new System.Drawing.Size(100, 21);
            this.ItemCombo.TabIndex = 15;
            // 
            // Program3
            // 
            this.AcceptButton = this.CalculateButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 450);
            this.Controls.Add(this.ItemCombo);
            this.Controls.Add(this.TotalBox);
            this.Controls.Add(this.ShipmentBox);
            this.Controls.Add(this.DiscountBox);
            this.Controls.Add(this.CostBox);
            this.Controls.Add(this.TotalLabel);
            this.Controls.Add(this.ShipmentLabel);
            this.Controls.Add(this.DiscountLabel);
            this.Controls.Add(this.CostLabel);
            this.Controls.Add(this.QuantityLabel);
            this.Controls.Add(this.ItemLabel);
            this.Controls.Add(this.FarmLabel);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.QuantityText);
            this.Controls.Add(this.FarmCombo);
            this.Name = "Program3";
            this.Text = "Program 3";
            this.Load += new System.EventHandler(this.Program3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox FarmCombo;
        private System.Windows.Forms.TextBox QuantityText;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Label FarmLabel;
        private System.Windows.Forms.Label ItemLabel;
        private System.Windows.Forms.Label QuantityLabel;
        private System.Windows.Forms.Label CostLabel;
        private System.Windows.Forms.Label DiscountLabel;
        private System.Windows.Forms.Label ShipmentLabel;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.Label CostBox;
        private System.Windows.Forms.Label DiscountBox;
        private System.Windows.Forms.Label ShipmentBox;
        private System.Windows.Forms.Label TotalBox;
        private System.Windows.Forms.ComboBox ItemCombo;
    }
}

