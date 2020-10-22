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
            this.groupOutput = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.studentNameIN = new System.Windows.Forms.TextBox();
            this.studentAgeIN = new System.Windows.Forms.TextBox();
            this.studentMassIN = new System.Windows.Forms.TextBox();
            this.studentMarkIN = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.sortTypeIN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.filterTypeIN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.emailImitationOUT = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.form1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(124, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 69);
            this.button1.TabIndex = 0;
            this.button1.Text = "Додати Студента";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.addButton);
            // 
            // groupOutput
            // 
            this.groupOutput.AutoSize = true;
            this.groupOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupOutput.Location = new System.Drawing.Point(441, 11);
            this.groupOutput.Name = "groupOutput";
            this.groupOutput.Size = new System.Drawing.Size(281, 18);
            this.groupOutput.TabIndex = 1;
            this.groupOutput.Text = "Інформація Про Студентів Групи КН-21";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 58);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 69);
            this.button2.TabIndex = 2;
            this.button2.Text = "Вилучити Останнього Студента";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.removeButton);
            // 
            // studentNameIN
            // 
            this.studentNameIN.AccessibleDescription = "Бан";
            this.studentNameIN.Location = new System.Drawing.Point(12, 30);
            this.studentNameIN.Name = "studentNameIN";
            this.studentNameIN.Size = new System.Drawing.Size(176, 22);
            this.studentNameIN.TabIndex = 4;
            // 
            // studentAgeIN
            // 
            this.studentAgeIN.AccessibleDescription = "Бан";
            this.studentAgeIN.Location = new System.Drawing.Point(194, 30);
            this.studentAgeIN.Name = "studentAgeIN";
            this.studentAgeIN.Size = new System.Drawing.Size(27, 22);
            this.studentAgeIN.TabIndex = 5;
            // 
            // studentMassIN
            // 
            this.studentMassIN.AccessibleDescription = "Бан";
            this.studentMassIN.Location = new System.Drawing.Point(227, 30);
            this.studentMassIN.Name = "studentMassIN";
            this.studentMassIN.Size = new System.Drawing.Size(44, 22);
            this.studentMassIN.TabIndex = 6;
            // 
            // studentMarkIN
            // 
            this.studentMarkIN.AccessibleDescription = "Бан";
            this.studentMarkIN.Location = new System.Drawing.Point(277, 30);
            this.studentMarkIN.Name = "studentMarkIN";
            this.studentMarkIN.Size = new System.Drawing.Size(57, 22);
            this.studentMarkIN.TabIndex = 7;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 179);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(106, 36);
            this.button3.TabIndex = 8;
            this.button3.Text = "Сортувати";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.sortButton);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(124, 179);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(106, 36);
            this.button4.TabIndex = 9;
            this.button4.Text = "Фільтрувати";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.filterButton);
            // 
            // sortTypeIN
            // 
            this.sortTypeIN.AccessibleDescription = "Бан";
            this.sortTypeIN.Location = new System.Drawing.Point(12, 151);
            this.sortTypeIN.Name = "sortTypeIN";
            this.sortTypeIN.Size = new System.Drawing.Size(106, 22);
            this.sortTypeIN.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Ім\'я та Прізвище";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(194, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Вік";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(227, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Вага";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(277, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Оцінка";
            // 
            // filterTypeIN
            // 
            this.filterTypeIN.AccessibleDescription = "Бан";
            this.filterTypeIN.Location = new System.Drawing.Point(124, 151);
            this.filterTypeIN.Name = "filterTypeIN";
            this.filterTypeIN.Size = new System.Drawing.Size(106, 22);
            this.filterTypeIN.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "Тип Сортування";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Тип Фільтрації";
            // 
            // emailImitationOUT
            // 
            this.emailImitationOUT.AutoSize = true;
            this.emailImitationOUT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emailImitationOUT.Location = new System.Drawing.Point(9, 231);
            this.emailImitationOUT.Name = "emailImitationOUT";
            this.emailImitationOUT.Size = new System.Drawing.Size(135, 18);
            this.emailImitationOUT.TabIndex = 19;
            this.emailImitationOUT.Text = "Імітація Розсилки:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(340, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 57;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(475, 217);
            this.dataGridView1.TabIndex = 20;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Name";
            this.Column1.MinimumWidth = 7;
            this.Column1.Name = "Column1";
            this.Column1.Width = 140;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Age";
            this.Column2.MinimumWidth = 7;
            this.Column2.Name = "Column2";
            this.Column2.Width = 50;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Mass";
            this.Column3.MinimumWidth = 7;
            this.Column3.Name = "Column3";
            this.Column3.Width = 50;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Mark";
            this.Column4.MinimumWidth = 7;
            this.Column4.Name = "Column4";
            this.Column4.Width = 50;
            // 
            // form1BindingSource
            // 
            this.form1BindingSource.DataSource = typeof(WindowsFormsApp2.Form1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 614);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.emailImitationOUT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.filterTypeIN);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sortTypeIN);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.studentMarkIN);
            this.Controls.Add(this.studentMassIN);
            this.Controls.Add(this.studentAgeIN);
            this.Controls.Add(this.studentNameIN);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupOutput);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label groupOutput;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox studentNameIN;
        private System.Windows.Forms.TextBox studentAgeIN;
        private System.Windows.Forms.TextBox studentMassIN;
        private System.Windows.Forms.TextBox studentMarkIN;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox sortTypeIN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox filterTypeIN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label emailImitationOUT;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource form1BindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}

