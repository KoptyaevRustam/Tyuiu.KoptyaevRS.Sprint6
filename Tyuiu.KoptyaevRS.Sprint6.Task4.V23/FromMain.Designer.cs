
namespace Tyuiu.KoptyaevRS.Sprint6.Task4.V23
{
    partial class FromMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FromMain));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.groupBoxConditional_KRS = new System.Windows.Forms.GroupBox();
            this.pictureBoxCondition_KRS = new System.Windows.Forms.PictureBox();
            this.textBoxConditional_KRS = new System.Windows.Forms.TextBox();
            this.groupBoxInput_KRS = new System.Windows.Forms.GroupBox();
            this.textBoxStart_KRS = new System.Windows.Forms.TextBox();
            this.textBoxFinish_KRS = new System.Windows.Forms.TextBox();
            this.labelStart_KRS = new System.Windows.Forms.Label();
            this.labelFinish_KRS = new System.Windows.Forms.Label();
            this.buttonDone_KRS = new System.Windows.Forms.Button();
            this.buttonSave_KRS = new System.Windows.Forms.Button();
            this.buttonInfo_KRS = new System.Windows.Forms.Button();
            this.groupBoxOutPut_KRS = new System.Windows.Forms.GroupBox();
            this.textBoxResult_KRS = new System.Windows.Forms.TextBox();
            this.chartFunction_KRS = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxConditional_KRS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCondition_KRS)).BeginInit();
            this.groupBoxInput_KRS.SuspendLayout();
            this.groupBoxOutPut_KRS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_KRS)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxConditional_KRS
            // 
            this.groupBoxConditional_KRS.Controls.Add(this.pictureBoxCondition_KRS);
            this.groupBoxConditional_KRS.Controls.Add(this.textBoxConditional_KRS);
            this.groupBoxConditional_KRS.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxConditional_KRS.Location = new System.Drawing.Point(0, 0);
            this.groupBoxConditional_KRS.Name = "groupBoxConditional_KRS";
            this.groupBoxConditional_KRS.Size = new System.Drawing.Size(1094, 146);
            this.groupBoxConditional_KRS.TabIndex = 0;
            this.groupBoxConditional_KRS.TabStop = false;
            this.groupBoxConditional_KRS.Text = "Условие";
            // 
            // pictureBoxCondition_KRS
            // 
            this.pictureBoxCondition_KRS.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCondition_KRS.Image")));
            this.pictureBoxCondition_KRS.Location = new System.Drawing.Point(7, 99);
            this.pictureBoxCondition_KRS.Name = "pictureBoxCondition_KRS";
            this.pictureBoxCondition_KRS.Size = new System.Drawing.Size(239, 41);
            this.pictureBoxCondition_KRS.TabIndex = 1;
            this.pictureBoxCondition_KRS.TabStop = false;
            // 
            // textBoxConditional_KRS
            // 
            this.textBoxConditional_KRS.Location = new System.Drawing.Point(1, 20);
            this.textBoxConditional_KRS.Multiline = true;
            this.textBoxConditional_KRS.Name = "textBoxConditional_KRS";
            this.textBoxConditional_KRS.ReadOnly = true;
            this.textBoxConditional_KRS.Size = new System.Drawing.Size(245, 73);
            this.textBoxConditional_KRS.TabIndex = 0;
            this.textBoxConditional_KRS.Text = "Протабулировать функцию на заданном диапазоне от -5 до 5. Результат вынести в tex" +
    "tBox. Построить график функции и сохранить в файл OutPutFileTask4V23.txt по нажа" +
    "тию кнопки.";
            // 
            // groupBoxInput_KRS
            // 
            this.groupBoxInput_KRS.Controls.Add(this.labelFinish_KRS);
            this.groupBoxInput_KRS.Controls.Add(this.labelStart_KRS);
            this.groupBoxInput_KRS.Controls.Add(this.textBoxFinish_KRS);
            this.groupBoxInput_KRS.Controls.Add(this.textBoxStart_KRS);
            this.groupBoxInput_KRS.Location = new System.Drawing.Point(270, 13);
            this.groupBoxInput_KRS.Name = "groupBoxInput_KRS";
            this.groupBoxInput_KRS.Size = new System.Drawing.Size(220, 146);
            this.groupBoxInput_KRS.TabIndex = 1;
            this.groupBoxInput_KRS.TabStop = false;
            this.groupBoxInput_KRS.Text = "Ввод данных";
            // 
            // textBoxStart_KRS
            // 
            this.textBoxStart_KRS.Location = new System.Drawing.Point(6, 34);
            this.textBoxStart_KRS.Name = "textBoxStart_KRS";
            this.textBoxStart_KRS.Size = new System.Drawing.Size(100, 20);
            this.textBoxStart_KRS.TabIndex = 0;
            this.textBoxStart_KRS.Text = "-5";
            // 
            // textBoxFinish_KRS
            // 
            this.textBoxFinish_KRS.Location = new System.Drawing.Point(112, 33);
            this.textBoxFinish_KRS.Name = "textBoxFinish_KRS";
            this.textBoxFinish_KRS.Size = new System.Drawing.Size(100, 20);
            this.textBoxFinish_KRS.TabIndex = 1;
            this.textBoxFinish_KRS.Text = "5";
            // 
            // labelStart_KRS
            // 
            this.labelStart_KRS.AutoSize = true;
            this.labelStart_KRS.Location = new System.Drawing.Point(7, 18);
            this.labelStart_KRS.Name = "labelStart_KRS";
            this.labelStart_KRS.Size = new System.Drawing.Size(67, 13);
            this.labelStart_KRS.TabIndex = 2;
            this.labelStart_KRS.Text = "Старт шага:";
            // 
            // labelFinish_KRS
            // 
            this.labelFinish_KRS.AutoSize = true;
            this.labelFinish_KRS.Location = new System.Drawing.Point(114, 17);
            this.labelFinish_KRS.Name = "labelFinish_KRS";
            this.labelFinish_KRS.Size = new System.Drawing.Size(69, 13);
            this.labelFinish_KRS.TabIndex = 3;
            this.labelFinish_KRS.Text = "Конец шага:";
            // 
            // buttonDone_KRS
            // 
            this.buttonDone_KRS.BackColor = System.Drawing.Color.Green;
            this.buttonDone_KRS.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonDone_KRS.Location = new System.Drawing.Point(497, 13);
            this.buttonDone_KRS.Name = "buttonDone_KRS";
            this.buttonDone_KRS.Size = new System.Drawing.Size(75, 53);
            this.buttonDone_KRS.TabIndex = 2;
            this.buttonDone_KRS.Text = "Выполнить";
            this.buttonDone_KRS.UseVisualStyleBackColor = false;
            this.buttonDone_KRS.Click += new System.EventHandler(this.buttonDone_KRS_Click);
            // 
            // buttonSave_KRS
            // 
            this.buttonSave_KRS.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonSave_KRS.Location = new System.Drawing.Point(579, 13);
            this.buttonSave_KRS.Name = "buttonSave_KRS";
            this.buttonSave_KRS.Size = new System.Drawing.Size(75, 53);
            this.buttonSave_KRS.TabIndex = 3;
            this.buttonSave_KRS.Text = "Сохранить";
            this.buttonSave_KRS.UseVisualStyleBackColor = false;
            this.buttonSave_KRS.Click += new System.EventHandler(this.buttonSave_KRS_Click);
            // 
            // buttonInfo_KRS
            // 
            this.buttonInfo_KRS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInfo_KRS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonInfo_KRS.Location = new System.Drawing.Point(1012, 13);
            this.buttonInfo_KRS.Name = "buttonInfo_KRS";
            this.buttonInfo_KRS.Size = new System.Drawing.Size(75, 54);
            this.buttonInfo_KRS.TabIndex = 4;
            this.buttonInfo_KRS.Text = "Справка";
            this.buttonInfo_KRS.UseVisualStyleBackColor = false;
            this.buttonInfo_KRS.Click += new System.EventHandler(this.buttonInfo_KRS_Click);
            // 
            // groupBoxOutPut_KRS
            // 
            this.groupBoxOutPut_KRS.Controls.Add(this.textBoxResult_KRS);
            this.groupBoxOutPut_KRS.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxOutPut_KRS.Location = new System.Drawing.Point(0, 146);
            this.groupBoxOutPut_KRS.Name = "groupBoxOutPut_KRS";
            this.groupBoxOutPut_KRS.Size = new System.Drawing.Size(200, 415);
            this.groupBoxOutPut_KRS.TabIndex = 5;
            this.groupBoxOutPut_KRS.TabStop = false;
            this.groupBoxOutPut_KRS.Text = "Вывод";
            // 
            // textBoxResult_KRS
            // 
            this.textBoxResult_KRS.Location = new System.Drawing.Point(7, 20);
            this.textBoxResult_KRS.Multiline = true;
            this.textBoxResult_KRS.Name = "textBoxResult_KRS";
            this.textBoxResult_KRS.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult_KRS.Size = new System.Drawing.Size(187, 318);
            this.textBoxResult_KRS.TabIndex = 0;
            // 
            // chartFunction_KRS
            // 
            chartArea1.Name = "ChartArea1";
            this.chartFunction_KRS.ChartAreas.Add(chartArea1);
            this.chartFunction_KRS.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartFunction_KRS.Legends.Add(legend1);
            this.chartFunction_KRS.Location = new System.Drawing.Point(200, 146);
            this.chartFunction_KRS.Name = "chartFunction_KRS";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartFunction_KRS.Series.Add(series1);
            this.chartFunction_KRS.Size = new System.Drawing.Size(894, 415);
            this.chartFunction_KRS.TabIndex = 6;
            this.chartFunction_KRS.Text = "chartFunction";
            title1.BackColor = System.Drawing.Color.White;
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title1.ForeColor = System.Drawing.Color.CornflowerBlue;
            title1.Name = "Title1";
            title1.Text = "График функции";
            this.chartFunction_KRS.Titles.Add(title1);
            // 
            // FromMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 561);
            this.Controls.Add(this.chartFunction_KRS);
            this.Controls.Add(this.groupBoxOutPut_KRS);
            this.Controls.Add(this.buttonInfo_KRS);
            this.Controls.Add(this.buttonSave_KRS);
            this.Controls.Add(this.buttonDone_KRS);
            this.Controls.Add(this.groupBoxInput_KRS);
            this.Controls.Add(this.groupBoxConditional_KRS);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "FromMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 4 | Вариант 23 | Коптяев Р. С.";
            this.groupBoxConditional_KRS.ResumeLayout(false);
            this.groupBoxConditional_KRS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCondition_KRS)).EndInit();
            this.groupBoxInput_KRS.ResumeLayout(false);
            this.groupBoxInput_KRS.PerformLayout();
            this.groupBoxOutPut_KRS.ResumeLayout(false);
            this.groupBoxOutPut_KRS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_KRS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxConditional_KRS;
        private System.Windows.Forms.PictureBox pictureBoxCondition_KRS;
        private System.Windows.Forms.TextBox textBoxConditional_KRS;
        private System.Windows.Forms.GroupBox groupBoxInput_KRS;
        private System.Windows.Forms.Label labelFinish_KRS;
        private System.Windows.Forms.Label labelStart_KRS;
        private System.Windows.Forms.TextBox textBoxFinish_KRS;
        private System.Windows.Forms.TextBox textBoxStart_KRS;
        private System.Windows.Forms.Button buttonDone_KRS;
        private System.Windows.Forms.Button buttonSave_KRS;
        private System.Windows.Forms.Button buttonInfo_KRS;
        private System.Windows.Forms.GroupBox groupBoxOutPut_KRS;
        private System.Windows.Forms.TextBox textBoxResult_KRS;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_KRS;
    }
}

