using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wow_Syncronizer
{
    public partial class FormAddictDbBackup : Form
    {
        Orchestrator mOrch;
         public FormAddictDbBackup(Orchestrator orch)
        {
            InitializeComponent();
            mOrch = orch;
        }

         public void Fill(List<String> fileList)
        {
            listBox1.Items.Clear();
            for (int i = 0; i < fileList.Count; i++)
            {
                listBox1.Items.Add(fileList[i]);
            }
            listBox1.SelectedIndex = 0;
        }

        private void createBackupFile(string folder, string fileName)
        {
            mOrch.CreateBackupFile(folder, fileName);
            richTextBoxLog.AppendText("Backed up "+ folder + "\\" + fileName + "\n");
        }

        private void buttonBackup_Click(object sender, EventArgs e)
        {
            richTextBoxLog.Clear();
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                createBackupFile(listBox1.Items[i].ToString(), "AddictDB.lua");
            }
        }

        private void buttonRecount_Click(object sender, EventArgs e)
        {

        }
    }
}
