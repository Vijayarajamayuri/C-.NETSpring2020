namespace SampleCalc
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
            this.display = new System.Windows.Forms.TextBox();
            this.OneButton = new System.Windows.Forms.Button();
            this.fiveButton = new System.Windows.Forms.Button();
            this.plusButton = new System.Windows.Forms.Button();
            this.equalsButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // display
            // 
            this.display.Location = new System.Drawing.Point(263, 73);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(287, 26);
            this.display.TabIndex = 0;
            this.display.Text = "0";
            this.display.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // OneButton
            // 
            this.OneButton.Location = new System.Drawing.Point(263, 151);
            this.OneButton.Name = "OneButton";
            this.OneButton.Size = new System.Drawing.Size(75, 34);
            this.OneButton.TabIndex = 1;
            this.OneButton.Text = "1";
            this.OneButton.UseVisualStyleBackColor = true;
            this.OneButton.Click += new System.EventHandler(this.OneButton_Click);
            // 
            // fiveButton
            // 
            this.fiveButton.Location = new System.Drawing.Point(376, 151);
            this.fiveButton.Name = "fiveButton";
            this.fiveButton.Size = new System.Drawing.Size(75, 34);
            this.fiveButton.TabIndex = 2;
            this.fiveButton.Text = "5";
            this.fiveButton.UseVisualStyleBackColor = true;
            this.fiveButton.Click += new System.EventHandler(this.fiveButton_Click);
            // 
            // plusButton
            // 
            this.plusButton.Location = new System.Drawing.Point(263, 205);
            this.plusButton.Name = "plusButton";
            this.plusButton.Size = new System.Drawing.Size(75, 36);
            this.plusButton.TabIndex = 3;
            this.plusButton.Text = "+";
            this.plusButton.UseVisualStyleBackColor = true;
            this.plusButton.Click += new System.EventHandler(this.plusButton_Click);
            // 
            // equalsButton
            // 
            this.equalsButton.Location = new System.Drawing.Point(376, 205);
            this.equalsButton.Name = "equalsButton";
            this.equalsButton.Size = new System.Drawing.Size(75, 36);
            this.equalsButton.TabIndex = 4;
            this.equalsButton.Text = "=";
            this.equalsButton.UseVisualStyleBackColor = true;
            this.equalsButton.Click += new System.EventHandler(this.equalsButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(263, 272);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 36);
            this.clearButton.TabIndex = 5;
            this.clearButton.Text = "C";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.equalsButton);
            this.Controls.Add(this.plusButton);
            this.Controls.Add(this.fiveButton);
            this.Controls.Add(this.OneButton);
            this.Controls.Add(this.display);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox display;
        private System.Windows.Forms.Button OneButton;
        private System.Windows.Forms.Button fiveButton;
        private System.Windows.Forms.Button plusButton;
        private System.Windows.Forms.Button equalsButton;
        private System.Windows.Forms.Button clearButton;
    }
}

