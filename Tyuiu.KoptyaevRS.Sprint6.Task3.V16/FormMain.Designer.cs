
namespace Tyuiu.KoptyaevRS.Sprint6.Task3.V16
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
            this.groupBoxCon_KRS = new System.Windows.Forms.GroupBox();
            this.textBoxCondition_KRS = new System.Windows.Forms.TextBox();
            this.dataGridViewMatrix_KRS = new System.Windows.Forms.DataGridView();
            this.groupBoxResult_KRS = new System.Windows.Forms.GroupBox();
            this.dataGridViewMatrixResult_KRS = new System.Windows.Forms.DataGridView();
            this.buttonInfo_KRS = new System.Windows.Forms.Button();
            this.buttonDone_KRS = new System.Windows.Forms.Button();
            this.groupBoxCon_KRS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix_KRS)).BeginInit();
            this.groupBoxResult_KRS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrixResult_KRS)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxCon_KRS
            // 
            this.groupBoxCon_KRS.Controls.Add(this.textBoxCondition_KRS);
            this.groupBoxCon_KRS.Location = new System.Drawing.Point(13, 13);
            this.groupBoxCon_KRS.Name = "groupBoxCon_KRS";
            this.groupBoxCon_KRS.Size = new System.Drawing.Size(200, 176);
            this.groupBoxCon_KRS.TabIndex = 0;
            this.groupBoxCon_KRS.TabStop = false;
            this.groupBoxCon_KRS.Text = "Условие";
            // 
            // textBoxCondition_KRS
            // 
            this.textBoxCondition_KRS.Location = new System.Drawing.Point(7, 20);
            this.textBoxCondition_KRS.Multiline = true;
            this.textBoxCondition_KRS.Name = "textBoxCondition_KRS";
            this.textBoxCondition_KRS.ReadOnly = true;
            this.textBoxCondition_KRS.Size = new System.Drawing.Size(187, 152);
            this.textBoxCondition_KRS.TabIndex = 0;
            this.textBoxCondition_KRS.Text = "Дана матрица 5 на 5\r\n14 1 -3 1 10\r\n7 -3 5 -4 0\r\n-10 -19 -18 -9 19\r\n-2 -2 -16 2 -1" +
    "7\r\n-16 9 5 -10 16\r\nЗаменить четные значения в третьей строке на 0";
            // 
            // dataGridViewMatrix_KRS
            // 
            this.dataGridViewMatrix_KRS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatrix_KRS.ColumnHeadersVisible = false;
            this.dataGridViewMatrix_KRS.Location = new System.Drawing.Point(234, 33);
            this.dataGridViewMatrix_KRS.Name = "dataGridViewMatrix_KRS";
            this.dataGridViewMatrix_KRS.RowHeadersVisible = false;
            this.dataGridViewMatrix_KRS.Size = new System.Drawing.Size(128, 116);
            this.dataGridViewMatrix_KRS.TabIndex = 1;
            // 
            // groupBoxResult_KRS
            // 
            this.groupBoxResult_KRS.Controls.Add(this.dataGridViewMatrixResult_KRS);
            this.groupBoxResult_KRS.Location = new System.Drawing.Point(378, 13);
            this.groupBoxResult_KRS.Name = "groupBoxResult_KRS";
            this.groupBoxResult_KRS.Size = new System.Drawing.Size(153, 172);
            this.groupBoxResult_KRS.TabIndex = 2;
            this.groupBoxResult_KRS.TabStop = false;
            this.groupBoxResult_KRS.Text = "Результат";
            // 
            // dataGridViewMatrixResult_KRS
            // 
            this.dataGridViewMatrixResult_KRS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatrixResult_KRS.ColumnHeadersVisible = false;
            this.dataGridViewMatrixResult_KRS.Location = new System.Drawing.Point(13, 19);
            this.dataGridViewMatrixResult_KRS.Name = "dataGridViewMatrixResult_KRS";
            this.dataGridViewMatrixResult_KRS.RowHeadersVisible = false;
            this.dataGridViewMatrixResult_KRS.Size = new System.Drawing.Size(128, 116);
            this.dataGridViewMatrixResult_KRS.TabIndex = 1;
            // 
            // buttonInfo_KRS
            // 
            this.buttonInfo_KRS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInfo_KRS.Location = new System.Drawing.Point(219, 155);
            this.buttonInfo_KRS.Name = "buttonInfo_KRS";
            this.buttonInfo_KRS.Size = new System.Drawing.Size(37, 34);
            this.buttonInfo_KRS.TabIndex = 3;
            this.buttonInfo_KRS.Text = "?";
            this.buttonInfo_KRS.UseVisualStyleBackColor = true;
            this.buttonInfo_KRS.Click += new System.EventHandler(this.buttonInfo_KRS_Click);
            // 
            // buttonDone_KRS
            // 
            this.buttonDone_KRS.Location = new System.Drawing.Point(279, 155);
            this.buttonDone_KRS.Name = "buttonDone_KRS";
            this.buttonDone_KRS.Size = new System.Drawing.Size(93, 34);
            this.buttonDone_KRS.TabIndex = 4;
            this.buttonDone_KRS.Text = "Выполнить";
            this.buttonDone_KRS.UseVisualStyleBackColor = true;
            this.buttonDone_KRS.Click += new System.EventHandler(this.buttonDone_KRS_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 203);
            this.Controls.Add(this.buttonDone_KRS);
            this.Controls.Add(this.buttonInfo_KRS);
            this.Controls.Add(this.groupBoxResult_KRS);
            this.Controls.Add(this.dataGridViewMatrix_KRS);
            this.Controls.Add(this.groupBoxCon_KRS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 3 | Вариант 16 | Коптяев Р. С.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxCon_KRS.ResumeLayout(false);
            this.groupBoxCon_KRS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix_KRS)).EndInit();
            this.groupBoxResult_KRS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrixResult_KRS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCon_KRS;
        private System.Windows.Forms.TextBox textBoxCondition_KRS;
        private System.Windows.Forms.DataGridView dataGridViewMatrix_KRS;
        private System.Windows.Forms.GroupBox groupBoxResult_KRS;
        private System.Windows.Forms.DataGridView dataGridViewMatrixResult_KRS;
        private System.Windows.Forms.Button buttonInfo_KRS;
        private System.Windows.Forms.Button buttonDone_KRS;
    }
}

