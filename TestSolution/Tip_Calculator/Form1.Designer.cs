namespace Tip_Calculator
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
            this.TotalTextBox = new System.Windows.Forms.TextBox();
            this.TipTextBox = new System.Windows.Forms.TextBox();
            this.CaclulateButton = new System.Windows.Forms.Button();
            this.billTotalLabel = new System.Windows.Forms.Label();
            this.percentTipUpdown = new System.Windows.Forms.NumericUpDown();
            this.TipPercentLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.percentTipUpdown)).BeginInit();
            this.SuspendLayout();
            // 
            // TotalTextBox
            // 
            this.TotalTextBox.Location = new System.Drawing.Point(111, 39);
            this.TotalTextBox.Name = "TotalTextBox";
            this.TotalTextBox.Size = new System.Drawing.Size(100, 20);
            this.TotalTextBox.TabIndex = 0;
            this.TotalTextBox.TextChanged += new System.EventHandler(this.CaclulateButton_Click);
            // 
            // TipTextBox
            // 
            this.TipTextBox.Enabled = false;
            this.TipTextBox.Location = new System.Drawing.Point(111, 83);
            this.TipTextBox.Name = "TipTextBox";
            this.TipTextBox.Size = new System.Drawing.Size(100, 20);
            this.TipTextBox.TabIndex = 1;
            // 
            // CaclulateButton
            // 
            this.CaclulateButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.CaclulateButton.Location = new System.Drawing.Point(12, 83);
            this.CaclulateButton.Name = "CaclulateButton";
            this.CaclulateButton.Size = new System.Drawing.Size(75, 23);
            this.CaclulateButton.TabIndex = 2;
            this.CaclulateButton.Text = "Compute Tip";
            this.CaclulateButton.UseVisualStyleBackColor = false;
            this.CaclulateButton.Click += new System.EventHandler(this.CaclulateButton_Click);
            // 
            // billTotalLabel
            // 
            this.billTotalLabel.AutoSize = true;
            this.billTotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billTotalLabel.Location = new System.Drawing.Point(22, 42);
            this.billTotalLabel.Name = "billTotalLabel";
            this.billTotalLabel.Size = new System.Drawing.Size(73, 13);
            this.billTotalLabel.TabIndex = 3;
            this.billTotalLabel.Text = "Enter Total Bill";
            // 
            // percentTipUpdown
            // 
            this.percentTipUpdown.Location = new System.Drawing.Point(111, 57);
            this.percentTipUpdown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.percentTipUpdown.Name = "percentTipUpdown";
            this.percentTipUpdown.Size = new System.Drawing.Size(120, 20);
            this.percentTipUpdown.TabIndex = 4;
            this.percentTipUpdown.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.percentTipUpdown.ValueChanged += new System.EventHandler(this.CaclulateButton_Click);
            // 
            // TipPercentLabel
            // 
            this.TipPercentLabel.AutoSize = true;
            this.TipPercentLabel.Location = new System.Drawing.Point(25, 63);
            this.TipPercentLabel.Name = "TipPercentLabel";
            this.TipPercentLabel.Size = new System.Drawing.Size(62, 13);
            this.TipPercentLabel.TabIndex = 5;
            this.TipPercentLabel.Text = "Percent Tip";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.TipPercentLabel);
            this.Controls.Add(this.percentTipUpdown);
            this.Controls.Add(this.billTotalLabel);
            this.Controls.Add(this.CaclulateButton);
            this.Controls.Add(this.TipTextBox);
            this.Controls.Add(this.TotalTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.percentTipUpdown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TotalTextBox;
        private System.Windows.Forms.TextBox TipTextBox;
        private System.Windows.Forms.Button CaclulateButton;
        private System.Windows.Forms.Label billTotalLabel;
        private System.Windows.Forms.NumericUpDown percentTipUpdown;
        private System.Windows.Forms.Label TipPercentLabel;
    }
}

