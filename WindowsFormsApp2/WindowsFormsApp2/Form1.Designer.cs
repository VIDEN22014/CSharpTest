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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.leftBorderIN = new System.Windows.Forms.TextBox();
            this.func1 = new System.Windows.Forms.RadioButton();
            this.functionGraph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.rightBorderIN = new System.Windows.Forms.TextBox();
            this.numOfPartitioinIN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.func2 = new System.Windows.Forms.RadioButton();
            this.func3 = new System.Windows.Forms.RadioButton();
            this.rectangeMethodArea = new System.Windows.Forms.Label();
            this.trapeziumMethodArea = new System.Windows.Forms.Label();
            this.simpsonMethodArea = new System.Windows.Forms.Label();
            this.ethaloneIntegralArea = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.functionGraph)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(362, 224);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "Інтегрувати";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.integrateButton);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(283, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ліва межа";
            // 
            // leftBorderIN
            // 
            this.leftBorderIN.Location = new System.Drawing.Point(362, 62);
            this.leftBorderIN.Name = "leftBorderIN";
            this.leftBorderIN.Size = new System.Drawing.Size(100, 22);
            this.leftBorderIN.TabIndex = 2;
            // 
            // func1
            // 
            this.func1.AutoSize = true;
            this.func1.Checked = true;
            this.func1.Location = new System.Drawing.Point(362, 146);
            this.func1.Name = "func1";
            this.func1.Size = new System.Drawing.Size(60, 20);
            this.func1.TabIndex = 3;
            this.func1.TabStop = true;
            this.func1.Text = "sin(x)";
            this.func1.UseVisualStyleBackColor = true;
            // 
            // functionGraph
            // 
            chartArea2.Name = "ChartArea1";
            this.functionGraph.ChartAreas.Add(chartArea2);
            this.functionGraph.Location = new System.Drawing.Point(509, 43);
            this.functionGraph.Name = "functionGraph";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Name = "Series1";
            this.functionGraph.Series.Add(series2);
            this.functionGraph.Size = new System.Drawing.Size(478, 438);
            this.functionGraph.TabIndex = 4;
            this.functionGraph.Text = "chart1";
            title2.Name = "Title1";
            title2.Text = "Графік Функції на Заданому Проміжку";
            this.functionGraph.Titles.Add(title2);
            // 
            // rightBorderIN
            // 
            this.rightBorderIN.Location = new System.Drawing.Point(362, 90);
            this.rightBorderIN.Name = "rightBorderIN";
            this.rightBorderIN.Size = new System.Drawing.Size(100, 22);
            this.rightBorderIN.TabIndex = 5;
            // 
            // numOfPartitioinIN
            // 
            this.numOfPartitioinIN.Location = new System.Drawing.Point(362, 118);
            this.numOfPartitioinIN.Name = "numOfPartitioinIN";
            this.numOfPartitioinIN.Size = new System.Drawing.Size(100, 22);
            this.numOfPartitioinIN.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(269, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Права межа";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(219, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Кількість Інтервалів";
            // 
            // func2
            // 
            this.func2.AutoSize = true;
            this.func2.Location = new System.Drawing.Point(362, 172);
            this.func2.Name = "func2";
            this.func2.Size = new System.Drawing.Size(76, 20);
            this.func2.TabIndex = 9;
            this.func2.Text = "sqrt(x)-1";
            this.func2.UseVisualStyleBackColor = true;
            // 
            // func3
            // 
            this.func3.AutoSize = true;
            this.func3.Location = new System.Drawing.Point(362, 198);
            this.func3.Name = "func3";
            this.func3.Size = new System.Drawing.Size(56, 20);
            this.func3.TabIndex = 10;
            this.func3.Text = "2x^3";
            this.func3.UseVisualStyleBackColor = true;
            // 
            // rectangeMethodArea
            // 
            this.rectangeMethodArea.AutoSize = true;
            this.rectangeMethodArea.Location = new System.Drawing.Point(52, 323);
            this.rectangeMethodArea.Name = "rectangeMethodArea";
            this.rectangeMethodArea.Size = new System.Drawing.Size(288, 16);
            this.rectangeMethodArea.TabIndex = 11;
            this.rectangeMethodArea.Text = "Площа Методом Середніх Прямокутників = ";
            // 
            // trapeziumMethodArea
            // 
            this.trapeziumMethodArea.AutoSize = true;
            this.trapeziumMethodArea.Location = new System.Drawing.Point(151, 353);
            this.trapeziumMethodArea.Name = "trapeziumMethodArea";
            this.trapeziumMethodArea.Size = new System.Drawing.Size(189, 16);
            this.trapeziumMethodArea.TabIndex = 12;
            this.trapeziumMethodArea.Text = "Площа Методом Трапецій = ";
            // 
            // simpsonMethodArea
            // 
            this.simpsonMethodArea.AutoSize = true;
            this.simpsonMethodArea.Location = new System.Drawing.Point(151, 381);
            this.simpsonMethodArea.Name = "simpsonMethodArea";
            this.simpsonMethodArea.Size = new System.Drawing.Size(189, 16);
            this.simpsonMethodArea.TabIndex = 13;
            this.simpsonMethodArea.Text = "Площа Методом Сімпсона = ";
            // 
            // ethaloneIntegralArea
            // 
            this.ethaloneIntegralArea.AutoSize = true;
            this.ethaloneIntegralArea.Location = new System.Drawing.Point(207, 408);
            this.ethaloneIntegralArea.Name = "ethaloneIntegralArea";
            this.ethaloneIntegralArea.Size = new System.Drawing.Size(133, 16);
            this.ethaloneIntegralArea.TabIndex = 14;
            this.ethaloneIntegralArea.Text = "Еталонна Площа = ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 545);
            this.Controls.Add(this.ethaloneIntegralArea);
            this.Controls.Add(this.simpsonMethodArea);
            this.Controls.Add(this.trapeziumMethodArea);
            this.Controls.Add(this.rectangeMethodArea);
            this.Controls.Add(this.func3);
            this.Controls.Add(this.func2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numOfPartitioinIN);
            this.Controls.Add(this.rightBorderIN);
            this.Controls.Add(this.functionGraph);
            this.Controls.Add(this.func1);
            this.Controls.Add(this.leftBorderIN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.functionGraph)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox leftBorderIN;
        private System.Windows.Forms.RadioButton func1;
        private System.Windows.Forms.DataVisualization.Charting.Chart functionGraph;
        private System.Windows.Forms.TextBox rightBorderIN;
        private System.Windows.Forms.TextBox numOfPartitioinIN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton func2;
        private System.Windows.Forms.RadioButton func3;
        private System.Windows.Forms.Label rectangeMethodArea;
        private System.Windows.Forms.Label trapeziumMethodArea;
        private System.Windows.Forms.Label simpsonMethodArea;
        private System.Windows.Forms.Label ethaloneIntegralArea;
    }
}

