
namespace Tyuiu.KoptyaevRS.Sprint6.TaskReview.V30
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelUp_KRS = new System.Windows.Forms.Panel();
            this.panelLeft_KRS = new System.Windows.Forms.Panel();
            this.panelRight_KRS = new System.Windows.Forms.Panel();
            this.groupBoxCon_KRS = new System.Windows.Forms.GroupBox();
            this.textBoxCon_KRS = new System.Windows.Forms.TextBox();
            this.buttonDone_KRS = new System.Windows.Forms.Button();
            this.buttonInfo_KRS = new System.Windows.Forms.Button();
            this.groupBoxInPut_KRS = new System.Windows.Forms.GroupBox();
            this.textBoxStart_KRS = new System.Windows.Forms.TextBox();
            this.labelStart_KRS = new System.Windows.Forms.Label();
            this.textBoxStop_KRS = new System.Windows.Forms.TextBox();
            this.labelStop_KRS = new System.Windows.Forms.Label();
            this.textBoxRow_KRS = new System.Windows.Forms.TextBox();
            this.textBoxColumn_KRS = new System.Windows.Forms.TextBox();
            this.labelRow_KRS = new System.Windows.Forms.Label();
            this.labelColumn_KRS = new System.Windows.Forms.Label();
            this.textBoxStartEl_KRS = new System.Windows.Forms.TextBox();
            this.textBoxStopEl_KRS = new System.Windows.Forms.TextBox();
            this.labelStartEl_KRS = new System.Windows.Forms.Label();
            this.labelStopEl_KRS = new System.Windows.Forms.Label();
            this.textBoxNumRow_KRS = new System.Windows.Forms.TextBox();
            this.labelNumRow_KRS = new System.Windows.Forms.Label();
            this.groupBoxOutPut_KRS = new System.Windows.Forms.GroupBox();
            this.dataGridViewMatrix_KRS = new System.Windows.Forms.DataGridView();
            this.textBoxResult_KRS = new System.Windows.Forms.TextBox();
            this.labelResult_KRS = new System.Windows.Forms.Label();
            this.toolTipButton_KRS = new System.Windows.Forms.ToolTip(this.components);
            this.panelUp_KRS.SuspendLayout();
            this.panelLeft_KRS.SuspendLayout();
            this.panelRight_KRS.SuspendLayout();
            this.groupBoxCon_KRS.SuspendLayout();
            this.groupBoxInPut_KRS.SuspendLayout();
            this.groupBoxOutPut_KRS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix_KRS)).BeginInit();
            this.SuspendLayout();
            // 
            // panelUp_KRS
            // 
            this.panelUp_KRS.Controls.Add(this.buttonInfo_KRS);
            this.panelUp_KRS.Controls.Add(this.buttonDone_KRS);
            this.panelUp_KRS.Controls.Add(this.groupBoxCon_KRS);
            this.panelUp_KRS.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUp_KRS.Location = new System.Drawing.Point(0, 0);
            this.panelUp_KRS.Name = "panelUp_KRS";
            this.panelUp_KRS.Size = new System.Drawing.Size(760, 170);
            this.panelUp_KRS.TabIndex = 0;
            // 
            // panelLeft_KRS
            // 
            this.panelLeft_KRS.Controls.Add(this.groupBoxOutPut_KRS);
            this.panelLeft_KRS.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft_KRS.Location = new System.Drawing.Point(0, 170);
            this.panelLeft_KRS.Name = "panelLeft_KRS";
            this.panelLeft_KRS.Size = new System.Drawing.Size(417, 280);
            this.panelLeft_KRS.TabIndex = 1;
            // 
            // panelRight_KRS
            // 
            this.panelRight_KRS.Controls.Add(this.groupBoxInPut_KRS);
            this.panelRight_KRS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight_KRS.Location = new System.Drawing.Point(417, 170);
            this.panelRight_KRS.Name = "panelRight_KRS";
            this.panelRight_KRS.Size = new System.Drawing.Size(343, 280);
            this.panelRight_KRS.TabIndex = 2;
            // 
            // groupBoxCon_KRS
            // 
            this.groupBoxCon_KRS.Controls.Add(this.textBoxCon_KRS);
            this.groupBoxCon_KRS.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxCon_KRS.Location = new System.Drawing.Point(0, 0);
            this.groupBoxCon_KRS.Name = "groupBoxCon_KRS";
            this.groupBoxCon_KRS.Size = new System.Drawing.Size(458, 170);
            this.groupBoxCon_KRS.TabIndex = 0;
            this.groupBoxCon_KRS.TabStop = false;
            this.groupBoxCon_KRS.Text = "Условие:";
            // 
            // textBoxCon_KRS
            // 
            this.textBoxCon_KRS.Location = new System.Drawing.Point(7, 20);
            this.textBoxCon_KRS.Multiline = true;
            this.textBoxCon_KRS.Name = "textBoxCon_KRS";
            this.textBoxCon_KRS.ReadOnly = true;
            this.textBoxCon_KRS.Size = new System.Drawing.Size(445, 144);
            this.textBoxCon_KRS.TabIndex = 0;
            this.textBoxCon_KRS.Text = resources.GetString("textBoxCon_KRS.Text");
            // 
            // buttonDone_KRS
            // 
            this.buttonDone_KRS.Image = ((System.Drawing.Image)(resources.GetObject("buttonDone_KRS.Image")));
            this.buttonDone_KRS.Location = new System.Drawing.Point(464, 20);
            this.buttonDone_KRS.Name = "buttonDone_KRS";
            this.buttonDone_KRS.Size = new System.Drawing.Size(77, 75);
            this.buttonDone_KRS.TabIndex = 1;
            this.toolTipButton_KRS.SetToolTip(this.buttonDone_KRS, "Выполнить обработку данных");
            this.buttonDone_KRS.UseVisualStyleBackColor = true;
            this.buttonDone_KRS.Click += new System.EventHandler(this.buttonDone_KRS_Click);
            this.buttonDone_KRS.MouseEnter += new System.EventHandler(this.buttonDone_KRS_MouseEnter);
            // 
            // buttonInfo_KRS
            // 
            this.buttonInfo_KRS.Image = ((System.Drawing.Image)(resources.GetObject("buttonInfo_KRS.Image")));
            this.buttonInfo_KRS.Location = new System.Drawing.Point(547, 20);
            this.buttonInfo_KRS.Name = "buttonInfo_KRS";
            this.buttonInfo_KRS.Size = new System.Drawing.Size(77, 75);
            this.buttonInfo_KRS.TabIndex = 2;
            this.toolTipButton_KRS.SetToolTip(this.buttonInfo_KRS, "Сведения о программе");
            this.buttonInfo_KRS.UseVisualStyleBackColor = true;
            this.buttonInfo_KRS.Click += new System.EventHandler(this.buttonInfo_KRS_Click);
            this.buttonInfo_KRS.MouseEnter += new System.EventHandler(this.buttonInfo_KRS_MouseEnter);
            // 
            // groupBoxInPut_KRS
            // 
            this.groupBoxInPut_KRS.Controls.Add(this.labelNumRow_KRS);
            this.groupBoxInPut_KRS.Controls.Add(this.textBoxNumRow_KRS);
            this.groupBoxInPut_KRS.Controls.Add(this.labelStopEl_KRS);
            this.groupBoxInPut_KRS.Controls.Add(this.labelStartEl_KRS);
            this.groupBoxInPut_KRS.Controls.Add(this.textBoxStopEl_KRS);
            this.groupBoxInPut_KRS.Controls.Add(this.textBoxStartEl_KRS);
            this.groupBoxInPut_KRS.Controls.Add(this.labelColumn_KRS);
            this.groupBoxInPut_KRS.Controls.Add(this.labelRow_KRS);
            this.groupBoxInPut_KRS.Controls.Add(this.textBoxColumn_KRS);
            this.groupBoxInPut_KRS.Controls.Add(this.textBoxRow_KRS);
            this.groupBoxInPut_KRS.Controls.Add(this.labelStop_KRS);
            this.groupBoxInPut_KRS.Controls.Add(this.textBoxStop_KRS);
            this.groupBoxInPut_KRS.Controls.Add(this.labelStart_KRS);
            this.groupBoxInPut_KRS.Controls.Add(this.textBoxStart_KRS);
            this.groupBoxInPut_KRS.Location = new System.Drawing.Point(7, 7);
            this.groupBoxInPut_KRS.Name = "groupBoxInPut_KRS";
            this.groupBoxInPut_KRS.Size = new System.Drawing.Size(373, 270);
            this.groupBoxInPut_KRS.TabIndex = 0;
            this.groupBoxInPut_KRS.TabStop = false;
            this.groupBoxInPut_KRS.Text = "Ввод данных:";
            // 
            // textBoxStart_KRS
            // 
            this.textBoxStart_KRS.Location = new System.Drawing.Point(188, 38);
            this.textBoxStart_KRS.Name = "textBoxStart_KRS";
            this.textBoxStart_KRS.Size = new System.Drawing.Size(110, 20);
            this.textBoxStart_KRS.TabIndex = 0;
            // 
            // labelStart_KRS
            // 
            this.labelStart_KRS.AutoSize = true;
            this.labelStart_KRS.Location = new System.Drawing.Point(185, 22);
            this.labelStart_KRS.Name = "labelStart_KRS";
            this.labelStart_KRS.Size = new System.Drawing.Size(104, 13);
            this.labelStart_KRS.TabIndex = 1;
            this.labelStart_KRS.Text = "Начало диапазона:";
            // 
            // textBoxStop_KRS
            // 
            this.textBoxStop_KRS.Location = new System.Drawing.Point(188, 86);
            this.textBoxStop_KRS.Name = "textBoxStop_KRS";
            this.textBoxStop_KRS.Size = new System.Drawing.Size(110, 20);
            this.textBoxStop_KRS.TabIndex = 2;
            // 
            // labelStop_KRS
            // 
            this.labelStop_KRS.AutoSize = true;
            this.labelStop_KRS.Location = new System.Drawing.Point(185, 70);
            this.labelStop_KRS.Name = "labelStop_KRS";
            this.labelStop_KRS.Size = new System.Drawing.Size(98, 13);
            this.labelStop_KRS.TabIndex = 3;
            this.labelStop_KRS.Text = "Конец диапазона:";
            // 
            // textBoxRow_KRS
            // 
            this.textBoxRow_KRS.Location = new System.Drawing.Point(6, 38);
            this.textBoxRow_KRS.Name = "textBoxRow_KRS";
            this.textBoxRow_KRS.Size = new System.Drawing.Size(110, 20);
            this.textBoxRow_KRS.TabIndex = 4;
            // 
            // textBoxColumn_KRS
            // 
            this.textBoxColumn_KRS.Location = new System.Drawing.Point(6, 86);
            this.textBoxColumn_KRS.Name = "textBoxColumn_KRS";
            this.textBoxColumn_KRS.Size = new System.Drawing.Size(110, 20);
            this.textBoxColumn_KRS.TabIndex = 5;
            // 
            // labelRow_KRS
            // 
            this.labelRow_KRS.AutoSize = true;
            this.labelRow_KRS.Location = new System.Drawing.Point(7, 22);
            this.labelRow_KRS.Name = "labelRow_KRS";
            this.labelRow_KRS.Size = new System.Drawing.Size(101, 13);
            this.labelRow_KRS.TabIndex = 6;
            this.labelRow_KRS.Text = "Количество строк:";
            // 
            // labelColumn_KRS
            // 
            this.labelColumn_KRS.AutoSize = true;
            this.labelColumn_KRS.Location = new System.Drawing.Point(7, 70);
            this.labelColumn_KRS.Name = "labelColumn_KRS";
            this.labelColumn_KRS.Size = new System.Drawing.Size(119, 13);
            this.labelColumn_KRS.TabIndex = 7;
            this.labelColumn_KRS.Text = "Количество столбцов:";
            // 
            // textBoxStartEl_KRS
            // 
            this.textBoxStartEl_KRS.Location = new System.Drawing.Point(6, 131);
            this.textBoxStartEl_KRS.Name = "textBoxStartEl_KRS";
            this.textBoxStartEl_KRS.Size = new System.Drawing.Size(110, 20);
            this.textBoxStartEl_KRS.TabIndex = 8;
            // 
            // textBoxStopEl_KRS
            // 
            this.textBoxStopEl_KRS.Location = new System.Drawing.Point(6, 172);
            this.textBoxStopEl_KRS.Name = "textBoxStopEl_KRS";
            this.textBoxStopEl_KRS.Size = new System.Drawing.Size(110, 20);
            this.textBoxStopEl_KRS.TabIndex = 9;
            // 
            // labelStartEl_KRS
            // 
            this.labelStartEl_KRS.AutoSize = true;
            this.labelStartEl_KRS.Location = new System.Drawing.Point(7, 115);
            this.labelStartEl_KRS.Name = "labelStartEl_KRS";
            this.labelStartEl_KRS.Size = new System.Drawing.Size(204, 13);
            this.labelStartEl_KRS.TabIndex = 10;
            this.labelStartEl_KRS.Text = "Номер начального элемента массива:";
            // 
            // labelStopEl_KRS
            // 
            this.labelStopEl_KRS.AutoSize = true;
            this.labelStopEl_KRS.Location = new System.Drawing.Point(7, 156);
            this.labelStopEl_KRS.Name = "labelStopEl_KRS";
            this.labelStopEl_KRS.Size = new System.Drawing.Size(198, 13);
            this.labelStopEl_KRS.TabIndex = 11;
            this.labelStopEl_KRS.Text = "Номер конечного элемента массива:";
            // 
            // textBoxNumRow_KRS
            // 
            this.textBoxNumRow_KRS.Location = new System.Drawing.Point(6, 217);
            this.textBoxNumRow_KRS.Name = "textBoxNumRow_KRS";
            this.textBoxNumRow_KRS.Size = new System.Drawing.Size(110, 20);
            this.textBoxNumRow_KRS.TabIndex = 12;
            // 
            // labelNumRow_KRS
            // 
            this.labelNumRow_KRS.AutoSize = true;
            this.labelNumRow_KRS.Location = new System.Drawing.Point(7, 199);
            this.labelNumRow_KRS.Name = "labelNumRow_KRS";
            this.labelNumRow_KRS.Size = new System.Drawing.Size(89, 13);
            this.labelNumRow_KRS.TabIndex = 13;
            this.labelNumRow_KRS.Text = "Задайте строку:";
            // 
            // groupBoxOutPut_KRS
            // 
            this.groupBoxOutPut_KRS.Controls.Add(this.labelResult_KRS);
            this.groupBoxOutPut_KRS.Controls.Add(this.textBoxResult_KRS);
            this.groupBoxOutPut_KRS.Controls.Add(this.dataGridViewMatrix_KRS);
            this.groupBoxOutPut_KRS.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxOutPut_KRS.Location = new System.Drawing.Point(0, 0);
            this.groupBoxOutPut_KRS.Name = "groupBoxOutPut_KRS";
            this.groupBoxOutPut_KRS.Size = new System.Drawing.Size(411, 280);
            this.groupBoxOutPut_KRS.TabIndex = 0;
            this.groupBoxOutPut_KRS.TabStop = false;
            this.groupBoxOutPut_KRS.Text = "Вывод данных:";
            // 
            // dataGridViewMatrix_KRS
            // 
            this.dataGridViewMatrix_KRS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatrix_KRS.ColumnHeadersVisible = false;
            this.dataGridViewMatrix_KRS.Location = new System.Drawing.Point(7, 20);
            this.dataGridViewMatrix_KRS.Name = "dataGridViewMatrix_KRS";
            this.dataGridViewMatrix_KRS.RowHeadersVisible = false;
            this.dataGridViewMatrix_KRS.Size = new System.Drawing.Size(398, 199);
            this.dataGridViewMatrix_KRS.TabIndex = 0;
            // 
            // textBoxResult_KRS
            // 
            this.textBoxResult_KRS.Location = new System.Drawing.Point(13, 248);
            this.textBoxResult_KRS.Name = "textBoxResult_KRS";
            this.textBoxResult_KRS.ReadOnly = true;
            this.textBoxResult_KRS.Size = new System.Drawing.Size(142, 20);
            this.textBoxResult_KRS.TabIndex = 1;
            // 
            // labelResult_KRS
            // 
            this.labelResult_KRS.AutoSize = true;
            this.labelResult_KRS.Location = new System.Drawing.Point(13, 230);
            this.labelResult_KRS.Name = "labelResult_KRS";
            this.labelResult_KRS.Size = new System.Drawing.Size(142, 13);
            this.labelResult_KRS.TabIndex = 2;
            this.labelResult_KRS.Text = "Среднее арифметическое:";
            // 
            // toolTipButton_KRS
            // 
            this.toolTipButton_KRS.ForeColor = System.Drawing.SystemColors.Highlight;
            this.toolTipButton_KRS.IsBalloon = true;
            this.toolTipButton_KRS.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipButton_KRS.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 450);
            this.Controls.Add(this.panelRight_KRS);
            this.Controls.Add(this.panelLeft_KRS);
            this.Controls.Add(this.panelUp_KRS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(776, 489);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | СпринтРевью | Вариант 30 | Коптяев Р. С.";
            this.panelUp_KRS.ResumeLayout(false);
            this.panelLeft_KRS.ResumeLayout(false);
            this.panelRight_KRS.ResumeLayout(false);
            this.groupBoxCon_KRS.ResumeLayout(false);
            this.groupBoxCon_KRS.PerformLayout();
            this.groupBoxInPut_KRS.ResumeLayout(false);
            this.groupBoxInPut_KRS.PerformLayout();
            this.groupBoxOutPut_KRS.ResumeLayout(false);
            this.groupBoxOutPut_KRS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix_KRS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelUp_KRS;
        private System.Windows.Forms.Button buttonInfo_KRS;
        private System.Windows.Forms.Button buttonDone_KRS;
        private System.Windows.Forms.GroupBox groupBoxCon_KRS;
        private System.Windows.Forms.TextBox textBoxCon_KRS;
        private System.Windows.Forms.Panel panelLeft_KRS;
        private System.Windows.Forms.Panel panelRight_KRS;
        private System.Windows.Forms.GroupBox groupBoxInPut_KRS;
        private System.Windows.Forms.Label labelStop_KRS;
        private System.Windows.Forms.TextBox textBoxStop_KRS;
        private System.Windows.Forms.Label labelStart_KRS;
        private System.Windows.Forms.TextBox textBoxStart_KRS;
        private System.Windows.Forms.Label labelStopEl_KRS;
        private System.Windows.Forms.Label labelStartEl_KRS;
        private System.Windows.Forms.TextBox textBoxStopEl_KRS;
        private System.Windows.Forms.TextBox textBoxStartEl_KRS;
        private System.Windows.Forms.Label labelColumn_KRS;
        private System.Windows.Forms.Label labelRow_KRS;
        private System.Windows.Forms.TextBox textBoxColumn_KRS;
        private System.Windows.Forms.TextBox textBoxRow_KRS;
        private System.Windows.Forms.GroupBox groupBoxOutPut_KRS;
        private System.Windows.Forms.DataGridView dataGridViewMatrix_KRS;
        private System.Windows.Forms.Label labelNumRow_KRS;
        private System.Windows.Forms.TextBox textBoxNumRow_KRS;
        private System.Windows.Forms.Label labelResult_KRS;
        private System.Windows.Forms.TextBox textBoxResult_KRS;
        private System.Windows.Forms.ToolTip toolTipButton_KRS;
    }
}

