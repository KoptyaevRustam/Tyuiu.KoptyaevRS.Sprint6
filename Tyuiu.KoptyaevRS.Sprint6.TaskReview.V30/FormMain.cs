using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.KoptyaevRS.Sprint6.TaskReview.V30.Lib;

namespace Tyuiu.KoptyaevRS.Sprint6.TaskReview.V30
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        private void buttonDone_KRS_Click(object sender, EventArgs e)
        {
            try
            {


                int N = Convert.ToInt32(textBoxRow_KRS.Text);
                int M = Convert.ToInt32(textBoxColumn_KRS.Text);
                int n1 = Convert.ToInt32(textBoxStart_KRS.Text);
                int n2 = Convert.ToInt32(textBoxStop_KRS.Text);
                int k = Convert.ToInt32(textBoxStartEl_KRS.Text);
                int l = Convert.ToInt32(textBoxStopEl_KRS.Text);
                int c = Convert.ToInt32(textBoxNumRow_KRS.Text);
                if (N > 1 && M > 1 && n1 < n2 && k < l && c < N && c >= 0)
                {
                    Random rnd = new Random();
                    int[,] matrix = new int[N, M];

                    dataGridViewMatrix_KRS.RowCount = N;
                    dataGridViewMatrix_KRS.ColumnCount = M;

                    for (int i = 0; i < N; i++)
                    {
                        for (int j = 0; j < M; j++)
                        {
                            matrix[i, j] = rnd.Next(n1, n2 + 1);
                        }
                    }
                    int max, y;
                    for (int j = 0; j < M; j++)
                    {
                        for (int i = 0; i < N; i++)
                        {
                            max = i;
                            for (int x = i + 1; x < N; x++)
                            {
                                if (matrix[x, j] > matrix[max, j])
                                {
                                    max = x;
                                }
                            }
                            y = matrix[i, j];
                            matrix[i, j] = matrix[max, j];
                            matrix[max, j] = y;
                        }
                    }
                    for (int i = 0; i < N; i++)
                    {
                        for (int j = 0; j < M; j++)
                        {
                            dataGridViewMatrix_KRS.Rows[i].Cells[j].Value = matrix[i, j];
                            dataGridViewMatrix_KRS.Columns[i].Width = 25;
                        }
                    }
                    textBoxResult_KRS.Text = Convert.ToString(ds.GetMatrix(matrix, c, k, l));
                }
                else
                {
                    MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonInfo_KRS_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonDone_KRS_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_KRS.ToolTipTitle = "Выполнить";
        }

        private void buttonInfo_KRS_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_KRS.ToolTipTitle = "Справка";
        }
    }
}
