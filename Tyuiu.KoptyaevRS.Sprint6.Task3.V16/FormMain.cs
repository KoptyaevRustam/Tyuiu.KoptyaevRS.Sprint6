using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.KoptyaevRS.Sprint6.Task3.V16.Lib;

namespace Tyuiu.KoptyaevRS.Sprint6.Task3.V16
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        int[,] mtrx = new int[5, 5] { { 14, 1, -3, 1, 10 }, { 7, -3, 5, -4, 0 }, { -10, -19, -18, -9, 19 }, { -2, -2, -16, 2, 17 }, { -16, 9, 5, -10, 16 } };
        private void buttonDone_KRS_Click(object sender, EventArgs e)
        {
            int[,] mtrx2 = ds.Calculate(mtrx);
            int rows = mtrx2.GetUpperBound(0) + 1;
            int columns = mtrx2.Length / rows;

            dataGridViewMatrixResult_KRS.ColumnCount = columns;
            dataGridViewMatrixResult_KRS.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewMatrixResult_KRS.Columns[i].Width = 25;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewMatrixResult_KRS.Rows[i].Cells[j].Value = Convert.ToString(mtrx2[i, j]);
                }
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = mtrx.GetUpperBound(0) + 1;
            int columns = mtrx.Length / rows;

            dataGridViewMatrix_KRS.ColumnCount = columns;
            dataGridViewMatrix_KRS.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewMatrix_KRS.Columns[i].Width = 25;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewMatrix_KRS.Rows[i].Cells[j].Value = Convert.ToString(mtrx[i, j]);
                }
            }
        }

        private void buttonInfo_KRS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнил студент группы АСОиУБ-23-3 Коптяев Рустам Сергеевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    
    }
}
