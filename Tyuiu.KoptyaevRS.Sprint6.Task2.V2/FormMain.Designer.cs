
namespace Tyuiu.KoptyaevRS.Sprint6.Task2.V2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxCon_KRS = new System.Windows.Forms.GroupBox();
            this.pictureBoxFormula_KRS = new System.Windows.Forms.PictureBox();
            this.textBoxCon_KRS = new System.Windows.Forms.TextBox();
            this.groupBoxInput_KRS = new System.Windows.Forms.GroupBox();
            this.labelStop_KRS = new System.Windows.Forms.Label();
            this.labelStart_KRS = new System.Windows.Forms.Label();
            this.textBoxStop_KRS = new System.Windows.Forms.TextBox();
            this.textBoxStart_KRS = new System.Windows.Forms.TextBox();
            this.buttonInfo_KRS = new System.Windows.Forms.Button();
            this.buttonDoen_KRS = new System.Windows.Forms.Button();
            this.groupBoxOutput_KRS = new System.Windows.Forms.GroupBox();
            this.chartFunction_KRS = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridViewFunction_KRS = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxOut_KRS = new System.Windows.Forms.TextBox();
            this.groupBoxCon_KRS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_KRS)).BeginInit();
            this.groupBoxInput_KRS.SuspendLayout();
            this.groupBoxOutput_KRS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_KRS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction_KRS)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxCon_KRS
            // 
            this.groupBoxCon_KRS.Controls.Add(this.pictureBoxFormula_KRS);
            this.groupBoxCon_KRS.Controls.Add(this.textBoxCon_KRS);
            this.groupBoxCon_KRS.Location = new System.Drawing.Point(13, 13);
            this.groupBoxCon_KRS.Name = "groupBoxCon_KRS";
            this.groupBoxCon_KRS.Size = new System.Drawing.Size(469, 228);
            this.groupBoxCon_KRS.TabIndex = 0;
            this.groupBoxCon_KRS.TabStop = false;
            this.groupBoxCon_KRS.Text = "Условие";
            // 
            // pictureBoxFormula_KRS
            // 
            this.pictureBoxFormula_KRS.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFormula_KRS.Image")));
            this.pictureBoxFormula_KRS.Location = new System.Drawing.Point(7, 169);
            this.pictureBoxFormula_KRS.Name = "pictureBoxFormula_KRS";
            this.pictureBoxFormula_KRS.Size = new System.Drawing.Size(457, 53);
            this.pictureBoxFormula_KRS.TabIndex = 1;
            this.pictureBoxFormula_KRS.TabStop = false;
            // 
            // textBoxCon_KRS
            // 
            this.textBoxCon_KRS.Location = new System.Drawing.Point(6, 19);
            this.textBoxCon_KRS.Multiline = true;
            this.textBoxCon_KRS.Name = "textBoxCon_KRS";
            this.textBoxCon_KRS.ReadOnly = true;
            this.textBoxCon_KRS.Size = new System.Drawing.Size(457, 144);
            this.textBoxCon_KRS.TabIndex = 0;
            this.textBoxCon_KRS.Text = "Протабулировать функцию на заданном диапазоне.\r\nРезультат вывести в DataGridView " +
    "и построить график функции.";
            // 
            // groupBoxInput_KRS
            // 
            this.groupBoxInput_KRS.Controls.Add(this.labelStop_KRS);
            this.groupBoxInput_KRS.Controls.Add(this.labelStart_KRS);
            this.groupBoxInput_KRS.Controls.Add(this.textBoxStop_KRS);
            this.groupBoxInput_KRS.Controls.Add(this.textBoxStart_KRS);
            this.groupBoxInput_KRS.Location = new System.Drawing.Point(13, 247);
            this.groupBoxInput_KRS.Name = "groupBoxInput_KRS";
            this.groupBoxInput_KRS.Size = new System.Drawing.Size(224, 71);
            this.groupBoxInput_KRS.TabIndex = 1;
            this.groupBoxInput_KRS.TabStop = false;
            this.groupBoxInput_KRS.Text = "Ввод данных";
            // 
            // labelStop_KRS
            // 
            this.labelStop_KRS.AutoSize = true;
            this.labelStop_KRS.Location = new System.Drawing.Point(114, 20);
            this.labelStop_KRS.Name = "labelStop_KRS";
            this.labelStop_KRS.Size = new System.Drawing.Size(69, 13);
            this.labelStop_KRS.TabIndex = 3;
            this.labelStop_KRS.Text = "Конец шага:";
            // 
            // labelStart_KRS
            // 
            this.labelStart_KRS.AutoSize = true;
            this.labelStart_KRS.Location = new System.Drawing.Point(7, 20);
            this.labelStart_KRS.Name = "labelStart_KRS";
            this.labelStart_KRS.Size = new System.Drawing.Size(67, 13);
            this.labelStart_KRS.TabIndex = 2;
            this.labelStart_KRS.Text = "Старт шага:";
            // 
            // textBoxStop_KRS
            // 
            this.textBoxStop_KRS.Location = new System.Drawing.Point(114, 39);
            this.textBoxStop_KRS.Name = "textBoxStop_KRS";
            this.textBoxStop_KRS.Size = new System.Drawing.Size(100, 20);
            this.textBoxStop_KRS.TabIndex = 1;
            this.textBoxStop_KRS.Text = "5";
            // 
            // textBoxStart_KRS
            // 
            this.textBoxStart_KRS.Location = new System.Drawing.Point(7, 39);
            this.textBoxStart_KRS.Name = "textBoxStart_KRS";
            this.textBoxStart_KRS.Size = new System.Drawing.Size(100, 20);
            this.textBoxStart_KRS.TabIndex = 0;
            this.textBoxStart_KRS.Text = "-5";
            // 
            // buttonInfo_KRS
            // 
            this.buttonInfo_KRS.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonInfo_KRS.Location = new System.Drawing.Point(244, 247);
            this.buttonInfo_KRS.Name = "buttonInfo_KRS";
            this.buttonInfo_KRS.Size = new System.Drawing.Size(80, 71);
            this.buttonInfo_KRS.TabIndex = 2;
            this.buttonInfo_KRS.Text = "Справка";
            this.buttonInfo_KRS.UseVisualStyleBackColor = false;
            this.buttonInfo_KRS.Click += new System.EventHandler(this.buttonInfo_KRS_Click);
            // 
            // buttonDoen_KRS
            // 
            this.buttonDoen_KRS.BackColor = System.Drawing.Color.Green;
            this.buttonDoen_KRS.Location = new System.Drawing.Point(330, 247);
            this.buttonDoen_KRS.Name = "buttonDoen_KRS";
            this.buttonDoen_KRS.Size = new System.Drawing.Size(141, 71);
            this.buttonDoen_KRS.TabIndex = 3;
            this.buttonDoen_KRS.Text = "Выполнить";
            this.buttonDoen_KRS.UseVisualStyleBackColor = false;
            this.buttonDoen_KRS.Click += new System.EventHandler(this.buttonDoen_KRS_Click);
            this.buttonDoen_KRS.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonDoen_KRS_MouseDown);
            this.buttonDoen_KRS.MouseEnter += new System.EventHandler(this.buttonDoen_KRS_MouseEnter);
            this.buttonDoen_KRS.MouseLeave += new System.EventHandler(this.buttonDoen_KRS_MouseLeave);
            // 
            // groupBoxOutput_KRS
            // 
            this.groupBoxOutput_KRS.Controls.Add(this.chartFunction_KRS);
            this.groupBoxOutput_KRS.Controls.Add(this.dataGridViewFunction_KRS);
            this.groupBoxOutput_KRS.Controls.Add(this.textBoxOut_KRS);
            this.groupBoxOutput_KRS.Location = new System.Drawing.Point(504, 13);
            this.groupBoxOutput_KRS.Name = "groupBoxOutput_KRS";
            this.groupBoxOutput_KRS.Size = new System.Drawing.Size(570, 305);
            this.groupBoxOutput_KRS.TabIndex = 4;
            this.groupBoxOutput_KRS.TabStop = false;
            this.groupBoxOutput_KRS.Text = "Вывод данных";
            // 
            // chartFunction_KRS
            // 
            chartArea5.Name = "ChartArea1";
            this.chartFunction_KRS.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chartFunction_KRS.Legends.Add(legend5);
            this.chartFunction_KRS.Location = new System.Drawing.Point(127, 46);
            this.chartFunction_KRS.Name = "chartFunction_KRS";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series5.IsVisibleInLegend = false;
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chartFunction_KRS.Series.Add(series5);
            this.chartFunction_KRS.Size = new System.Drawing.Size(437, 253);
            this.chartFunction_KRS.TabIndex = 2;
            this.chartFunction_KRS.Text = "chart1";
            // 
            // dataGridViewFunction_KRS
            // 
            this.dataGridViewFunction_KRS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFunction_KRS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridViewFunction_KRS.Location = new System.Drawing.Point(7, 46);
            this.dataGridViewFunction_KRS.Name = "dataGridViewFunction_KRS";
            this.dataGridViewFunction_KRS.RowHeadersVisible = false;
            this.dataGridViewFunction_KRS.Size = new System.Drawing.Size(114, 253);
            this.dataGridViewFunction_KRS.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "X";
            this.Column1.Name = "Column1";
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "F(x)";
            this.Column2.Name = "Column2";
            this.Column2.Width = 50;
            // 
            // textBoxOut_KRS
            // 
            this.textBoxOut_KRS.Location = new System.Drawing.Point(7, 20);
            this.textBoxOut_KRS.Name = "textBoxOut_KRS";
            this.textBoxOut_KRS.ReadOnly = true;
            this.textBoxOut_KRS.Size = new System.Drawing.Size(75, 20);
            this.textBoxOut_KRS.TabIndex = 0;
            this.textBoxOut_KRS.Text = "Результат:";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 363);
            this.Controls.Add(this.groupBoxOutput_KRS);
            this.Controls.Add(this.buttonDoen_KRS);
            this.Controls.Add(this.buttonInfo_KRS);
            this.Controls.Add(this.groupBoxInput_KRS);
            this.Controls.Add(this.groupBoxCon_KRS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 2| Вариант 2 | Коптяев Р. С.";
            this.groupBoxCon_KRS.ResumeLayout(false);
            this.groupBoxCon_KRS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_KRS)).EndInit();
            this.groupBoxInput_KRS.ResumeLayout(false);
            this.groupBoxInput_KRS.PerformLayout();
            this.groupBoxOutput_KRS.ResumeLayout(false);
            this.groupBoxOutput_KRS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_KRS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction_KRS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCon_KRS;
        private System.Windows.Forms.PictureBox pictureBoxFormula_KRS;
        private System.Windows.Forms.TextBox textBoxCon_KRS;
        private System.Windows.Forms.GroupBox groupBoxInput_KRS;
        private System.Windows.Forms.Label labelStop_KRS;
        private System.Windows.Forms.Label labelStart_KRS;
        private System.Windows.Forms.TextBox textBoxStop_KRS;
        private System.Windows.Forms.TextBox textBoxStart_KRS;
        private System.Windows.Forms.Button buttonInfo_KRS;
        private System.Windows.Forms.Button buttonDoen_KRS;
        private System.Windows.Forms.GroupBox groupBoxOutput_KRS;
        private System.Windows.Forms.DataGridView dataGridViewFunction_KRS;
        private System.Windows.Forms.TextBox textBoxOut_KRS;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_KRS;
    }
}

