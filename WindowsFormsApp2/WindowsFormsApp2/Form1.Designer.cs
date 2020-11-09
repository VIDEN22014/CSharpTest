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
            this.intervalIN = new System.Windows.Forms.TextBox();
            this.symbolsReactorColumn0 = new System.Windows.Forms.CheckedListBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.newSymbolKeyIN = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.screenSymbolsIN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.symbolsReactorColumn1 = new System.Windows.Forms.CheckedListBox();
            this.symbolsReactorColumn2 = new System.Windows.Forms.CheckedListBox();
            this.symbolsReactorColumn3 = new System.Windows.Forms.CheckedListBox();
            this.symbolsReactorColumn4 = new System.Windows.Forms.CheckedListBox();
            this.symbolsReactorColumn5 = new System.Windows.Forms.CheckedListBox();
            this.symbolsReactorColumn6 = new System.Windows.Forms.CheckedListBox();
            this.symbolsReactorColumn7 = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(724, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "TimerEvent";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.timerEventButton);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timerEventButton);
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
            // intervalIN
            // 
            this.intervalIN.Location = new System.Drawing.Point(222, 47);
            this.intervalIN.Name = "intervalIN";
            this.intervalIN.Size = new System.Drawing.Size(124, 22);
            this.intervalIN.TabIndex = 5;
            this.intervalIN.TextChanged += new System.EventHandler(this.intervalIN_textChanged);
            // 
            // symbolsReactorColumn0
            // 
            this.symbolsReactorColumn0.CheckOnClick = true;
            this.symbolsReactorColumn0.FormattingEnabled = true;
            this.symbolsReactorColumn0.Items.AddRange(new object[] {
            "7",
            "6",
            "5",
            "4",
            "3",
            "2",
            "1",
            "0"});
            this.symbolsReactorColumn0.Location = new System.Drawing.Point(36, 332);
            this.symbolsReactorColumn0.Name = "symbolsReactorColumn0";
            this.symbolsReactorColumn0.Size = new System.Drawing.Size(22, 157);
            this.symbolsReactorColumn0.TabIndex = 6;
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(12, 78);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(1448, 250);
            this.pictureBox.TabIndex = 14;
            this.pictureBox.TabStop = false;
            // 
            // newSymbolKeyIN
            // 
            this.newSymbolKeyIN.Location = new System.Drawing.Point(260, 332);
            this.newSymbolKeyIN.Name = "newSymbolKeyIN";
            this.newSymbolKeyIN.Size = new System.Drawing.Size(72, 22);
            this.newSymbolKeyIN.TabIndex = 22;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(260, 360);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(72, 42);
            this.button4.TabIndex = 23;
            this.button4.Text = "Додати Символ";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.AddToDictionaryButton);
            // 
            // textBox3
            // 
            this.screenSymbolsIN.Location = new System.Drawing.Point(352, 47);
            this.screenSymbolsIN.Name = "textBox3";
            this.screenSymbolsIN.Size = new System.Drawing.Size(366, 22);
            this.screenSymbolsIN.TabIndex = 24;
            this.screenSymbolsIN.TextChanged += new System.EventHandler(this.screenSymbolsIN_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(219, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 16);
            this.label1.TabIndex = 25;
            this.label1.Text = "Інтервал Таймера";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(486, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 16);
            this.label2.TabIndex = 26;
            this.label2.Text = "Введіть слово:";
            // 
            // symbolsReactorColumn1
            // 
            this.symbolsReactorColumn1.CheckOnClick = true;
            this.symbolsReactorColumn1.FormattingEnabled = true;
            this.symbolsReactorColumn1.Items.AddRange(new object[] {
            "7",
            "6",
            "5",
            "4",
            "3",
            "2",
            "1",
            "0"});
            this.symbolsReactorColumn1.Location = new System.Drawing.Point(64, 332);
            this.symbolsReactorColumn1.Name = "symbolsReactorColumn1";
            this.symbolsReactorColumn1.Size = new System.Drawing.Size(22, 157);
            this.symbolsReactorColumn1.TabIndex = 27;
            // 
            // symbolsReactorColumn2
            // 
            this.symbolsReactorColumn2.CheckOnClick = true;
            this.symbolsReactorColumn2.FormattingEnabled = true;
            this.symbolsReactorColumn2.Items.AddRange(new object[] {
            "7",
            "6",
            "5",
            "4",
            "3",
            "2",
            "1",
            "0"});
            this.symbolsReactorColumn2.Location = new System.Drawing.Point(92, 332);
            this.symbolsReactorColumn2.Name = "symbolsReactorColumn2";
            this.symbolsReactorColumn2.Size = new System.Drawing.Size(22, 157);
            this.symbolsReactorColumn2.TabIndex = 28;
            // 
            // symbolsReactorColumn3
            // 
            this.symbolsReactorColumn3.CheckOnClick = true;
            this.symbolsReactorColumn3.FormattingEnabled = true;
            this.symbolsReactorColumn3.Items.AddRange(new object[] {
            "7",
            "6",
            "5",
            "4",
            "3",
            "2",
            "1",
            "0"});
            this.symbolsReactorColumn3.Location = new System.Drawing.Point(120, 332);
            this.symbolsReactorColumn3.Name = "symbolsReactorColumn3";
            this.symbolsReactorColumn3.Size = new System.Drawing.Size(22, 157);
            this.symbolsReactorColumn3.TabIndex = 29;
            // 
            // symbolsReactorColumn4
            // 
            this.symbolsReactorColumn4.CheckOnClick = true;
            this.symbolsReactorColumn4.FormattingEnabled = true;
            this.symbolsReactorColumn4.Items.AddRange(new object[] {
            "7",
            "6",
            "5",
            "4",
            "3",
            "2",
            "1",
            "0"});
            this.symbolsReactorColumn4.Location = new System.Drawing.Point(148, 332);
            this.symbolsReactorColumn4.Name = "symbolsReactorColumn4";
            this.symbolsReactorColumn4.Size = new System.Drawing.Size(22, 157);
            this.symbolsReactorColumn4.TabIndex = 30;
            // 
            // symbolsReactorColumn5
            // 
            this.symbolsReactorColumn5.CheckOnClick = true;
            this.symbolsReactorColumn5.FormattingEnabled = true;
            this.symbolsReactorColumn5.Items.AddRange(new object[] {
            "7",
            "6",
            "5",
            "4",
            "3",
            "2",
            "1",
            "0"});
            this.symbolsReactorColumn5.Location = new System.Drawing.Point(176, 332);
            this.symbolsReactorColumn5.Name = "symbolsReactorColumn5";
            this.symbolsReactorColumn5.Size = new System.Drawing.Size(22, 157);
            this.symbolsReactorColumn5.TabIndex = 31;
            // 
            // symbolsReactorColumn6
            // 
            this.symbolsReactorColumn6.CheckOnClick = true;
            this.symbolsReactorColumn6.FormattingEnabled = true;
            this.symbolsReactorColumn6.Items.AddRange(new object[] {
            "7",
            "6",
            "5",
            "4",
            "3",
            "2",
            "1",
            "0"});
            this.symbolsReactorColumn6.Location = new System.Drawing.Point(204, 332);
            this.symbolsReactorColumn6.Name = "symbolsReactorColumn6";
            this.symbolsReactorColumn6.Size = new System.Drawing.Size(22, 157);
            this.symbolsReactorColumn6.TabIndex = 32;
            // 
            // symbolsReactorColumn7
            // 
            this.symbolsReactorColumn7.CheckOnClick = true;
            this.symbolsReactorColumn7.FormattingEnabled = true;
            this.symbolsReactorColumn7.Items.AddRange(new object[] {
            "7",
            "6",
            "5",
            "4",
            "3",
            "2",
            "1",
            "0"});
            this.symbolsReactorColumn7.Location = new System.Drawing.Point(232, 332);
            this.symbolsReactorColumn7.Name = "symbolsReactorColumn7";
            this.symbolsReactorColumn7.Size = new System.Drawing.Size(22, 157);
            this.symbolsReactorColumn7.TabIndex = 33;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1472, 614);
            this.Controls.Add(this.symbolsReactorColumn7);
            this.Controls.Add(this.symbolsReactorColumn6);
            this.Controls.Add(this.symbolsReactorColumn5);
            this.Controls.Add(this.symbolsReactorColumn4);
            this.Controls.Add(this.symbolsReactorColumn3);
            this.Controls.Add(this.symbolsReactorColumn2);
            this.Controls.Add(this.symbolsReactorColumn1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.screenSymbolsIN);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.newSymbolKeyIN);
            this.Controls.Add(this.symbolsReactorColumn0);
            this.Controls.Add(this.intervalIN);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox intervalIN;
        private System.Windows.Forms.PictureBox pictureBox;
        public System.Windows.Forms.CheckedListBox symbolsReactorColumn0;
        private System.Windows.Forms.TextBox newSymbolKeyIN;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox screenSymbolsIN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.CheckedListBox symbolsReactorColumn1;
        public System.Windows.Forms.CheckedListBox symbolsReactorColumn2;
        public System.Windows.Forms.CheckedListBox symbolsReactorColumn3;
        public System.Windows.Forms.CheckedListBox symbolsReactorColumn4;
        public System.Windows.Forms.CheckedListBox symbolsReactorColumn5;
        public System.Windows.Forms.CheckedListBox symbolsReactorColumn6;
        public System.Windows.Forms.CheckedListBox symbolsReactorColumn7;
    }
}

