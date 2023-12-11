using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using Tyuiu.KoptyaevRS.Sprint6.Task7.V15.Lib;

namespace Tyuiu.KoptyaevRS.Sprint6.Task7.V15
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            openFileDialogTask_KRS.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialogMatrix_KRS.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }
        static int rows;
        static int columns;
        static string openFilePath;

        DataService ds = new DataService();

        public static int[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);

            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split(';').Length;

            int[,] arrayValues = new int[rows, columns];

            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < columns; c++)
                {
                    arrayValues[r, c] = Convert.ToInt32(line_r[c]);
                }
            }
            return arrayValues;
        }
        private void buttonOpen_KRS_Click(object sender, EventArgs e)
        {
            openFileDialogTask_KRS.ShowDialog();
            openFilePath = openFileDialogTask_KRS.FileName;

            int[,] arrayValues = new int[rows, columns];

            arrayValues = LoadFromFileData(openFilePath);

            dataGridViewIn_KRS.ColumnCount = columns;
            dataGridViewIn_KRS.RowCount = rows;
            dataGridViewOut_KRS.ColumnCount = columns;
            dataGridViewOut_KRS.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewIn_KRS.Columns[i].Width = 25;
                dataGridViewOut_KRS.Columns[i].Width = 25;
            }

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewIn_KRS.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            arrayValues = ds.GetMatrix(LoadFromFileData(openFilePath));
            buttonDone_KRS.Enabled = true;
        }

        private void buttonInfo_KRS_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonDone_KRS_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, columns];
            arrayValues = ds.GetMatrix(LoadFromFileData(openFilePath));

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewOut_KRS.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            buttonSave_KRS.Enabled = true;
        }

        private void buttonSave_KRS_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix_KRS.FileName = "OutPutFileTask7.csv";
            saveFileDialogMatrix_KRS.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix_KRS.ShowDialog();

            string path = saveFileDialogMatrix_KRS.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewOut_KRS.RowCount;
            int columns = dataGridViewOut_KRS.ColumnCount;

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewOut_KRS.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewOut_KRS.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void buttonOpen_KRS_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_KRS.ToolTipTitle = "Открыть файл";
        }

        private void buttonDone_KRS_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_KRS.ToolTipTitle = "Выполнить";
        }

        private void buttonSave_KRS_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_KRS.ToolTipTitle = "Сохранить в файл";
        }

        private void buttonInfo_KRS_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_KRS.ToolTipTitle = "Справка";
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            dataGridViewIn_KRS.ColumnCount = 50;
            dataGridViewOut_KRS.ColumnCount = 50;

            dataGridViewIn_KRS.RowCount = 50;
            dataGridViewOut_KRS.RowCount = 50;

            panelLeft_KRS.Width = this.Width / 2;

            for (int i = 0; i < 50; i++)
            {
                dataGridViewIn_KRS.Columns[i].Width = 25;
                dataGridViewOut_KRS.Columns[i].Width = 25;
            }
        }
    }
}
