
namespace Tyuiu.KoptyaevRS.Sprint6.Task5.V6
{
    partial class FormMain
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelUp_KRS = new System.Windows.Forms.Panel();
            this.panelLeft_KRS = new System.Windows.Forms.Panel();
            this.panelMid_KRS = new System.Windows.Forms.Panel();
            this.groupBoxCon_KRS = new System.Windows.Forms.GroupBox();
            this.textBoxCon_KRS = new System.Windows.Forms.TextBox();
            this.buttonDone_KRS = new System.Windows.Forms.Button();
            this.buttonOpen_KRS = new System.Windows.Forms.Button();
            this.buttonInfo_KRS = new System.Windows.Forms.Button();
            this.groupBoxResult_KRS = new System.Windows.Forms.GroupBox();
            this.dataGridViewNums_KRS = new System.Windows.Forms.DataGridView();
            this.chartResult_KRS = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelUp_KRS.SuspendLayout();
            this.panelLeft_KRS.SuspendLayout();
            this.panelMid_KRS.SuspendLayout();
            this.groupBoxCon_KRS.SuspendLayout();
            this.groupBoxResult_KRS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNums_KRS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartResult_KRS)).BeginInit();
            this.SuspendLayout();
            // 
            // panelUp_KRS
            // 
            this.panelUp_KRS.Controls.Add(this.buttonInfo_KRS);
            this.panelUp_KRS.Controls.Add(this.buttonOpen_KRS);
            this.panelUp_KRS.Controls.Add(this.buttonDone_KRS);
            this.panelUp_KRS.Controls.Add(this.groupBoxCon_KRS);
            this.panelUp_KRS.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUp_KRS.Location = new System.Drawing.Point(0, 0);
            this.panelUp_KRS.Name = "panelUp_KRS";
            this.panelUp_KRS.Size = new System.Drawing.Size(800, 101);
            this.panelUp_KRS.TabIndex = 0;
            // 
            // panelLeft_KRS
            // 
            this.panelLeft_KRS.Controls.Add(this.groupBoxResult_KRS);
            this.panelLeft_KRS.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft_KRS.Location = new System.Drawing.Point(0, 101);
            this.panelLeft_KRS.Name = "panelLeft_KRS";
            this.panelLeft_KRS.Size = new System.Drawing.Size(200, 349);
            this.panelLeft_KRS.TabIndex = 1;
            // 
            // panelMid_KRS
            // 
            this.panelMid_KRS.Controls.Add(this.chartResult_KRS);
            this.panelMid_KRS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMid_KRS.Location = new System.Drawing.Point(200, 101);
            this.panelMid_KRS.Name = "panelMid_KRS";
            this.panelMid_KRS.Size = new System.Drawing.Size(600, 349);
            this.panelMid_KRS.TabIndex = 2;
            // 
            // groupBoxCon_KRS
            // 
            this.groupBoxCon_KRS.Controls.Add(this.textBoxCon_KRS);
            this.groupBoxCon_KRS.Location = new System.Drawing.Point(4, 4);
            this.groupBoxCon_KRS.Name = "groupBoxCon_KRS";
            this.groupBoxCon_KRS.Size = new System.Drawing.Size(400, 100);
            this.groupBoxCon_KRS.TabIndex = 0;
            this.groupBoxCon_KRS.TabStop = false;
            this.groupBoxCon_KRS.Text = "Условие:";
            // 
            // textBoxCon_KRS
            // 
            this.textBoxCon_KRS.Location = new System.Drawing.Point(9, 20);
            this.textBoxCon_KRS.Multiline = true;
            this.textBoxCon_KRS.Name = "textBoxCon_KRS";
            this.textBoxCon_KRS.ReadOnly = true;
            this.textBoxCon_KRS.Size = new System.Drawing.Size(385, 71);
            this.textBoxCon_KRS.TabIndex = 0;
            this.textBoxCon_KRS.Text = "Прочитать данные из файла InPutFileTask5V6.txt. Вывести в dataGridView все числа," +
    " кратные 3. Построить диаграмму по этим значениям.";
            // 
            // buttonDone_KRS
            // 
            this.buttonDone_KRS.BackColor = System.Drawing.Color.LightGreen;
            this.buttonDone_KRS.Location = new System.Drawing.Point(411, 13);
            this.buttonDone_KRS.Name = "buttonDone_KRS";
            this.buttonDone_KRS.Size = new System.Drawing.Size(104, 82);
            this.buttonDone_KRS.TabIndex = 1;
            this.buttonDone_KRS.Text = "Выполнить";
            this.buttonDone_KRS.UseVisualStyleBackColor = false;
            this.buttonDone_KRS.Click += new System.EventHandler(this.buttonDone_KRS_Click);
            // 
            // buttonOpen_KRS
            // 
            this.buttonOpen_KRS.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonOpen_KRS.Location = new System.Drawing.Point(521, 13);
            this.buttonOpen_KRS.Name = "buttonOpen_KRS";
            this.buttonOpen_KRS.Size = new System.Drawing.Size(102, 82);
            this.buttonOpen_KRS.TabIndex = 2;
            this.buttonOpen_KRS.Text = "Открыть файл";
            this.buttonOpen_KRS.UseVisualStyleBackColor = false;
            this.buttonOpen_KRS.Click += new System.EventHandler(this.buttonOpen_KRS_Click);
            // 
            // buttonInfo_KRS
            // 
            this.buttonInfo_KRS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInfo_KRS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonInfo_KRS.Location = new System.Drawing.Point(690, 12);
            this.buttonInfo_KRS.Name = "buttonInfo_KRS";
            this.buttonInfo_KRS.Size = new System.Drawing.Size(98, 82);
            this.buttonInfo_KRS.TabIndex = 3;
            this.buttonInfo_KRS.Text = "Справка";
            this.buttonInfo_KRS.UseVisualStyleBackColor = false;
            this.buttonInfo_KRS.Click += new System.EventHandler(this.buttonInfo_KRS_Click);
            // 
            // groupBoxResult_KRS
            // 
            this.groupBoxResult_KRS.Controls.Add(this.dataGridViewNums_KRS);
            this.groupBoxResult_KRS.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxResult_KRS.Location = new System.Drawing.Point(0, 0);
            this.groupBoxResult_KRS.Name = "groupBoxResult_KRS";
            this.groupBoxResult_KRS.Size = new System.Drawing.Size(200, 349);
            this.groupBoxResult_KRS.TabIndex = 0;
            this.groupBoxResult_KRS.TabStop = false;
            this.groupBoxResult_KRS.Text = "Вывод данных:";
            // 
            // dataGridViewNums_KRS
            // 
            this.dataGridViewNums_KRS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNums_KRS.ColumnHeadersVisible = false;
            this.dataGridViewNums_KRS.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridViewNums_KRS.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewNums_KRS.Name = "dataGridViewNums_KRS";
            this.dataGridViewNums_KRS.RowHeadersVisible = false;
            this.dataGridViewNums_KRS.Size = new System.Drawing.Size(186, 330);
            this.dataGridViewNums_KRS.TabIndex = 0;
            // 
            // chartResult_KRS
            // 
            chartArea1.Name = "ChartArea1";
            this.chartResult_KRS.ChartAreas.Add(chartArea1);
            this.chartResult_KRS.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartResult_KRS.Legends.Add(legend1);
            this.chartResult_KRS.Location = new System.Drawing.Point(0, 0);
            this.chartResult_KRS.Name = "chartResult_KRS";
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartResult_KRS.Series.Add(series1);
            this.chartResult_KRS.Size = new System.Drawing.Size(600, 349);
            this.chartResult_KRS.TabIndex = 0;
            this.chartResult_KRS.Text = "chart1";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelMid_KRS);
            this.Controls.Add(this.panelLeft_KRS);
            this.Controls.Add(this.panelUp_KRS);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 5 | Вариант 6 | Коптяев Р. С.";
            this.panelUp_KRS.ResumeLayout(false);
            this.panelLeft_KRS.ResumeLayout(false);
            this.panelMid_KRS.ResumeLayout(false);
            this.groupBoxCon_KRS.ResumeLayout(false);
            this.groupBoxCon_KRS.PerformLayout();
            this.groupBoxResult_KRS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNums_KRS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartResult_KRS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelUp_KRS;
        private System.Windows.Forms.Button buttonInfo_KRS;
        private System.Windows.Forms.Button buttonOpen_KRS;
        private System.Windows.Forms.Button buttonDone_KRS;
        private System.Windows.Forms.GroupBox groupBoxCon_KRS;
        private System.Windows.Forms.TextBox textBoxCon_KRS;
        private System.Windows.Forms.Panel panelLeft_KRS;
        private System.Windows.Forms.GroupBox groupBoxResult_KRS;
        private System.Windows.Forms.DataGridView dataGridViewNums_KRS;
        private System.Windows.Forms.Panel panelMid_KRS;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartResult_KRS;
    }
}

