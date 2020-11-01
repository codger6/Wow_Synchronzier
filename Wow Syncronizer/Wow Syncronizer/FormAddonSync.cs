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
    public partial class FormAddonSync : Form
    {
        private List<WarcraftAltDataRecord> recordList = new List<WarcraftAltDataRecord>();
        private Orchestrator mOrch;
        public bool NeedsDataFilled { get; set; }
        public bool checkedAddons { get; set; }
        public bool checkedChatCache { get; set; }
        public bool checkedConfigCache { get; set; }
        public bool checkedLayout { get; set; }
        public bool checkedMacros { get; set; }
        public bool DebugOn { get; set; }
        public bool CreateBackupFilesDuringSync { get; set; }

        public FormAddonSync(Orchestrator orch)
        {
            InitializeComponent();
            mOrch = orch;
            NeedsDataFilled = true;
            checkedAddons = checkBoxAddOns.Checked;
            checkedChatCache = checkBoxChatCache.Checked;
            checkedConfigCache = checkBoxConfigCache.Checked;
            checkedLayout = checkBoxLayout.Checked;
            checkedMacros = checkBoxMacros.Checked;
            DebugOn = checkBoxDebugOnly.Checked;
            CreateBackupFilesDuringSync = checkBoxCreateBackupFiles.Checked;
        }

        private System.Windows.Forms.Control GetControl(string controlName)
        {
            System.Windows.Forms.Control control = null;
            System.Windows.Forms.Control[] controls = this.Controls.Find(controlName, true);
            foreach (System.Windows.Forms.Control c in controls)
            {
                if (c.Name == controlName)
                {
                    control = c;
                }
            }
            return control;
        }

        public virtual bool ShowAlt(WarcraftAltDataRecord record, string activeAcct)
        {
            bool status = true;
            if (record.AltName.Length == 0) return false;
            return status;
        }

        public void Fill(WowSyncData serializableData, string activeAccount)
        {
            int tempAcct = 0;
            if (serializableData != null && serializableData.WowFolder != null && serializableData.WowFolder.Length > 0 && NeedsDataFilled)
            {
                // create a list of records with valid data
                recordList.Clear();

                for (int iAlt = 0; iAlt < WowSyncData.MAX_NUM_OF_ALTS; iAlt++)
                {
                    string serverName = serializableData.AltRecords[iAlt].AltServer;
                    if (ShowAlt(serializableData.AltRecords[iAlt], activeAccount))
                    {
                        recordList.Add(serializableData.AltRecords[iAlt]);
                    }
                }
                // Create the controls
                FillControls(recordList, tempAcct);
            }
        }

        private string padSpaces(string oldString, int numSpaces)
        {
            String newString = oldString;
            while (newString.Length < numSpaces)
            {
                newString += " ";
            }
            return newString;
        }

        public void LogText(string text, bool addCr=true)
        {
            richTextBoxLog.AppendText(text);
            if (addCr) richTextBoxLog.AppendText("\n");
        }

        private void FillControls(List<WarcraftAltDataRecord> records, int acctNum)
        {
            comboBox1.Items.Clear();
            checkedListBox1.Items.Clear();
            for (int iAlt = 0; iAlt < records.Count; iAlt++)
            {
                string alt = padSpaces(records[iAlt].AltName, 15) + padSpaces(records[iAlt].AltServer,25) + padSpaces(records[iAlt].AltAccount,12);
                comboBox1.Items.Add(alt);
                checkedListBox1.Items.Add(alt);
            }
            comboBox1.SelectedIndex = 0;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            for(int i=0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, checkBox1.Checked);
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox3.Items.Count; i++)
            {
                checkedListBox3.SetItemChecked(i, checkBox3.Checked);
            }
        }

        private void buttonGetAddonConfigs_Click(object sender, EventArgs e)
        {
            string[] ConfigFiles = new string[100];
            string path = recordList[comboBox1.SelectedIndex].AltPath;
            path += "\\" + recordList[comboBox1.SelectedIndex].AltName;
            path += "\\SavedVariables";
            DirectoryInfo di = new DirectoryInfo(path);
            int numFiles = 0;
            foreach (var fi in di.GetFiles("*.lua"))
            {
                ConfigFiles[numFiles++] = fi.Name;
                checkedListBox3.Items.Add(fi.Name);
            }
        }

        private void CopyFile(string srcPath, string destPath)
        {
            if (File.Exists(srcPath))// && File.Exists(Path.GetDirectoryName(destPath)))
            {
                if (Directory.Exists(Path.GetDirectoryName(destPath)))
                {
                    try
                    {
                        LogText("Copied " + srcPath + "\n    to  " + destPath);
                        if ((srcPath != destPath) && !DebugOn)
                        {
                            File.Copy(srcPath, destPath, true);
                        }
                    }
                    catch (Exception e)
                    {
                        DialogResult result = MessageBox.Show("Caught error copying files " + e.ToString(), "Error Trapped", MessageBoxButtons.AbortRetryIgnore);
                        //if (result == DialogResult.Abort) abort = true;
                    }
                }
                else
                {
                    LogText("          Missing directory " + destPath + "\n");
                }
            }
            else
            {
                LogText("          Missing file " + srcPath + "\n");
            }
        }

        public bool CreateBackupFile(string folder, string fileName)
        {
            bool success = false;
            FileInfo fi = new FileInfo(Path.Combine(folder, fileName));
            string srcPath = fi.FullName;
            string destFile = Path.GetFileNameWithoutExtension(srcPath) + "_" + DateTime.Now.Month.ToString() + "_" + DateTime.Now.Day.ToString() + "_" + DateTime.Now.Year.ToString() + fi.Extension;
            string destPath = Path.Combine(folder, destFile);
            LogText("Backup File:  ", false);
            if (!File.Exists(destPath))
            {
                CopyFile(srcPath, destPath);
                success = true;
            }
            else
            {
                LogText("File existed so did not backup: " + destPath);
            }
            return success;
        }

        public void SyncAltConfigFiles(string masterPath, string slavePath)
        {
            string addonsFileName = "AddOns.txt";
            string chatFileName = "chat-cache.txt";
            string configFileName = "config-cache.wtf";
            string layoutFileName = "layout-local.txt";
            string macrosFileName = "macros-cache.txt";
            if (CreateBackupFilesDuringSync)
            {
                LogText("SyncAcctFiles, creating backups ");
                if (checkedAddons) CreateBackupFile(slavePath, Path.Combine(slavePath,addonsFileName));
                if (checkedChatCache) CreateBackupFile(slavePath, Path.Combine(slavePath, chatFileName));
                if (checkedConfigCache) CreateBackupFile(slavePath, Path.Combine(slavePath, configFileName));
                if (checkedLayout) CreateBackupFile(slavePath, Path.Combine(slavePath, layoutFileName));
                if (checkedMacros) CreateBackupFile(slavePath, Path.Combine(slavePath, macrosFileName));
            }
            if (checkedAddons) CopyFile(Path.Combine(masterPath, addonsFileName), Path.Combine(slavePath, addonsFileName));
            if (checkedChatCache) CopyFile(Path.Combine(masterPath, chatFileName), Path.Combine(slavePath, chatFileName));
            if (checkedConfigCache) CopyFile(Path.Combine(masterPath, configFileName), Path.Combine(slavePath, configFileName));
            if (checkedLayout) CopyFile(Path.Combine(masterPath, layoutFileName), Path.Combine(slavePath, layoutFileName));
            if (checkedMacros) CopyFile(Path.Combine(masterPath, macrosFileName), Path.Combine(slavePath, macrosFileName));
        }

        private void buttonDoAltConfigCopy_Click(object sender, EventArgs e)
        {
            // this code is kinda funky but there is a 1:1 relation between records, comboBoxItems and checkedListBox1.Items
            foreach(int indexChecked in checkedListBox1.CheckedIndices)
            {
                string master = recordList[comboBox1.SelectedIndex].AltPath + "\\" + recordList[comboBox1.SelectedIndex].AltName;
                string slave = recordList[indexChecked].AltPath + "\\" + recordList[indexChecked].AltName;
                SyncAltConfigFiles(master, slave);
            }
        }

        private void buttonDoAddonCopy_Click(object sender, EventArgs e)
        {

        }

        private void checkBoxAddOns_CheckedChanged(object sender, EventArgs e)
        {
            checkedAddons = checkBoxAddOns.Checked;
        }

        private void checkBoxChatCache_CheckedChanged(object sender, EventArgs e)
        {
            checkedChatCache = checkBoxChatCache.Checked;
        }

        private void checkBoxConfigCache_CheckedChanged(object sender, EventArgs e)
        {
            checkedConfigCache = checkBoxConfigCache.Checked;
        }

        private void checkBoxLayout_CheckedChanged(object sender, EventArgs e)
        {
            checkedLayout = checkBoxLayout.Checked;
        }

        private void checkBoxMacros_CheckedChanged(object sender, EventArgs e)
        {
            checkedMacros = checkBoxMacros.Checked;

        }

        private void checkBoxCreateBackupFiles_CheckedChanged(object sender, EventArgs e)
        {
            CreateBackupFilesDuringSync = checkBoxCreateBackupFiles.Checked;
        }

        private void checkBoxDebugOnly_CheckedChanged(object sender, EventArgs e)
        {
            DebugOn = checkBoxDebugOnly.Checked;
        }
    }
}
