
namespace Tyuiu.KoptyaevRS.Sprint6.Task0.V3
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
            this.groupBoxTask_KRS = new System.Windows.Forms.GroupBox();
            this.pictureBoxFormula_KRS = new System.Windows.Forms.PictureBox();
            this.textBoxCondition_KRS = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBoxInput_KRS = new System.Windows.Forms.GroupBox();
            this.textBoxVarX_KRS = new System.Windows.Forms.TextBox();
            this.labelInput_KRS = new System.Windows.Forms.Label();
            this.groupBoxOutput_KRS = new System.Windows.Forms.GroupBox();
            this.textBoxResult_KRS = new System.Windows.Forms.TextBox();
            this.labelOutput_KRS = new System.Windows.Forms.Label();
            this.buttonDone_KRS = new System.Windows.Forms.Button();
            this.buttonInfo_KRS = new System.Windows.Forms.Button();
            this.groupBoxTask_KRS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_KRS)).BeginInit();
            this.groupBoxInput_KRS.SuspendLayout();
            this.groupBoxOutput_KRS.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTask_KRS
            // 
            this.groupBoxTask_KRS.Controls.Add(this.pictureBoxFormula_KRS);
            this.groupBoxTask_KRS.Controls.Add(this.textBoxCondition_KRS);
            this.groupBoxTask_KRS.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask_KRS.Name = "groupBoxTask_KRS";
            this.groupBoxTask_KRS.Size = new System.Drawing.Size(649, 193);
            this.groupBoxTask_KRS.TabIndex = 0;
            this.groupBoxTask_KRS.TabStop = false;
            this.groupBoxTask_KRS.Text = "Условие";
            // 
            // pictureBoxFormula_KRS
            // 
            this.pictureBoxFormula_KRS.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFormula_KRS.Image")));
            this.pictureBoxFormula_KRS.Location = new System.Drawing.Point(431, 19);
            this.pictureBoxFormula_KRS.Name = "pictureBoxFormula_KRS";
            this.pictureBoxFormula_KRS.Size = new System.Drawing.Size(200, 92);
            this.pictureBoxFormula_KRS.TabIndex = 1;
            this.pictureBoxFormula_KRS.TabStop = false;
            // 
            // textBoxCondition_KRS
            // 
            this.textBoxCondition_KRS.Location = new System.Drawing.Point(0, 19);
            this.textBoxCondition_KRS.Multiline = true;
            this.textBoxCondition_KRS.Name = "textBoxCondition_KRS";
            this.textBoxCondition_KRS.ReadOnly = true;
            this.textBoxCondition_KRS.Size = new System.Drawing.Size(414, 168);
            this.textBoxCondition_KRS.TabIndex = 0;
            this.textBoxCondition_KRS.Text = "Вычислите значение выражения по формуле";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // groupBoxInput_KRS
            // 
            this.groupBoxInput_KRS.Controls.Add(this.textBoxVarX_KRS);
            this.groupBoxInput_KRS.Controls.Add(this.labelInput_KRS);
            this.groupBoxInput_KRS.Location = new System.Drawing.Point(12, 212);
            this.groupBoxInput_KRS.Name = "groupBoxInput_KRS";
            this.groupBoxInput_KRS.Size = new System.Drawing.Size(202, 143);
            this.groupBoxInput_KRS.TabIndex = 2;
            this.groupBoxInput_KRS.TabStop = false;
            this.groupBoxInput_KRS.Text = "Ввод данных:";
            // 
            // textBoxVarX_KRS
            // 
            this.textBoxVarX_KRS.Location = new System.Drawing.Point(7, 37);
            this.textBoxVarX_KRS.Name = "textBoxVarX_KRS";
            this.textBoxVarX_KRS.Size = new System.Drawing.Size(100, 20);
            this.textBoxVarX_KRS.TabIndex = 1;
            this.textBoxVarX_KRS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxVarX_KeyPress);
            // 
            // labelInput_KRS
            // 
            this.labelInput_KRS.AutoSize = true;
            this.labelInput_KRS.Location = new System.Drawing.Point(7, 20);
            this.labelInput_KRS.Name = "labelInput_KRS";
            this.labelInput_KRS.Size = new System.Drawing.Size(84, 13);
            this.labelInput_KRS.TabIndex = 0;
            this.labelInput_KRS.Text = "Переменная X:";
            // 
            // groupBoxOutput_KRS
            // 
            this.groupBoxOutput_KRS.Controls.Add(this.textBoxResult_KRS);
            this.groupBoxOutput_KRS.Controls.Add(this.labelOutput_KRS);
            this.groupBoxOutput_KRS.Location = new System.Drawing.Point(237, 212);
            this.groupBoxOutput_KRS.Name = "groupBoxOutput_KRS";
            this.groupBoxOutput_KRS.Size = new System.Drawing.Size(294, 143);
            this.groupBoxOutput_KRS.TabIndex = 3;
            this.groupBoxOutput_KRS.TabStop = false;
            this.groupBoxOutput_KRS.Text = "Вывод данных:";
            // 
            // textBoxResult_KRS
            // 
            this.textBoxResult_KRS.Location = new System.Drawing.Point(6, 36);
            this.textBoxResult_KRS.Name = "textBoxResult_KRS";
            this.textBoxResult_KRS.ReadOnly = true;
            this.textBoxResult_KRS.Size = new System.Drawing.Size(100, 20);
            this.textBoxResult_KRS.TabIndex = 1;
            // 
            // labelOutput_KRS
            // 
            this.labelOutput_KRS.AutoSize = true;
            this.labelOutput_KRS.Location = new System.Drawing.Point(7, 20);
            this.labelOutput_KRS.Name = "labelOutput_KRS";
            this.labelOutput_KRS.Size = new System.Drawing.Size(62, 13);
            this.labelOutput_KRS.TabIndex = 0;
            this.labelOutput_KRS.Text = "Результат:";
            // 
            // buttonDone_KRS
            // 
            this.buttonDone_KRS.Location = new System.Drawing.Point(377, 361);
            this.buttonDone_KRS.Name = "buttonDone_KRS";
            this.buttonDone_KRS.Size = new System.Drawing.Size(154, 70);
            this.buttonDone_KRS.TabIndex = 4;
            this.buttonDone_KRS.Text = "Выполнить";
            this.buttonDone_KRS.UseVisualStyleBackColor = true;
            this.buttonDone_KRS.Click += new System.EventHandler(this.buttonDone_KRS_Click);
            // 
            // buttonInfo_KRS
            // 
            this.buttonInfo_KRS.Location = new System.Drawing.Point(272, 361);
            this.buttonInfo_KRS.Name = "buttonInfo_KRS";
            this.buttonInfo_KRS.Size = new System.Drawing.Size(75, 70);
            this.buttonInfo_KRS.TabIndex = 5;
            this.buttonInfo_KRS.Text = "?";
            this.buttonInfo_KRS.UseVisualStyleBackColor = true;
            this.buttonInfo_KRS.Click += new System.EventHandler(this.buttonInfo_KRS_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonInfo_KRS);
            this.Controls.Add(this.buttonDone_KRS);
            this.Controls.Add(this.groupBoxOutput_KRS);
            this.Controls.Add(this.groupBoxInput_KRS);
            this.Controls.Add(this.groupBoxTask_KRS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 0 | Вариант 3 | Коптяев Р. С.";
            this.groupBoxTask_KRS.ResumeLayout(false);
            this.groupBoxTask_KRS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_KRS)).EndInit();
            this.groupBoxInput_KRS.ResumeLayout(false);
            this.groupBoxInput_KRS.PerformLayout();
            this.groupBoxOutput_KRS.ResumeLayout(false);
            this.groupBoxOutput_KRS.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_KRS;
        private System.Windows.Forms.PictureBox pictureBoxFormula_KRS;
        private System.Windows.Forms.TextBox textBoxCondition_KRS;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.GroupBox groupBoxInput_KRS;
        private System.Windows.Forms.TextBox textBoxVarX_KRS;
        private System.Windows.Forms.Label labelInput_KRS;
        private System.Windows.Forms.GroupBox groupBoxOutput_KRS;
        private System.Windows.Forms.TextBox textBoxResult_KRS;
        private System.Windows.Forms.Label labelOutput_KRS;
        private System.Windows.Forms.Button buttonDone_KRS;
        private System.Windows.Forms.Button buttonInfo_KRS;
    }
}

