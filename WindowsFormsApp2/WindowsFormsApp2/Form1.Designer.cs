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
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(271, 186);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 69);
            this.button1.TabIndex = 0;
            this.button1.Text = "Додати Студента";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.addButton);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(428, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Поле Для Виводу";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(159, 186);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 69);
            this.button2.TabIndex = 2;
            this.button2.Text = "Вилучити Останнього Студента";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.removeButton);
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteCustomSource.AddRange(new string[] {
            "name",
            "age",
            "mass",
            "mark"});
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "name",
            "age",
            "mass",
            "mark"});
            this.comboBox1.Location = new System.Drawing.Point(159, 261);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(170, 24);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.Text = "Спосіб Сортування";
            // 
            // textBox1
            // 
            this.textBox1.AccessibleDescription = "Бан";
            this.textBox1.Location = new System.Drawing.Point(159, 158);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(117, 22);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.AccessibleDescription = "Бан";
            this.textBox2.Location = new System.Drawing.Point(282, 158);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(27, 22);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.AccessibleDescription = "Бан";
            this.textBox3.Location = new System.Drawing.Point(315, 158);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(44, 22);
            this.textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            this.textBox4.AccessibleDescription = "Бан";
            this.textBox4.Location = new System.Drawing.Point(365, 158);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(57, 22);
            this.textBox4.TabIndex = 7;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(159, 291);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(106, 36);
            this.button3.TabIndex = 8;
            this.button3.Text = "Сортувати";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.sortButton);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(159, 361);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(106, 36);
            this.button4.TabIndex = 9;
            this.button4.Text = "Фільтрувати";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.filterButton);
            // 
            // textBox5
            // 
            this.textBox5.AccessibleDescription = "Бан";
            this.textBox5.Location = new System.Drawing.Point(159, 333);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 22);
            this.textBox5.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(156, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Ім\'я та Прізвище";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(279, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Вік";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(312, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Вага";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(362, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Оцінка";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 614);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

