
namespace Tyuiu.KoptyaevRS.Sprint6.Task7.V15
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
            this.panelUpdown_KRS = new System.Windows.Forms.Panel();
            this.panelLeft_KRS = new System.Windows.Forms.Panel();
            this.panelRight_KRS = new System.Windows.Forms.Panel();
            this.buttonOpen_KRS = new System.Windows.Forms.Button();
            this.buttonDone_KRS = new System.Windows.Forms.Button();
            this.buttonSave_KRS = new System.Windows.Forms.Button();
            this.buttonInfo_KRS = new System.Windows.Forms.Button();
            this.groupBoxCon_KRS = new System.Windows.Forms.GroupBox();
            this.textBoxCon_KRS = new System.Windows.Forms.TextBox();
            this.groupBoxInPut_KRS = new System.Windows.Forms.GroupBox();
            this.groupBoxOutput_KRS = new System.Windows.Forms.GroupBox();
            this.dataGridViewIn_KRS = new System.Windows.Forms.DataGridView();
            this.dataGridViewOut_KRS = new System.Windows.Forms.DataGridView();
            this.openFileDialogTask_KRS = new System.Windows.Forms.OpenFileDialog();
            this.toolTipButton_KRS = new System.Windows.Forms.ToolTip(this.components);
            this.saveFileDialogMatrix_KRS = new System.Windows.Forms.SaveFileDialog();
            this.panelUp_KRS.SuspendLayout();
            this.panelUpdown_KRS.SuspendLayout();
            this.panelLeft_KRS.SuspendLayout();
            this.panelRight_KRS.SuspendLayout();
            this.groupBoxCon_KRS.SuspendLayout();
            this.groupBoxInPut_KRS.SuspendLayout();
            this.groupBoxOutput_KRS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIn_KRS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOut_KRS)).BeginInit();
            this.SuspendLayout();
            // 
            // panelUp_KRS
            // 
            this.panelUp_KRS.Controls.Add(this.buttonInfo_KRS);
            this.panelUp_KRS.Controls.Add(this.buttonSave_KRS);
            this.panelUp_KRS.Controls.Add(this.buttonDone_KRS);
            this.panelUp_KRS.Controls.Add(this.buttonOpen_KRS);
            this.panelUp_KRS.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUp_KRS.Location = new System.Drawing.Point(0, 0);
            this.panelUp_KRS.Name = "panelUp_KRS";
            this.panelUp_KRS.Size = new System.Drawing.Size(800, 100);
            this.panelUp_KRS.TabIndex = 0;
            // 
            // panelUpdown_KRS
            // 
            this.panelUpdown_KRS.Controls.Add(this.groupBoxCon_KRS);
            this.panelUpdown_KRS.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUpdown_KRS.Location = new System.Drawing.Point(0, 100);
            this.panelUpdown_KRS.Name = "panelUpdown_KRS";
            this.panelUpdown_KRS.Size = new System.Drawing.Size(800, 100);
            this.panelUpdown_KRS.TabIndex = 1;
            // 
            // panelLeft_KRS
            // 
            this.panelLeft_KRS.Controls.Add(this.groupBoxInPut_KRS);
            this.panelLeft_KRS.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft_KRS.Location = new System.Drawing.Point(0, 200);
            this.panelLeft_KRS.Name = "panelLeft_KRS";
            this.panelLeft_KRS.Size = new System.Drawing.Size(374, 250);
            this.panelLeft_KRS.TabIndex = 2;
            // 
            // panelRight_KRS
            // 
            this.panelRight_KRS.Controls.Add(this.groupBoxOutput_KRS);
            this.panelRight_KRS.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRight_KRS.Location = new System.Drawing.Point(373, 200);
            this.panelRight_KRS.Name = "panelRight_KRS";
            this.panelRight_KRS.Size = new System.Drawing.Size(427, 250);
            this.panelRight_KRS.TabIndex = 3;
            // 
            // buttonOpen_KRS
            // 
            this.buttonOpen_KRS.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpen_KRS.Image")));
            this.buttonOpen_KRS.Location = new System.Drawing.Point(4, 4);
            this.buttonOpen_KRS.Name = "buttonOpen_KRS";
            this.buttonOpen_KRS.Size = new System.Drawing.Size(94, 90);
            this.buttonOpen_KRS.TabIndex = 0;
            this.toolTipButton_KRS.SetToolTip(this.buttonOpen_KRS, "Открыть файл для обработки данных в формате CSV\r\n");
            this.buttonOpen_KRS.UseVisualStyleBackColor = true;
            this.buttonOpen_KRS.Click += new System.EventHandler(this.buttonOpen_KRS_Click);
            this.buttonOpen_KRS.MouseEnter += new System.EventHandler(this.buttonOpen_KRS_MouseEnter);
            // 
            // buttonDone_KRS
            // 
            this.buttonDone_KRS.Enabled = false;
            this.buttonDone_KRS.Image = ((System.Drawing.Image)(resources.GetObject("buttonDone_KRS.Image")));
            this.buttonDone_KRS.Location = new System.Drawing.Point(105, 4);
            this.buttonDone_KRS.Name = "buttonDone_KRS";
            this.buttonDone_KRS.Size = new System.Drawing.Size(95, 90);
            this.buttonDone_KRS.TabIndex = 1;
            this.toolTipButton_KRS.SetToolTip(this.buttonDone_KRS, "Выполнить обработку данных");
            this.buttonDone_KRS.UseVisualStyleBackColor = true;
            this.buttonDone_KRS.Click += new System.EventHandler(this.buttonDone_KRS_Click);
            this.buttonDone_KRS.MouseEnter += new System.EventHandler(this.buttonDone_KRS_MouseEnter);
            // 
            // buttonSave_KRS
            // 
            this.buttonSave_KRS.Enabled = false;
            this.buttonSave_KRS.Image = ((System.Drawing.Image)(resources.GetObject("buttonSave_KRS.Image")));
            this.buttonSave_KRS.Location = new System.Drawing.Point(207, 4);
            this.buttonSave_KRS.Name = "buttonSave_KRS";
            this.buttonSave_KRS.Size = new System.Drawing.Size(103, 90);
            this.buttonSave_KRS.TabIndex = 2;
            this.toolTipButton_KRS.SetToolTip(this.buttonSave_KRS, "Сохранить обработанные данные в файл в формате CSV");
            this.buttonSave_KRS.UseVisualStyleBackColor = true;
            this.buttonSave_KRS.Click += new System.EventHandler(this.buttonSave_KRS_Click);
            this.buttonSave_KRS.MouseEnter += new System.EventHandler(this.buttonSave_KRS_MouseEnter);
            // 
            // buttonInfo_KRS
            // 
            this.buttonInfo_KRS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInfo_KRS.Image = ((System.Drawing.Image)(resources.GetObject("buttonInfo_KRS.Image")));
            this.buttonInfo_KRS.Location = new System.Drawing.Point(696, 4);
            this.buttonInfo_KRS.Name = "buttonInfo_KRS";
            this.buttonInfo_KRS.Size = new System.Drawing.Size(92, 90);
            this.buttonInfo_KRS.TabIndex = 4;
            this.toolTipButton_KRS.SetToolTip(this.buttonInfo_KRS, "Сведения о программе\r\n");
            this.buttonInfo_KRS.UseVisualStyleBackColor = true;
            this.buttonInfo_KRS.Click += new System.EventHandler(this.buttonInfo_KRS_Click);
            this.buttonInfo_KRS.MouseEnter += new System.EventHandler(this.buttonInfo_KRS_MouseEnter);
            // 
            // groupBoxCon_KRS
            // 
            this.groupBoxCon_KRS.Controls.Add(this.textBoxCon_KRS);
            this.groupBoxCon_KRS.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxCon_KRS.Location = new System.Drawing.Point(0, 0);
            this.groupBoxCon_KRS.Name = "groupBoxCon_KRS";
            this.groupBoxCon_KRS.Size = new System.Drawing.Size(800, 90);
            this.groupBoxCon_KRS.TabIndex = 0;
            this.groupBoxCon_KRS.TabStop = false;
            this.groupBoxCon_KRS.Text = "Условие:";
            // 
            // textBoxCon_KRS
            // 
            this.textBoxCon_KRS.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxCon_KRS.Location = new System.Drawing.Point(3, 16);
            this.textBoxCon_KRS.Multiline = true;
            this.textBoxCon_KRS.Name = "textBoxCon_KRS";
            this.textBoxCon_KRS.ReadOnly = true;
            this.textBoxCon_KRS.Size = new System.Drawing.Size(794, 64);
            this.textBoxCon_KRS.TabIndex = 0;
            this.textBoxCon_KRS.Text = resources.GetString("textBoxCon_KRS.Text");
            // 
            // groupBoxInPut_KRS
            // 
            this.groupBoxInPut_KRS.Controls.Add(this.dataGridViewIn_KRS);
            this.groupBoxInPut_KRS.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxInPut_KRS.Location = new System.Drawing.Point(0, 0);
            this.groupBoxInPut_KRS.Name = "groupBoxInPut_KRS";
            this.groupBoxInPut_KRS.Size = new System.Drawing.Size(367, 250);
            this.groupBoxInPut_KRS.TabIndex = 0;
            this.groupBoxInPut_KRS.TabStop = false;
            this.groupBoxInPut_KRS.Text = "Ввод:";
            // 
            // groupBoxOutput_KRS
            // 
            this.groupBoxOutput_KRS.Controls.Add(this.dataGridViewOut_KRS);
            this.groupBoxOutput_KRS.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBoxOutput_KRS.Location = new System.Drawing.Point(10, 0);
            this.groupBoxOutput_KRS.Name = "groupBoxOutput_KRS";
            this.groupBoxOutput_KRS.Size = new System.Drawing.Size(417, 250);
            this.groupBoxOutput_KRS.TabIndex = 0;
            this.groupBoxOutput_KRS.TabStop = false;
            this.groupBoxOutput_KRS.Text = "Вывод:";
            // 
            // dataGridViewIn_KRS
            // 
            this.dataGridViewIn_KRS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIn_KRS.ColumnHeadersVisible = false;
            this.dataGridViewIn_KRS.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridViewIn_KRS.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewIn_KRS.Name = "dataGridViewIn_KRS";
            this.dataGridViewIn_KRS.RowHeadersVisible = false;
            this.dataGridViewIn_KRS.Size = new System.Drawing.Size(358, 231);
            this.dataGridViewIn_KRS.TabIndex = 0;
            // 
            // dataGridViewOut_KRS
            // 
            this.dataGridViewOut_KRS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOut_KRS.ColumnHeadersVisible = false;
            this.dataGridViewOut_KRS.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridViewOut_KRS.Location = new System.Drawing.Point(6, 16);
            this.dataGridViewOut_KRS.Name = "dataGridViewOut_KRS";
            this.dataGridViewOut_KRS.RowHeadersVisible = false;
            this.dataGridViewOut_KRS.Size = new System.Drawing.Size(408, 231);
            this.dataGridViewOut_KRS.TabIndex = 0;
            // 
            // openFileDialogTask_KRS
            // 
            this.openFileDialogTask_KRS.FileName = "openFileDialog1";
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
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelRight_KRS);
            this.Controls.Add(this.panelLeft_KRS);
            this.Controls.Add(this.panelUpdown_KRS);
            this.Controls.Add(this.panelUp_KRS);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 7 | Вариант 15 | Коптяев Р. С.";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panelUp_KRS.ResumeLayout(false);
            this.panelUpdown_KRS.ResumeLayout(false);
            this.panelLeft_KRS.ResumeLayout(false);
            this.panelRight_KRS.ResumeLayout(false);
            this.groupBoxCon_KRS.ResumeLayout(false);
            this.groupBoxCon_KRS.PerformLayout();
            this.groupBoxInPut_KRS.ResumeLayout(false);
            this.groupBoxOutput_KRS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIn_KRS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOut_KRS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelUp_KRS;
        private System.Windows.Forms.Button buttonInfo_KRS;
        private System.Windows.Forms.Button buttonSave_KRS;
        private System.Windows.Forms.Button buttonDone_KRS;
        private System.Windows.Forms.Button buttonOpen_KRS;
        private System.Windows.Forms.Panel panelUpdown_KRS;
        private System.Windows.Forms.GroupBox groupBoxCon_KRS;
        private System.Windows.Forms.TextBox textBoxCon_KRS;
        private System.Windows.Forms.Panel panelLeft_KRS;
        private System.Windows.Forms.GroupBox groupBoxInPut_KRS;
        private System.Windows.Forms.DataGridView dataGridViewIn_KRS;
        private System.Windows.Forms.Panel panelRight_KRS;
        private System.Windows.Forms.GroupBox groupBoxOutput_KRS;
        private System.Windows.Forms.DataGridView dataGridViewOut_KRS;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_KRS;
        private System.Windows.Forms.ToolTip toolTipButton_KRS;
        private System.Windows.Forms.SaveFileDialog saveFileDialogMatrix_KRS;
    }
}

