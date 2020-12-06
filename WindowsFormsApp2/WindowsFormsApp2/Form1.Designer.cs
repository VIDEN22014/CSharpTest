namespace WindowsFormsApp2
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
            this.button1 = new System.Windows.Forms.Button();
            this.consoleIN = new System.Windows.Forms.TextBox();
            this.consoleOUT = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(304, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.consoleIN.Location = new System.Drawing.Point(72, 47);
            this.consoleIN.Name = "textBox1";
            this.consoleIN.Size = new System.Drawing.Size(226, 22);
            this.consoleIN.TabIndex = 1;
            // 
            // label1
            // 
            this.consoleOUT.AutoSize = true;
            this.consoleOUT.Location = new System.Drawing.Point(72, 76);
            this.consoleOUT.Name = "label1";
            this.consoleOUT.Size = new System.Drawing.Size(45, 16);
            this.consoleOUT.TabIndex = 2;
            this.consoleOUT.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 545);
            this.Controls.Add(this.consoleOUT);
            this.Controls.Add(this.consoleIN);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox consoleIN;
        private System.Windows.Forms.Label consoleOUT;
    }
}

