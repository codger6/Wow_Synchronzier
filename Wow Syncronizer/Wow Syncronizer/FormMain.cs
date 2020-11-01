using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wow_Syncronizer
{
    public partial class FormMain : Form
    {
        private Orchestrator mOrch;
        private bool checkedAddons { get; set; }
        private bool checkedChatCache { get; set; }
        private bool checkedConfigCache { get; set; }
        private bool checkedLayout { get; set; }
        private bool checkedMacros { get; set; }
        private bool showHiddenControls { get; set; }

        public FormMain()
        {
            InitializeComponent();
            AppDomain.CurrentDomain.ProcessExit += new EventHandler(OnProcessExit);
            mOrch = new Orchestrator(this);
            this.tabControl1.Selecting +=  new TabControlCancelEventHandler(TabControl1_Selecting);
            this.textBoxWowFolder.Click += new System.EventHandler(this.TextBoxWowFolderOnClick);
            this.textBoxMasterAltPath.Click += new System.EventHandler(this.TextBoxMasterAltOnClick);
            this.textBoxSlaveAlt1Path.Click += new System.EventHandler(this.TextBoxSlaveAlt1PathOnClick);
            this.textBoxSlaveAlt2Path.Click += new System.EventHandler(this.TextBoxSlaveAlt2PathOnClick);
            this.textBoxSlaveAlt3Path.Click += new System.EventHandler(this.TextBoxSlaveAlt3PathOnClick);
            this.textBoxSlaveAlt4Path.Click += new System.EventHandler(this.TextBoxSlaveAlt4PathOnClick);
            this.textBoxSlaveAlt5Path.Click += new System.EventHandler(this.TextBoxSlaveAlt5PathOnClick);
            this.showHiddenControls = false;
            groupBoxRestore.Visible = showHiddenControls;
            UpdateLabels();
            checkBoxCreateBackupFiles.Checked = mOrch.CreateBackupFilesDuringSync;
            checkBoxDebugOnly.Checked = mOrch.DebugOn;
            SetToolStripText("Ready");
        }

        #region EventHandlers
        private void TabControl1_Selecting(object sender, EventArgs e)
        {
            mOrch.ClearLogText();
            SetToolStripText("Ready.");
        }
        
        private void TextBoxWowFolderOnClick(object sender, EventArgs e)
        {
            mOrch.SetWowFolderPath();
            textBoxWowFolder.Text = mOrch.WowFolderPath;
            SetToolStripText("App directory path set to: " + mOrch.WowFolderPath);
        }

        private void TextBoxMasterAltOnClick(object sender, EventArgs e)
        {
            mOrch.SetMBMasterPath();
            UpdateLabels();
        }

        private void TextBoxSlaveAlt1PathOnClick(object sender, EventArgs e)
        {
            mOrch.SetMBSlavePath(0);
            UpdateLabels();
        }

        private void TextBoxSlaveAlt2PathOnClick(object sender, EventArgs e)
        {
            mOrch.SetMBSlavePath(1);
            UpdateLabels();
        }

        private void TextBoxSlaveAlt3PathOnClick(object sender, EventArgs e)
        {
            mOrch.SetMBSlavePath(2);
            UpdateLabels();
        }
        
        private void TextBoxSlaveAlt4PathOnClick(object sender, EventArgs e)
        {
            mOrch.SetMBSlavePath(3);
            UpdateLabels();
        }

        private void TextBoxSlaveAlt5PathOnClick(object sender, EventArgs e)
        {
            mOrch.SetMBSlavePath(4);
            UpdateLabels();
        }

        private void buttonSyncFiles_Click(object sender, EventArgs e)
        {
            mOrch.MultiBoxDoSync();
        }

        private void buttonSyncAccts_Click(object sender, EventArgs e)
        {
            if(textBoxMasterAcct.TextLength==0)
            {
                SetToolStripText("No master account has been selected.");
            }
            else if (checkBoxSlaveAcct1.Checked && textBoxSlaveAcct1.TextLength == 0)
            {
                SetToolStripText("Slave account 1 is selected but no account info is entered.");
            }
            else if (checkBoxSlaveAcct2.Checked && textBoxSlaveAcct2.TextLength == 0)
            {
                SetToolStripText("Slave account 2 is selected but no account info is entered.");
            }
            else if (checkBoxSlaveAcct3.Checked && textBoxSlaveAcct3.TextLength == 0)
            {
                SetToolStripText("Slave account 3 is selected but no account info is entered.");
            }
            else if (checkBoxSlaveAcct4.Checked && textBoxSlaveAcct4.TextLength == 0)
            {
                SetToolStripText("Slave account 4 is selected but no account info is entered.");
            }
            else if (checkBoxSlaveAcct5.Checked && textBoxSlaveAcct5.TextLength==0)
            {
                SetToolStripText("Slave account 5 is selected but no account info is entered.");
            }
            else
            {
                if (checkBoxSyncBinding.Checked || checkBoxSyncConfig.Checked || checkBoxSyncMacros.Checked)
                {
                    if (checkBoxDebugOnly.Checked)
                    {
                        SetToolStripText("Debug is on, account files have not been changed.  Log contains info for potential changes.");
                    }
                    if (!mOrch.DoAcctSync())
                    {
                        SetToolStripText("Error!  Account files have not been changed.  See Log for details!");
                    }
                }
                else
                {
                    SetToolStripText("No files selected to sync.  Nothing changed!");
                }
            }
        }

        private void checkBoxCreateBackupFiles_CheckedChanged(object sender, EventArgs e)
        {
            mOrch.CreateBackupFilesDuringSync = checkBoxCreateBackupFiles.Checked;
        }

        private void checkBoxSlaveAcct1_CheckedChanged(object sender, EventArgs e)
        {
            mOrch.SelectedSlaveAccounts[0] = checkBoxSlaveAcct1.Checked;
        }

        private void checkBoxSlaveAcct2_CheckedChanged(object sender, EventArgs e)
        {
            mOrch.SelectedSlaveAccounts[1] = checkBoxSlaveAcct2.Checked;
        }

        private void checkBoxSlaveAcct3_CheckedChanged(object sender, EventArgs e)
        {
            mOrch.SelectedSlaveAccounts[2] = checkBoxSlaveAcct3.Checked;
        }

        private void checkBoxSlaveAcct4_CheckedChanged(object sender, EventArgs e)
        {
            mOrch.SelectedSlaveAccounts[3] = checkBoxSlaveAcct4.Checked;
        }

        private void checkBoxSlaveAcct5_CheckedChanged(object sender, EventArgs e)
        {
            mOrch.SelectedSlaveAccounts[4] = checkBoxSlaveAcct5.Checked;
        }

        private void checkBoxSlaveAlt1_CheckedChanged(object sender, EventArgs e)
        {
            mOrch.SelectedSlaveAlts[0] = checkBoxSlaveAlt1.Checked;
        }

        private void checkBoxSlaveAlt2_CheckedChanged(object sender, EventArgs e)
        {
            mOrch.SelectedSlaveAlts[1] = checkBoxSlaveAlt2.Checked;
        }

        private void checkBoxSlaveAlt3_CheckedChanged(object sender, EventArgs e)
        {
            mOrch.SelectedSlaveAlts[2] = checkBoxSlaveAlt3.Checked;
        }

        private void checkBoxSlaveAlt4_CheckedChanged(object sender, EventArgs e)
        {
            mOrch.SelectedSlaveAlts[3] = checkBoxSlaveAlt4.Checked;
        }

        private void checkBoxSlaveAlt5_CheckedChanged(object sender, EventArgs e)
        {
            mOrch.SelectedSlaveAlts[4] = checkBoxSlaveAlt5.Checked;
        }

        private void checkBoxDebugOnly_CheckedChanged(object sender, EventArgs e)
        {
            mOrch.DebugOn = checkBoxDebugOnly.Checked;
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

        private void buttonDoAltConfigCopy_Click(object sender, EventArgs e)
        {
            mOrch.ClearLogText();
            if (checkedListBox1.CheckedItems.Count == 0)
            {
                SetToolStripText("No slave Alts have been selected.");
            }
            else
            {
                if (checkedAddons || checkedChatCache || checkedConfigCache || checkedLayout || checkedMacros)
                {
                    foreach (int indexChecked in checkedListBox1.CheckedIndices)
                    {
                        mOrch.DoAltFileSync(comboBox1.SelectedIndex, indexChecked, checkedAddons, checkedChatCache, checkedConfigCache, checkedLayout, checkedMacros);
                    }
                    if (checkBoxDebugOnly.Checked)
                    {
                        SetToolStripText("Debug is on, alt files have not been changed.  Log contains info for potential changes.");
                    }
                    else
                    {
                        SetToolStripText("Alt files have been synced!");
                    }
                }
                else
                {
                    SetToolStripText("No files selected to sync.  Nothing changed!");
                }
            }
        }

        private void buttonViewChangeLog_Click(object sender, EventArgs e)
        {
            mOrch.ViewLog();
        }

        private void textBoxMasterAcct_TextChanged(object sender, EventArgs e)
        {
            mOrch.MasterAccount = textBoxMasterAcct.Text;
        }

        private void textBoxSlaveAcct1_TextChanged(object sender, EventArgs e)
        {
            mOrch.SlaveAccounts[0] = textBoxSlaveAcct1.Text;
        }

        private void textBoxSlaveAcct2_TextChanged(object sender, EventArgs e)
        {
            mOrch.SlaveAccounts[1] = textBoxSlaveAcct2.Text;
        }

        private void textBoxSlaveAcct3_TextChanged(object sender, EventArgs e)
        {
            mOrch.SlaveAccounts[2] = textBoxSlaveAcct3.Text;
        }

        private void textBoxSlaveAcct4_TextChanged(object sender, EventArgs e)
        {
            mOrch.SlaveAccounts[3] = textBoxSlaveAcct4.Text;
        }

        private void textBoxSlaveAcct5_TextChanged(object sender, EventArgs e)
        {
            mOrch.SlaveAccounts[4] = textBoxSlaveAcct5.Text;
        }

        private void checkBoxAFSSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, checkBoxAFSSelectAll.Checked);
            }
        }

        private void checkBoxSelectAllAltCfg_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxAddOns.Checked = checkBoxSelectAllAltCfg.Checked;
            checkBoxChatCache.Checked = checkBoxSelectAllAltCfg.Checked;
            checkBoxConfigCache.Checked = checkBoxSelectAllAltCfg.Checked;
            checkBoxLayout.Checked = checkBoxSelectAllAltCfg.Checked;
            checkBoxMacros.Checked = checkBoxSelectAllAltCfg.Checked;
        }

        #endregion // event handlers

        #region MenuItems

        private void viewLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mOrch.ViewLog();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseThis();
        }

        private void showHiddenControlsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showHiddenControls = !showHiddenControls;
            groupBoxRestore.Visible = showHiddenControls;
        }

        private void addonSyncToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mOrch.ShowAddonSyncForm();
        }

        private void addictDbBackupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mOrch.ShowAddictDbBackupForm();
        }

        private void wowProPatchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addictDbBackupToolStripMenuItem_Click(sender, e);
        }

        #endregion // MenuItems

        private void CloseThis()
        {
            mOrch.OnClose();
            this.Close();
        }

        private void OnProcessExit(object sender, EventArgs e)
        {
            CloseThis();
        }

        public void SetToolStripText(string text)
        {
            toolStripStatusLabel1.Text = text;
        }

        public void UpdateLabels()
        {
            checkBoxDebugOnly.Checked = mOrch.DebugOn;
            textBoxWowFolder.Text = mOrch.WowFolderPath;
            textBoxMasterAcct.Text = mOrch.MasterAccount;
            textBoxSlaveAcct1.Text = mOrch.SlaveAccounts[0];
            textBoxSlaveAcct2.Text = mOrch.SlaveAccounts[1];
            textBoxSlaveAcct3.Text = mOrch.SlaveAccounts[2];
            textBoxSlaveAcct4.Text = mOrch.SlaveAccounts[3];
            textBoxSlaveAcct5.Text = mOrch.SlaveAccounts[4];
            checkBoxSlaveAcct1.Checked = mOrch.SelectedSlaveAccounts[0];
            checkBoxSlaveAcct2.Checked = mOrch.SelectedSlaveAccounts[1];
            checkBoxSlaveAcct3.Checked = mOrch.SelectedSlaveAccounts[2];
            checkBoxSlaveAcct4.Checked = mOrch.SelectedSlaveAccounts[3];
            checkBoxSlaveAcct5.Checked = mOrch.SelectedSlaveAccounts[4];
            textBoxMasterAltPath.Text = mOrch.MasterAltPath;
            textBoxSlaveAlt1Path.Text = mOrch.SlaveAltPaths[0];
            textBoxSlaveAlt2Path.Text = mOrch.SlaveAltPaths[1];
            textBoxSlaveAlt3Path.Text = mOrch.SlaveAltPaths[2];
            textBoxSlaveAlt4Path.Text = mOrch.SlaveAltPaths[3];
            textBoxSlaveAlt5Path.Text = mOrch.SlaveAltPaths[4];
            checkBoxSlaveAlt1.Checked = mOrch.SelectedSlaveAlts[0];
            checkBoxSlaveAlt2.Checked = mOrch.SelectedSlaveAlts[1];
            checkBoxSlaveAlt3.Checked = mOrch.SelectedSlaveAlts[2];
            checkBoxSlaveAlt4.Checked = mOrch.SelectedSlaveAlts[3];
            checkBoxSlaveAlt5.Checked = mOrch.SelectedSlaveAlts[4];
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

        public void FillAltSyncControls(List<WarcraftAltDataRecord> records)
        {
            comboBox1.Items.Clear();
            checkedListBox1.Items.Clear();
            for (int iAlt = 0; iAlt < records.Count; iAlt++)
            {
                string alt = padSpaces(records[iAlt].AltName, 15) + padSpaces(records[iAlt].AltServer, 25) + padSpaces(records[iAlt].AltAccount, 12);
                comboBox1.Items.Add(alt);
                checkedListBox1.Items.Add(alt);
            }
            comboBox1.SelectedIndex = 0;
        }


        private void checkBoxRestore_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonRestore_Click(object sender, EventArgs e)
        {
            mOrch.ClearLogText();
            if (checkedListBox1.SelectedItems.Count == 0)
            {
                SetToolStripText("No slave Alts have been selected.");
            }
            else
            {
                if (checkedAddons || checkedChatCache || checkedConfigCache || checkedLayout || checkedMacros)
                {
                    foreach (int indexChecked in checkedListBox1.CheckedIndices)
                    {
                        mOrch.DoAltFileSync(comboBox1.SelectedIndex, indexChecked, checkedAddons, checkedChatCache, checkedConfigCache, checkedLayout, checkedMacros);
                    }
                    if (checkBoxDebugOnly.Checked)
                    {
                        SetToolStripText("Debug is on, alt files have not been changed.  Log contains info for potential changes.");
                    }
                    else
                    {
                        SetToolStripText("Alt files have been synced!");
                    }
                }
                else
                {
                    SetToolStripText("No files selected to sync.  Nothing changed!");
                }
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 box = new AboutBox1();
            box.ShowDialog();
        }
    }
}
