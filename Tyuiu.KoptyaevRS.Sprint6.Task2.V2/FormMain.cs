using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.KoptyaevRS.Sprint6.Task2.V2.Lib;

namespace Tyuiu.KoptyaevRS.Sprint6.Task2.V2
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        private void buttonDoen_KRS_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStart_KRS.Text);
                int stopStep = Convert.ToInt32(textBoxStop_KRS.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);

                this.chartFunction_KRS.Titles.Add("График функции sin(x)");

                this.chartFunction_KRS.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_KRS.ChartAreas[0].AxisY.Title = "Ось Y";

                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridViewFunction_KRS.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));

                    this.chartFunction_KRS.Series[0].Points.AddXY(startStep, valueArray[i]);

                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDoen_KRS_MouseEnter(object sender, EventArgs e)
        {
            buttonDoen_KRS.BackColor = Color.Red;
        }

        private void buttonDoen_KRS_MouseLeave(object sender, EventArgs e)
        {
            buttonDoen_KRS.BackColor = Color.Green;
        }

        private void buttonDoen_KRS_MouseDown(object sender, MouseEventArgs e)
        {
            buttonDoen_KRS.BackColor = Color.Blue;
        }

        private void buttonInfo_KRS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнил студент группы АСОиУБ-23-3 Коптяев Рустам Сергеевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
