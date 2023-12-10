
namespace Tyuiu.KoptyaevRS.Sprint6.Task6.V3
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
            this.groupBoxCon_KRS = new System.Windows.Forms.GroupBox();
            this.textBoxCon_KRS = new System.Windows.Forms.TextBox();
            this.buttonInfo_KRS = new System.Windows.Forms.Button();
            this.buttonDone_KRS = new System.Windows.Forms.Button();
            this.buttonOpenFile_KRS = new System.Windows.Forms.Button();
            this.panelleft_KRS = new System.Windows.Forms.Panel();
            this.groupBoxInPut_KRS = new System.Windows.Forms.GroupBox();
            this.textBoxInPut_KRS = new System.Windows.Forms.TextBox();
            this.panelRight_KRS = new System.Windows.Forms.Panel();
            this.groupBoxOutPut_KRS = new System.Windows.Forms.GroupBox();
            this.textBoxOutPut_KRS = new System.Windows.Forms.TextBox();
            this.openFileDialogTask = new System.Windows.Forms.OpenFileDialog();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.panelUp_KRS.SuspendLayout();
            this.groupBoxCon_KRS.SuspendLayout();
            this.panelleft_KRS.SuspendLayout();
            this.groupBoxInPut_KRS.SuspendLayout();
            this.panelRight_KRS.SuspendLayout();
            this.groupBoxOutPut_KRS.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelUp_KRS
            // 
            this.panelUp_KRS.Controls.Add(this.groupBoxCon_KRS);
            this.panelUp_KRS.Controls.Add(this.buttonInfo_KRS);
            this.panelUp_KRS.Controls.Add(this.buttonDone_KRS);
            this.panelUp_KRS.Controls.Add(this.buttonOpenFile_KRS);
            this.panelUp_KRS.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUp_KRS.Location = new System.Drawing.Point(0, 0);
            this.panelUp_KRS.Name = "panelUp_KRS";
            this.panelUp_KRS.Size = new System.Drawing.Size(800, 180);
            this.panelUp_KRS.TabIndex = 0;
            // 
            // groupBoxCon_KRS
            // 
            this.groupBoxCon_KRS.Controls.Add(this.textBoxCon_KRS);
            this.groupBoxCon_KRS.Location = new System.Drawing.Point(4, 90);
            this.groupBoxCon_KRS.Name = "groupBoxCon_KRS";
            this.groupBoxCon_KRS.Size = new System.Drawing.Size(793, 121);
            this.groupBoxCon_KRS.TabIndex = 3;
            this.groupBoxCon_KRS.TabStop = false;
            this.groupBoxCon_KRS.Text = "Условие";
            // 
            // textBoxCon_KRS
            // 
            this.textBoxCon_KRS.Location = new System.Drawing.Point(7, 20);
            this.textBoxCon_KRS.Multiline = true;
            this.textBoxCon_KRS.Name = "textBoxCon_KRS";
            this.textBoxCon_KRS.ReadOnly = true;
            this.textBoxCon_KRS.Size = new System.Drawing.Size(780, 58);
            this.textBoxCon_KRS.TabIndex = 0;
            this.textBoxCon_KRS.Text = resources.GetString("textBoxCon_KRS.Text");
            // 
            // buttonInfo_KRS
            // 
            this.buttonInfo_KRS.Image = ((System.Drawing.Image)(resources.GetObject("buttonInfo_KRS.Image")));
            this.buttonInfo_KRS.Location = new System.Drawing.Point(694, 5);
            this.buttonInfo_KRS.Name = "buttonInfo_KRS";
            this.buttonInfo_KRS.Size = new System.Drawing.Size(103, 79);
            this.buttonInfo_KRS.TabIndex = 2;
            this.toolTip.SetToolTip(this.buttonInfo_KRS, "Сведения о программе");
            this.buttonInfo_KRS.UseVisualStyleBackColor = true;
            this.buttonInfo_KRS.Click += new System.EventHandler(this.buttonInfo_KRS_Click);
            // 
            // buttonDone_KRS
            // 
            this.buttonDone_KRS.Image = ((System.Drawing.Image)(resources.GetObject("buttonDone_KRS.Image")));
            this.buttonDone_KRS.Location = new System.Drawing.Point(99, 4);
            this.buttonDone_KRS.Name = "buttonDone_KRS";
            this.buttonDone_KRS.Size = new System.Drawing.Size(99, 79);
            this.buttonDone_KRS.TabIndex = 1;
            this.toolTip.SetToolTip(this.buttonDone_KRS, "Производит поиск в файле слов в которых встречается r");
            this.buttonDone_KRS.UseVisualStyleBackColor = true;
            this.buttonDone_KRS.Click += new System.EventHandler(this.buttonDone_KRS_Click);
            // 
            // buttonOpenFile_KRS
            // 
            this.buttonOpenFile_KRS.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpenFile_KRS.Image")));
            this.buttonOpenFile_KRS.Location = new System.Drawing.Point(4, 4);
            this.buttonOpenFile_KRS.Name = "buttonOpenFile_KRS";
            this.buttonOpenFile_KRS.Size = new System.Drawing.Size(88, 79);
            this.buttonOpenFile_KRS.TabIndex = 0;
            this.toolTip.SetToolTip(this.buttonOpenFile_KRS, "Открыть файл\r\nВыберите файл для обработки");
            this.buttonOpenFile_KRS.UseVisualStyleBackColor = true;
            this.buttonOpenFile_KRS.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelleft_KRS
            // 
            this.panelleft_KRS.Controls.Add(this.groupBoxInPut_KRS);
            this.panelleft_KRS.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelleft_KRS.Location = new System.Drawing.Point(0, 180);
            this.panelleft_KRS.Name = "panelleft_KRS";
            this.panelleft_KRS.Size = new System.Drawing.Size(388, 270);
            this.panelleft_KRS.TabIndex = 1;
            // 
            // groupBoxInPut_KRS
            // 
            this.groupBoxInPut_KRS.Controls.Add(this.textBoxInPut_KRS);
            this.groupBoxInPut_KRS.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxInPut_KRS.Location = new System.Drawing.Point(0, 0);
            this.groupBoxInPut_KRS.Name = "groupBoxInPut_KRS";
            this.groupBoxInPut_KRS.Size = new System.Drawing.Size(374, 270);
            this.groupBoxInPut_KRS.TabIndex = 0;
            this.groupBoxInPut_KRS.TabStop = false;
            this.groupBoxInPut_KRS.Text = "Ввод:";
            // 
            // textBoxInPut_KRS
            // 
            this.textBoxInPut_KRS.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBoxInPut_KRS.Location = new System.Drawing.Point(3, 16);
            this.textBoxInPut_KRS.Multiline = true;
            this.textBoxInPut_KRS.Name = "textBoxInPut_KRS";
            this.textBoxInPut_KRS.ReadOnly = true;
            this.textBoxInPut_KRS.Size = new System.Drawing.Size(366, 251);
            this.textBoxInPut_KRS.TabIndex = 0;
            // 
            // panelRight_KRS
            // 
            this.panelRight_KRS.Controls.Add(this.groupBoxOutPut_KRS);
            this.panelRight_KRS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight_KRS.Location = new System.Drawing.Point(388, 180);
            this.panelRight_KRS.Name = "panelRight_KRS";
            this.panelRight_KRS.Size = new System.Drawing.Size(412, 270);
            this.panelRight_KRS.TabIndex = 2;
            // 
            // groupBoxOutPut_KRS
            // 
            this.groupBoxOutPut_KRS.Controls.Add(this.textBoxOutPut_KRS);
            this.groupBoxOutPut_KRS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOutPut_KRS.Location = new System.Drawing.Point(0, 0);
            this.groupBoxOutPut_KRS.Name = "groupBoxOutPut_KRS";
            this.groupBoxOutPut_KRS.Size = new System.Drawing.Size(412, 270);
            this.groupBoxOutPut_KRS.TabIndex = 0;
            this.groupBoxOutPut_KRS.TabStop = false;
            this.groupBoxOutPut_KRS.Text = "Вывод:";
            // 
            // textBoxOutPut_KRS
            // 
            this.textBoxOutPut_KRS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxOutPut_KRS.Location = new System.Drawing.Point(3, 16);
            this.textBoxOutPut_KRS.Multiline = true;
            this.textBoxOutPut_KRS.Name = "textBoxOutPut_KRS";
            this.textBoxOutPut_KRS.ReadOnly = true;
            this.textBoxOutPut_KRS.Size = new System.Drawing.Size(406, 251);
            this.textBoxOutPut_KRS.TabIndex = 0;
            // 
            // openFileDialogTask
            // 
            this.openFileDialogTask.FileName = "openFileDialog1";
            // 
            // toolTip
            // 
            this.toolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelRight_KRS);
            this.Controls.Add(this.panelleft_KRS);
            this.Controls.Add(this.panelUp_KRS);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 6 | Вариант 3 | Коптяев Р. С.";
            this.panelUp_KRS.ResumeLayout(false);
            this.groupBoxCon_KRS.ResumeLayout(false);
            this.groupBoxCon_KRS.PerformLayout();
            this.panelleft_KRS.ResumeLayout(false);
            this.groupBoxInPut_KRS.ResumeLayout(false);
            this.groupBoxInPut_KRS.PerformLayout();
            this.panelRight_KRS.ResumeLayout(false);
            this.groupBoxOutPut_KRS.ResumeLayout(false);
            this.groupBoxOutPut_KRS.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelUp_KRS;
        private System.Windows.Forms.GroupBox groupBoxCon_KRS;
        private System.Windows.Forms.TextBox textBoxCon_KRS;
        private System.Windows.Forms.Button buttonInfo_KRS;
        private System.Windows.Forms.Button buttonDone_KRS;
        private System.Windows.Forms.Button buttonOpenFile_KRS;
        private System.Windows.Forms.Panel panelleft_KRS;
        private System.Windows.Forms.Panel panelRight_KRS;
        private System.Windows.Forms.GroupBox groupBoxInPut_KRS;
        private System.Windows.Forms.TextBox textBoxInPut_KRS;
        private System.Windows.Forms.GroupBox groupBoxOutPut_KRS;
        private System.Windows.Forms.TextBox textBoxOutPut_KRS;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask;
        private System.Windows.Forms.ToolTip toolTip;
    }
}

