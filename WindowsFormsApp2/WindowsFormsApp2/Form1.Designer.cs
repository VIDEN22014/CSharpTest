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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.checkedListBox2 = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox3 = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox4 = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox5 = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox6 = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox7 = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox8 = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(987, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.moveButton);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.moveButton);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(30, 44);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 28);
            this.button2.TabIndex = 3;
            this.button2.Text = "Запустити";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.timerStartButton);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(126, 44);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 28);
            this.button3.TabIndex = 4;
            this.button3.Text = "Зупинити";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.timerStopButton);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(222, 47);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            ""});
            this.checkedListBox1.Location = new System.Drawing.Point(30, 348);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(22, 157);
            this.checkedListBox1.TabIndex = 6;
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(12, 78);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(1448, 250);
            this.pictureBox.TabIndex = 14;
            this.pictureBox.TabStop = false;
            // 
            // checkedListBox2
            // 
            this.checkedListBox2.CheckOnClick = true;
            this.checkedListBox2.FormattingEnabled = true;
            this.checkedListBox2.Items.AddRange(new object[] {
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            ""});
            this.checkedListBox2.Location = new System.Drawing.Point(58, 348);
            this.checkedListBox2.Name = "checkedListBox2";
            this.checkedListBox2.Size = new System.Drawing.Size(22, 157);
            this.checkedListBox2.TabIndex = 15;
            // 
            // checkedListBox3
            // 
            this.checkedListBox3.CheckOnClick = true;
            this.checkedListBox3.FormattingEnabled = true;
            this.checkedListBox3.Items.AddRange(new object[] {
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            ""});
            this.checkedListBox3.Location = new System.Drawing.Point(86, 348);
            this.checkedListBox3.Name = "checkedListBox3";
            this.checkedListBox3.Size = new System.Drawing.Size(22, 157);
            this.checkedListBox3.TabIndex = 16;
            // 
            // checkedListBox4
            // 
            this.checkedListBox4.CheckOnClick = true;
            this.checkedListBox4.FormattingEnabled = true;
            this.checkedListBox4.Items.AddRange(new object[] {
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            ""});
            this.checkedListBox4.Location = new System.Drawing.Point(114, 348);
            this.checkedListBox4.Name = "checkedListBox4";
            this.checkedListBox4.Size = new System.Drawing.Size(22, 157);
            this.checkedListBox4.TabIndex = 17;
            // 
            // checkedListBox5
            // 
            this.checkedListBox5.CheckOnClick = true;
            this.checkedListBox5.FormattingEnabled = true;
            this.checkedListBox5.Items.AddRange(new object[] {
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            ""});
            this.checkedListBox5.Location = new System.Drawing.Point(142, 348);
            this.checkedListBox5.Name = "checkedListBox5";
            this.checkedListBox5.Size = new System.Drawing.Size(22, 157);
            this.checkedListBox5.TabIndex = 18;
            // 
            // checkedListBox6
            // 
            this.checkedListBox6.CheckOnClick = true;
            this.checkedListBox6.FormattingEnabled = true;
            this.checkedListBox6.Items.AddRange(new object[] {
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            ""});
            this.checkedListBox6.Location = new System.Drawing.Point(170, 348);
            this.checkedListBox6.Name = "checkedListBox6";
            this.checkedListBox6.Size = new System.Drawing.Size(22, 157);
            this.checkedListBox6.TabIndex = 19;
            // 
            // checkedListBox7
            // 
            this.checkedListBox7.CheckOnClick = true;
            this.checkedListBox7.FormattingEnabled = true;
            this.checkedListBox7.Items.AddRange(new object[] {
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            ""});
            this.checkedListBox7.Location = new System.Drawing.Point(198, 348);
            this.checkedListBox7.Name = "checkedListBox7";
            this.checkedListBox7.Size = new System.Drawing.Size(22, 157);
            this.checkedListBox7.TabIndex = 20;
            // 
            // checkedListBox8
            // 
            this.checkedListBox8.CheckOnClick = true;
            this.checkedListBox8.FormattingEnabled = true;
            this.checkedListBox8.Items.AddRange(new object[] {
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            ""});
            this.checkedListBox8.Location = new System.Drawing.Point(226, 348);
            this.checkedListBox8.Name = "checkedListBox8";
            this.checkedListBox8.Size = new System.Drawing.Size(22, 157);
            this.checkedListBox8.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1472, 614);
            this.Controls.Add(this.checkedListBox8);
            this.Controls.Add(this.checkedListBox7);
            this.Controls.Add(this.checkedListBox6);
            this.Controls.Add(this.checkedListBox5);
            this.Controls.Add(this.checkedListBox4);
            this.Controls.Add(this.checkedListBox3);
            this.Controls.Add(this.checkedListBox2);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox;
        public System.Windows.Forms.CheckedListBox checkedListBox1;
        public System.Windows.Forms.CheckedListBox checkedListBox2;
        public System.Windows.Forms.CheckedListBox checkedListBox3;
        public System.Windows.Forms.CheckedListBox checkedListBox4;
        public System.Windows.Forms.CheckedListBox checkedListBox5;
        public System.Windows.Forms.CheckedListBox checkedListBox6;
        public System.Windows.Forms.CheckedListBox checkedListBox7;
        public System.Windows.Forms.CheckedListBox checkedListBox8;
    }
}

