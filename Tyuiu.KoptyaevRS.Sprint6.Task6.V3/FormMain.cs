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
using Tyuiu.KoptyaevRS.Sprint6.Task6.V3.Lib;

namespace Tyuiu.KoptyaevRS.Sprint6.Task6.V3
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        string openFilePath;
        DataService ds = new DataService();


        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialogTask.ShowDialog();
            openFilePath = openFileDialogTask.FileName;
            textBoxInPut_KRS.Text = File.ReadAllText(openFilePath);
            groupBoxInPut_KRS.Text = groupBoxInPut_KRS.Text + " " + openFileDialogTask.FileName;
            buttonDone_KRS.Enabled = true;
        }

        private void buttonInfo_KRS_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonDone_KRS_Click(object sender, EventArgs e)
        {
            string str = "r";
            textBoxOutPut_KRS.Text = ds.CollectTextFromFile(str, openFilePath);
        }
    }
}
