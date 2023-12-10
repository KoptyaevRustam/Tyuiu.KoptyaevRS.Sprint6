
namespace Tyuiu.KoptyaevRS.Sprint6.Task1.V13
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
            this.groupBoxTask_KRS = new System.Windows.Forms.GroupBox();
            this.pictureBoxFunction_KRS = new System.Windows.Forms.PictureBox();
            this.textBoxTask_KRS = new System.Windows.Forms.TextBox();
            this.groupBoxInput_KRS = new System.Windows.Forms.GroupBox();
            this.labelStop_KRS = new System.Windows.Forms.Label();
            this.labelStart_KRS = new System.Windows.Forms.Label();
            this.textBoxVarStop_KRS = new System.Windows.Forms.TextBox();
            this.textBoxVarStart_KRS = new System.Windows.Forms.TextBox();
            this.buttonInfo_KRS = new System.Windows.Forms.Button();
            this.buttonDoen_KRS = new System.Windows.Forms.Button();
            this.groupBoxoutput_KRS = new System.Windows.Forms.GroupBox();
            this.textBoxOut_KRS = new System.Windows.Forms.TextBox();
            this.textBoxResult_KRS = new System.Windows.Forms.TextBox();
            this.groupBoxTask_KRS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFunction_KRS)).BeginInit();
            this.groupBoxInput_KRS.SuspendLayout();
            this.groupBoxoutput_KRS.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTask_KRS
            // 
            this.groupBoxTask_KRS.Controls.Add(this.pictureBoxFunction_KRS);
            this.groupBoxTask_KRS.Controls.Add(this.textBoxTask_KRS);
            this.groupBoxTask_KRS.Location = new System.Drawing.Point(13, 13);
            this.groupBoxTask_KRS.Name = "groupBoxTask_KRS";
            this.groupBoxTask_KRS.Size = new System.Drawing.Size(369, 271);
            this.groupBoxTask_KRS.TabIndex = 0;
            this.groupBoxTask_KRS.TabStop = false;
            this.groupBoxTask_KRS.Text = "Условие";
            // 
            // pictureBoxFunction_KRS
            // 
            this.pictureBoxFunction_KRS.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFunction_KRS.Image")));
            this.pictureBoxFunction_KRS.Location = new System.Drawing.Point(7, 182);
            this.pictureBoxFunction_KRS.Name = "pictureBoxFunction_KRS";
            this.pictureBoxFunction_KRS.Size = new System.Drawing.Size(353, 50);
            this.pictureBoxFunction_KRS.TabIndex = 1;
            this.pictureBoxFunction_KRS.TabStop = false;
            // 
            // textBoxTask_KRS
            // 
            this.textBoxTask_KRS.Location = new System.Drawing.Point(7, 20);
            this.textBoxTask_KRS.Multiline = true;
            this.textBoxTask_KRS.Name = "textBoxTask_KRS";
            this.textBoxTask_KRS.ReadOnly = true;
            this.textBoxTask_KRS.Size = new System.Drawing.Size(356, 156);
            this.textBoxTask_KRS.TabIndex = 0;
            this.textBoxTask_KRS.Text = "Протабулировать функцию на заданном диапазоне. \r\nПроизвести проверку деления на н" +
    "оль.\r\nРезультат вывести в виде таблицы.";
            // 
            // groupBoxInput_KRS
            // 
            this.groupBoxInput_KRS.Controls.Add(this.labelStop_KRS);
            this.groupBoxInput_KRS.Controls.Add(this.labelStart_KRS);
            this.groupBoxInput_KRS.Controls.Add(this.textBoxVarStop_KRS);
            this.groupBoxInput_KRS.Controls.Add(this.textBoxVarStart_KRS);
            this.groupBoxInput_KRS.Location = new System.Drawing.Point(13, 303);
            this.groupBoxInput_KRS.Name = "groupBoxInput_KRS";
            this.groupBoxInput_KRS.Size = new System.Drawing.Size(251, 135);
            this.groupBoxInput_KRS.TabIndex = 1;
            this.groupBoxInput_KRS.TabStop = false;
            this.groupBoxInput_KRS.Text = "Ввод данных";
            // 
            // labelStop_KRS
            // 
            this.labelStop_KRS.AutoSize = true;
            this.labelStop_KRS.Location = new System.Drawing.Point(87, 39);
            this.labelStop_KRS.Name = "labelStop_KRS";
            this.labelStop_KRS.Size = new System.Drawing.Size(69, 13);
            this.labelStop_KRS.TabIndex = 3;
            this.labelStop_KRS.Text = "Конец шага:";
            // 
            // labelStart_KRS
            // 
            this.labelStart_KRS.AutoSize = true;
            this.labelStart_KRS.Location = new System.Drawing.Point(7, 39);
            this.labelStart_KRS.Name = "labelStart_KRS";
            this.labelStart_KRS.Size = new System.Drawing.Size(67, 13);
            this.labelStart_KRS.TabIndex = 2;
            this.labelStart_KRS.Text = "Старт шага:";
            // 
            // textBoxVarStop_KRS
            // 
            this.textBoxVarStop_KRS.Location = new System.Drawing.Point(90, 58);
            this.textBoxVarStop_KRS.Name = "textBoxVarStop_KRS";
            this.textBoxVarStop_KRS.Size = new System.Drawing.Size(73, 20);
            this.textBoxVarStop_KRS.TabIndex = 1;
            this.textBoxVarStop_KRS.Text = "5";
            // 
            // textBoxVarStart_KRS
            // 
            this.textBoxVarStart_KRS.Location = new System.Drawing.Point(7, 58);
            this.textBoxVarStart_KRS.Name = "textBoxVarStart_KRS";
            this.textBoxVarStart_KRS.Size = new System.Drawing.Size(77, 20);
            this.textBoxVarStart_KRS.TabIndex = 0;
            this.textBoxVarStart_KRS.Text = "-5";
            // 
            // buttonInfo_KRS
            // 
            this.buttonInfo_KRS.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonInfo_KRS.Location = new System.Drawing.Point(270, 353);
            this.buttonInfo_KRS.Name = "buttonInfo_KRS";
            this.buttonInfo_KRS.Size = new System.Drawing.Size(88, 85);
            this.buttonInfo_KRS.TabIndex = 2;
            this.buttonInfo_KRS.Text = "Справка";
            this.buttonInfo_KRS.UseVisualStyleBackColor = false;
            this.buttonInfo_KRS.Click += new System.EventHandler(this.buttonInfo_KRS_Click);
            // 
            // buttonDoen_KRS
            // 
            this.buttonDoen_KRS.BackColor = System.Drawing.Color.Green;
            this.buttonDoen_KRS.Location = new System.Drawing.Point(364, 353);
            this.buttonDoen_KRS.Name = "buttonDoen_KRS";
            this.buttonDoen_KRS.Size = new System.Drawing.Size(85, 85);
            this.buttonDoen_KRS.TabIndex = 3;
            this.buttonDoen_KRS.Text = "Выполнить";
            this.buttonDoen_KRS.UseVisualStyleBackColor = false;
            this.buttonDoen_KRS.Click += new System.EventHandler(this.buttonDoen_KRS_Click);
            // 
            // groupBoxoutput_KRS
            // 
            this.groupBoxoutput_KRS.Controls.Add(this.textBoxResult_KRS);
            this.groupBoxoutput_KRS.Controls.Add(this.textBoxOut_KRS);
            this.groupBoxoutput_KRS.Location = new System.Drawing.Point(488, 33);
            this.groupBoxoutput_KRS.Name = "groupBoxoutput_KRS";
            this.groupBoxoutput_KRS.Size = new System.Drawing.Size(277, 405);
            this.groupBoxoutput_KRS.TabIndex = 4;
            this.groupBoxoutput_KRS.TabStop = false;
            this.groupBoxoutput_KRS.Text = "Вывод данных";
            // 
            // textBoxOut_KRS
            // 
            this.textBoxOut_KRS.Location = new System.Drawing.Point(7, 20);
            this.textBoxOut_KRS.Name = "textBoxOut_KRS";
            this.textBoxOut_KRS.ReadOnly = true;
            this.textBoxOut_KRS.Size = new System.Drawing.Size(264, 20);
            this.textBoxOut_KRS.TabIndex = 0;
            this.textBoxOut_KRS.Text = "Результат";
            // 
            // textBoxResult_KRS
            // 
            this.textBoxResult_KRS.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxResult_KRS.Location = new System.Drawing.Point(7, 47);
            this.textBoxResult_KRS.Multiline = true;
            this.textBoxResult_KRS.Name = "textBoxResult_KRS";
            this.textBoxResult_KRS.ReadOnly = true;
            this.textBoxResult_KRS.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult_KRS.Size = new System.Drawing.Size(264, 352);
            this.textBoxResult_KRS.TabIndex = 1;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxoutput_KRS);
            this.Controls.Add(this.buttonDoen_KRS);
            this.Controls.Add(this.buttonInfo_KRS);
            this.Controls.Add(this.groupBoxInput_KRS);
            this.Controls.Add(this.groupBoxTask_KRS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 1 | Вариант 13 | Коптяев Р. С.";
            this.groupBoxTask_KRS.ResumeLayout(false);
            this.groupBoxTask_KRS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFunction_KRS)).EndInit();
            this.groupBoxInput_KRS.ResumeLayout(false);
            this.groupBoxInput_KRS.PerformLayout();
            this.groupBoxoutput_KRS.ResumeLayout(false);
            this.groupBoxoutput_KRS.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_KRS;
        private System.Windows.Forms.GroupBox groupBoxInput_KRS;
        private System.Windows.Forms.TextBox textBoxVarStop_KRS;
        private System.Windows.Forms.TextBox textBoxVarStart_KRS;
        private System.Windows.Forms.Label labelStop_KRS;
        private System.Windows.Forms.Label labelStart_KRS;
        private System.Windows.Forms.PictureBox pictureBoxFunction_KRS;
        private System.Windows.Forms.TextBox textBoxTask_KRS;
        private System.Windows.Forms.Button buttonInfo_KRS;
        private System.Windows.Forms.Button buttonDoen_KRS;
        private System.Windows.Forms.GroupBox groupBoxoutput_KRS;
        private System.Windows.Forms.TextBox textBoxOut_KRS;
        private System.Windows.Forms.TextBox textBoxResult_KRS;
    }
}

