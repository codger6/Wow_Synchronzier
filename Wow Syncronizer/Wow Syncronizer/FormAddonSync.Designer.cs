namespace Wow_Syncronizer
{
    partial class FormAddonSync
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddonSync));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelMasterAlt = new System.Windows.Forms.Label();
            this.labelSlaveAlts = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.buttonGetAddonConfigs = new System.Windows.Forms.Button();
            this.checkedListBox3 = new System.Windows.Forms.CheckedListBox();
            this.labelAltAddonConfigFiles = new System.Windows.Forms.Label();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.labelAltConfigDesc = new System.Windows.Forms.Label();
            this.labelAddonDesc = new System.Windows.Forms.Label();
            this.buttonDoAltConfigCopy = new System.Windows.Forms.Button();
            this.buttonDoAddonCopy = new System.Windows.Forms.Button();
            this.richTextBoxLog = new System.Windows.Forms.RichTextBox();
            this.labelLog = new System.Windows.Forms.Label();
            this.checkBoxAddOns = new System.Windows.Forms.CheckBox();
            this.checkBoxChatCache = new System.Windows.Forms.CheckBox();
            this.checkBoxConfigCache = new System.Windows.Forms.CheckBox();
            this.checkBoxLayout = new System.Windows.Forms.CheckBox();
            this.checkBoxMacros = new System.Windows.Forms.CheckBox();
            this.groupBoxAltFiles = new System.Windows.Forms.GroupBox();
            this.checkBoxCreateBackupFiles = new System.Windows.Forms.CheckBox();
            this.checkBoxDebugOnly = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBoxAltFiles.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(2283, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(50, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(123, 30);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 1111);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(2283, 30);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(179, 25);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.Font = new System.Drawing.Font("Courier New", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(27, 167);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(970, 463);
            this.checkedListBox1.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Courier New", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(149, 58);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(848, 32);
            this.comboBox1.TabIndex = 3;
            // 
            // labelMasterAlt
            // 
            this.labelMasterAlt.AutoSize = true;
            this.labelMasterAlt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMasterAlt.Location = new System.Drawing.Point(22, 58);
            this.labelMasterAlt.Name = "labelMasterAlt";
            this.labelMasterAlt.Size = new System.Drawing.Size(110, 26);
            this.labelMasterAlt.TabIndex = 4;
            this.labelMasterAlt.Text = "Master Alt";
            // 
            // labelSlaveAlts
            // 
            this.labelSlaveAlts.AutoSize = true;
            this.labelSlaveAlts.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSlaveAlts.Location = new System.Drawing.Point(22, 118);
            this.labelSlaveAlts.Name = "labelSlaveAlts";
            this.labelSlaveAlts.Size = new System.Drawing.Size(110, 26);
            this.labelSlaveAlts.TabIndex = 5;
            this.labelSlaveAlts.Text = "Slave Alts";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(149, 117);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(130, 30);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Select All";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // buttonGetAddonConfigs
            // 
            this.buttonGetAddonConfigs.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGetAddonConfigs.Location = new System.Drawing.Point(1943, 121);
            this.buttonGetAddonConfigs.Name = "buttonGetAddonConfigs";
            this.buttonGetAddonConfigs.Size = new System.Drawing.Size(83, 41);
            this.buttonGetAddonConfigs.TabIndex = 10;
            this.buttonGetAddonConfigs.Text = "Get";
            this.buttonGetAddonConfigs.UseVisualStyleBackColor = true;
            this.buttonGetAddonConfigs.Click += new System.EventHandler(this.buttonGetAddonConfigs_Click);
            // 
            // checkedListBox3
            // 
            this.checkedListBox3.Font = new System.Drawing.Font("Courier New", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox3.FormattingEnabled = true;
            this.checkedListBox3.Location = new System.Drawing.Point(1685, 200);
            this.checkedListBox3.Name = "checkedListBox3";
            this.checkedListBox3.Size = new System.Drawing.Size(570, 436);
            this.checkedListBox3.TabIndex = 11;
            // 
            // labelAltAddonConfigFiles
            // 
            this.labelAltAddonConfigFiles.AutoSize = true;
            this.labelAltAddonConfigFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAltAddonConfigFiles.Location = new System.Drawing.Point(1677, 121);
            this.labelAltAddonConfigFiles.Name = "labelAltAddonConfigFiles";
            this.labelAltAddonConfigFiles.Size = new System.Drawing.Size(228, 26);
            this.labelAltAddonConfigFiles.TabIndex = 12;
            this.labelAltAddonConfigFiles.Text = "Alt Addon Config Files";
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox3.Location = new System.Drawing.Point(1682, 164);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(130, 30);
            this.checkBox3.TabIndex = 14;
            this.checkBox3.Text = "Select All";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // labelAltConfigDesc
            // 
            this.labelAltConfigDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAltConfigDesc.Location = new System.Drawing.Point(1040, 56);
            this.labelAltConfigDesc.Name = "labelAltConfigDesc";
            this.labelAltConfigDesc.Size = new System.Drawing.Size(572, 181);
            this.labelAltConfigDesc.TabIndex = 15;
            this.labelAltConfigDesc.Text = resources.GetString("labelAltConfigDesc.Text");
            // 
            // labelAddonDesc
            // 
            this.labelAddonDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddonDesc.Location = new System.Drawing.Point(1680, 57);
            this.labelAddonDesc.Name = "labelAddonDesc";
            this.labelAddonDesc.Size = new System.Drawing.Size(572, 43);
            this.labelAddonDesc.TabIndex = 16;
            this.labelAddonDesc.Text = "This copies various addon config files";
            // 
            // buttonDoAltConfigCopy
            // 
            this.buttonDoAltConfigCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDoAltConfigCopy.Location = new System.Drawing.Point(78, 253);
            this.buttonDoAltConfigCopy.Name = "buttonDoAltConfigCopy";
            this.buttonDoAltConfigCopy.Size = new System.Drawing.Size(129, 41);
            this.buttonDoAltConfigCopy.TabIndex = 17;
            this.buttonDoAltConfigCopy.Tag = " ";
            this.buttonDoAltConfigCopy.Text = "Sync";
            this.buttonDoAltConfigCopy.UseVisualStyleBackColor = true;
            this.buttonDoAltConfigCopy.Click += new System.EventHandler(this.buttonDoAltConfigCopy_Click);
            // 
            // buttonDoAddonCopy
            // 
            this.buttonDoAddonCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDoAddonCopy.Location = new System.Drawing.Point(2052, 121);
            this.buttonDoAddonCopy.Name = "buttonDoAddonCopy";
            this.buttonDoAddonCopy.Size = new System.Drawing.Size(129, 41);
            this.buttonDoAddonCopy.TabIndex = 18;
            this.buttonDoAddonCopy.Text = "Do Copy";
            this.buttonDoAddonCopy.UseVisualStyleBackColor = true;
            this.buttonDoAddonCopy.Click += new System.EventHandler(this.buttonDoAddonCopy_Click);
            // 
            // richTextBoxLog
            // 
            this.richTextBoxLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxLog.Location = new System.Drawing.Point(24, 701);
            this.richTextBoxLog.Name = "richTextBoxLog";
            this.richTextBoxLog.Size = new System.Drawing.Size(2231, 391);
            this.richTextBoxLog.TabIndex = 19;
            this.richTextBoxLog.Text = "";
            // 
            // labelLog
            // 
            this.labelLog.AutoSize = true;
            this.labelLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLog.Location = new System.Drawing.Point(32, 657);
            this.labelLog.Name = "labelLog";
            this.labelLog.Size = new System.Drawing.Size(54, 29);
            this.labelLog.TabIndex = 20;
            this.labelLog.Text = "Log";
            // 
            // checkBoxAddOns
            // 
            this.checkBoxAddOns.AutoSize = true;
            this.checkBoxAddOns.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxAddOns.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAddOns.Location = new System.Drawing.Point(105, 43);
            this.checkBoxAddOns.Name = "checkBoxAddOns";
            this.checkBoxAddOns.Size = new System.Drawing.Size(146, 30);
            this.checkBoxAddOns.TabIndex = 21;
            this.checkBoxAddOns.Text = "AddOns.txt";
            this.checkBoxAddOns.UseVisualStyleBackColor = true;
            this.checkBoxAddOns.CheckedChanged += new System.EventHandler(this.checkBoxAddOns_CheckedChanged);
            // 
            // checkBoxChatCache
            // 
            this.checkBoxChatCache.AutoSize = true;
            this.checkBoxChatCache.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxChatCache.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxChatCache.Location = new System.Drawing.Point(78, 79);
            this.checkBoxChatCache.Name = "checkBoxChatCache";
            this.checkBoxChatCache.Size = new System.Drawing.Size(173, 30);
            this.checkBoxChatCache.TabIndex = 22;
            this.checkBoxChatCache.Text = "chat-cache.txt";
            this.checkBoxChatCache.UseVisualStyleBackColor = true;
            this.checkBoxChatCache.CheckedChanged += new System.EventHandler(this.checkBoxChatCache_CheckedChanged);
            // 
            // checkBoxConfigCache
            // 
            this.checkBoxConfigCache.AutoSize = true;
            this.checkBoxConfigCache.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxConfigCache.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxConfigCache.Location = new System.Drawing.Point(56, 115);
            this.checkBoxConfigCache.Name = "checkBoxConfigCache";
            this.checkBoxConfigCache.Size = new System.Drawing.Size(195, 30);
            this.checkBoxConfigCache.TabIndex = 23;
            this.checkBoxConfigCache.Text = "config-cache.wtf";
            this.checkBoxConfigCache.UseVisualStyleBackColor = true;
            this.checkBoxConfigCache.CheckedChanged += new System.EventHandler(this.checkBoxConfigCache_CheckedChanged);
            // 
            // checkBoxLayout
            // 
            this.checkBoxLayout.AutoSize = true;
            this.checkBoxLayout.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxLayout.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxLayout.Location = new System.Drawing.Point(74, 151);
            this.checkBoxLayout.Name = "checkBoxLayout";
            this.checkBoxLayout.Size = new System.Drawing.Size(177, 30);
            this.checkBoxLayout.TabIndex = 24;
            this.checkBoxLayout.Text = "layout-local.txt";
            this.checkBoxLayout.UseVisualStyleBackColor = true;
            this.checkBoxLayout.CheckedChanged += new System.EventHandler(this.checkBoxLayout_CheckedChanged);
            // 
            // checkBoxMacros
            // 
            this.checkBoxMacros.AutoSize = true;
            this.checkBoxMacros.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxMacros.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxMacros.Location = new System.Drawing.Point(47, 187);
            this.checkBoxMacros.Name = "checkBoxMacros";
            this.checkBoxMacros.Size = new System.Drawing.Size(204, 30);
            this.checkBoxMacros.TabIndex = 25;
            this.checkBoxMacros.Text = "macros-cache.txt";
            this.checkBoxMacros.UseVisualStyleBackColor = true;
            this.checkBoxMacros.CheckedChanged += new System.EventHandler(this.checkBoxMacros_CheckedChanged);
            // 
            // groupBoxAltFiles
            // 
            this.groupBoxAltFiles.Controls.Add(this.checkBoxConfigCache);
            this.groupBoxAltFiles.Controls.Add(this.checkBoxMacros);
            this.groupBoxAltFiles.Controls.Add(this.checkBoxAddOns);
            this.groupBoxAltFiles.Controls.Add(this.checkBoxLayout);
            this.groupBoxAltFiles.Controls.Add(this.buttonDoAltConfigCopy);
            this.groupBoxAltFiles.Controls.Add(this.checkBoxChatCache);
            this.groupBoxAltFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxAltFiles.Location = new System.Drawing.Point(1048, 257);
            this.groupBoxAltFiles.Name = "groupBoxAltFiles";
            this.groupBoxAltFiles.Size = new System.Drawing.Size(337, 322);
            this.groupBoxAltFiles.TabIndex = 26;
            this.groupBoxAltFiles.TabStop = false;
            this.groupBoxAltFiles.Text = "Alt Config Files to Sync";
            // 
            // checkBoxCreateBackupFiles
            // 
            this.checkBoxCreateBackupFiles.AutoSize = true;
            this.checkBoxCreateBackupFiles.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxCreateBackupFiles.Checked = true;
            this.checkBoxCreateBackupFiles.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCreateBackupFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxCreateBackupFiles.Location = new System.Drawing.Point(638, 117);
            this.checkBoxCreateBackupFiles.Name = "checkBoxCreateBackupFiles";
            this.checkBoxCreateBackupFiles.Size = new System.Drawing.Size(359, 30);
            this.checkBoxCreateBackupFiles.TabIndex = 27;
            this.checkBoxCreateBackupFiles.Text = "Create Backup Files During Sync";
            this.checkBoxCreateBackupFiles.UseVisualStyleBackColor = true;
            this.checkBoxCreateBackupFiles.CheckedChanged += new System.EventHandler(this.checkBoxCreateBackupFiles_CheckedChanged);
            // 
            // checkBoxDebugOnly
            // 
            this.checkBoxDebugOnly.AutoSize = true;
            this.checkBoxDebugOnly.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxDebugOnly.Checked = true;
            this.checkBoxDebugOnly.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxDebugOnly.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxDebugOnly.Location = new System.Drawing.Point(445, 120);
            this.checkBoxDebugOnly.Name = "checkBoxDebugOnly";
            this.checkBoxDebugOnly.Size = new System.Drawing.Size(143, 30);
            this.checkBoxDebugOnly.TabIndex = 28;
            this.checkBoxDebugOnly.Text = "Debug On ";
            this.checkBoxDebugOnly.UseVisualStyleBackColor = true;
            this.checkBoxDebugOnly.CheckedChanged += new System.EventHandler(this.checkBoxDebugOnly_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(1681, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 32);
            this.label1.TabIndex = 29;
            this.label1.Text = "THIS IS NOT FINISHED";
            // 
            // FormAddonSync
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2283, 1141);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBoxDebugOnly);
            this.Controls.Add(this.checkBoxCreateBackupFiles);
            this.Controls.Add(this.groupBoxAltFiles);
            this.Controls.Add(this.labelLog);
            this.Controls.Add(this.richTextBoxLog);
            this.Controls.Add(this.buttonDoAddonCopy);
            this.Controls.Add(this.labelAddonDesc);
            this.Controls.Add(this.labelAltConfigDesc);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.labelAltAddonConfigFiles);
            this.Controls.Add(this.checkedListBox3);
            this.Controls.Add(this.buttonGetAddonConfigs);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.labelSlaveAlts);
            this.Controls.Add(this.labelMasterAlt);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormAddonSync";
            this.Text = "FormAddonSync";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBoxAltFiles.ResumeLayout(false);
            this.groupBoxAltFiles.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label labelMasterAlt;
        private System.Windows.Forms.Label labelSlaveAlts;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button buttonGetAddonConfigs;
        private System.Windows.Forms.CheckedListBox checkedListBox3;
        private System.Windows.Forms.Label labelAltAddonConfigFiles;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Label labelAltConfigDesc;
        private System.Windows.Forms.Label labelAddonDesc;
        private System.Windows.Forms.Button buttonDoAltConfigCopy;
        private System.Windows.Forms.Button buttonDoAddonCopy;
        private System.Windows.Forms.RichTextBox richTextBoxLog;
        private System.Windows.Forms.Label labelLog;
        private System.Windows.Forms.CheckBox checkBoxAddOns;
        private System.Windows.Forms.CheckBox checkBoxChatCache;
        private System.Windows.Forms.CheckBox checkBoxConfigCache;
        private System.Windows.Forms.CheckBox checkBoxLayout;
        private System.Windows.Forms.CheckBox checkBoxMacros;
        private System.Windows.Forms.GroupBox groupBoxAltFiles;
        private System.Windows.Forms.CheckBox checkBoxCreateBackupFiles;
        private System.Windows.Forms.CheckBox checkBoxDebugOnly;
        private System.Windows.Forms.Label label1;
    }
}