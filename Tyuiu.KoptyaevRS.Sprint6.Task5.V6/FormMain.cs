using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.KoptyaevRS.Sprint6.Task5.V6.Lib;

namespace Tyuiu.KoptyaevRS.Sprint6.Task5.V6
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string path = @"C:\Users\Сергей\source\repos\Tyuiu.KoptyaevRS.Sprint6\Tyuiu.KoptyaevRS.Sprint6.Task5.V6\bin\Debug\InPutFileTask5V6.txt";

        private void buttonDone_KRS_Click(object sender, EventArgs e)
        {
            dataGridViewNums_KRS.ColumnCount = 2;
            dataGridViewNums_KRS.Columns[0].Width = 20;
            dataGridViewNums_KRS.Columns[1].Width = 50;

            this.chartResult_KRS.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartResult_KRS.ChartAreas[0].AxisY.Title = "Ось Y";

            chartResult_KRS.Series[0].Points.Clear();

            double[] numsMass = new double[ds.len];

            numsMass = ds.LoadFromDataFile(path);

            for (int i = 0; i < numsMass.Length; i++)
            {
                dataGridViewNums_KRS.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                chartResult_KRS.Series[0].Points.AddXY(i, numsMass[i]);
            }
        }

        private void buttonOpen_KRS_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonInfo_KRS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы АСОиУБ-23-3 Коптяев Рустам Сергеевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
