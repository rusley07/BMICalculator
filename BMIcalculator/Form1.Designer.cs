namespace BMIcalculator
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
            this.heightLabel = new System.Windows.Forms.Label();
            this.weightTextBox = new System.Windows.Forms.TextBox();
            this.weightLabel = new System.Windows.Forms.Label();
            this.heightTextBox = new System.Windows.Forms.TextBox();
            this.bodyLabel = new System.Windows.Forms.Label();
            this.rangeLabel = new System.Windows.Forms.Label();
            this.bodyMassLabel = new System.Windows.Forms.Label();
            this.weightRangeLabel = new System.Windows.Forms.Label();
            this.bodyMassButton = new System.Windows.Forms.Button();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Location = new System.Drawing.Point(12, 28);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(38, 13);
            this.heightLabel.TabIndex = 0;
            this.heightLabel.Text = "Height";
            // 
            // weightTextBox
            // 
            this.weightTextBox.Location = new System.Drawing.Point(116, 52);
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.Size = new System.Drawing.Size(100, 20);
            this.weightTextBox.TabIndex = 1;
            // 
            // weightLabel
            // 
            this.weightLabel.AutoSize = true;
            this.weightLabel.Location = new System.Drawing.Point(12, 55);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(41, 13);
            this.weightLabel.TabIndex = 2;
            this.weightLabel.Text = "Weight";
            // 
            // heightTextBox
            // 
            this.heightTextBox.Location = new System.Drawing.Point(116, 21);
            this.heightTextBox.Name = "heightTextBox";
            this.heightTextBox.Size = new System.Drawing.Size(100, 20);
            this.heightTextBox.TabIndex = 3;
            // 
            // bodyLabel
            // 
            this.bodyLabel.AutoSize = true;
            this.bodyLabel.Location = new System.Drawing.Point(12, 128);
            this.bodyLabel.Name = "bodyLabel";
            this.bodyLabel.Size = new System.Drawing.Size(88, 13);
            this.bodyLabel.TabIndex = 4;
            this.bodyLabel.Text = "Body Mass Index";
            // 
            // rangeLabel
            // 
            this.rangeLabel.AutoSize = true;
            this.rangeLabel.Location = new System.Drawing.Point(12, 157);
            this.rangeLabel.Name = "rangeLabel";
            this.rangeLabel.Size = new System.Drawing.Size(76, 13);
            this.rangeLabel.TabIndex = 5;
            this.rangeLabel.Text = "Weight Range";
            // 
            // bodyMassLabel
            // 
            this.bodyMassLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bodyMassLabel.Location = new System.Drawing.Point(165, 123);
            this.bodyMassLabel.Name = "bodyMassLabel";
            this.bodyMassLabel.Size = new System.Drawing.Size(100, 23);
            this.bodyMassLabel.TabIndex = 6;
            // 
            // weightRangeLabel
            // 
            this.weightRangeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.weightRangeLabel.Location = new System.Drawing.Point(165, 157);
            this.weightRangeLabel.Name = "weightRangeLabel";
            this.weightRangeLabel.Size = new System.Drawing.Size(100, 23);
            this.weightRangeLabel.TabIndex = 7;
            // 
            // bodyMassButton
            // 
            this.bodyMassButton.Location = new System.Drawing.Point(314, 99);
            this.bodyMassButton.Name = "bodyMassButton";
            this.bodyMassButton.Size = new System.Drawing.Size(75, 47);
            this.bodyMassButton.TabIndex = 8;
            this.bodyMassButton.Text = "Calculate Body Mass";
            this.bodyMassButton.UseVisualStyleBackColor = true;
            this.bodyMassButton.Click += new System.EventHandler(this.bodyMassButton_Click);
            // 
            // scoreLabel
            // 
            this.scoreLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.scoreLabel.Location = new System.Drawing.Point(165, 190);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(100, 23);
            this.scoreLabel.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 293);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.bodyMassButton);
            this.Controls.Add(this.weightRangeLabel);
            this.Controls.Add(this.bodyMassLabel);
            this.Controls.Add(this.rangeLabel);
            this.Controls.Add(this.bodyLabel);
            this.Controls.Add(this.heightTextBox);
            this.Controls.Add(this.weightLabel);
            this.Controls.Add(this.weightTextBox);
            this.Controls.Add(this.heightLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.TextBox weightTextBox;
        private System.Windows.Forms.Label weightLabel;
        private System.Windows.Forms.TextBox heightTextBox;
        private System.Windows.Forms.Label bodyLabel;
        private System.Windows.Forms.Label rangeLabel;
        private System.Windows.Forms.Label bodyMassLabel;
        private System.Windows.Forms.Label weightRangeLabel;
        private System.Windows.Forms.Button bodyMassButton;
        private System.Windows.Forms.Label scoreLabel;
    }
}

