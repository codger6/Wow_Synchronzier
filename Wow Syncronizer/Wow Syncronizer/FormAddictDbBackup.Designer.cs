namespace Wow_Syncronizer
{
    partial class FormAddictDbBackup
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.buttonBackup = new System.Windows.Forms.Button();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.richTextBoxLog = new System.Windows.Forms.RichTextBox();
            this.labelBackup = new System.Windows.Forms.Label();
            this.labelWowPro = new System.Windows.Forms.Label();
            this.buttonWowPro = new System.Windows.Forms.Button();
            this.labelRecount = new System.Windows.Forms.Label();
            this.buttonRecount = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 22;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(2129, 500);
            this.listBox1.TabIndex = 1;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.buttonRecount);
            this.splitContainer1.Panel1.Controls.Add(this.labelRecount);
            this.splitContainer1.Panel1.Controls.Add(this.buttonWowPro);
            this.splitContainer1.Panel1.Controls.Add(this.labelWowPro);
            this.splitContainer1.Panel1.Controls.Add(this.labelBackup);
            this.splitContainer1.Panel1.Controls.Add(this.buttonBackup);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(2383, 656);
            this.splitContainer1.SplitterDistance = 250;
            this.splitContainer1.TabIndex = 2;
            // 
            // buttonBackup
            // 
            this.buttonBackup.Location = new System.Drawing.Point(33, 82);
            this.buttonBackup.Name = "buttonBackup";
            this.buttonBackup.Size = new System.Drawing.Size(151, 36);
            this.buttonBackup.TabIndex = 0;
            this.buttonBackup.Text = "Do Backup";
            this.buttonBackup.UseVisualStyleBackColor = true;
            this.buttonBackup.Click += new System.EventHandler(this.buttonBackup_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.listBox1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.richTextBoxLog);
            this.splitContainer2.Size = new System.Drawing.Size(2129, 656);
            this.splitContainer2.SplitterDistance = 500;
            this.splitContainer2.TabIndex = 2;
            // 
            // richTextBoxLog
            // 
            this.richTextBoxLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxLog.Location = new System.Drawing.Point(0, 0);
            this.richTextBoxLog.Name = "richTextBoxLog";
            this.richTextBoxLog.Size = new System.Drawing.Size(2129, 152);
            this.richTextBoxLog.TabIndex = 0;
            this.richTextBoxLog.Text = "";
            // 
            // labelBackup
            // 
            this.labelBackup.AutoSize = true;
            this.labelBackup.Location = new System.Drawing.Point(29, 41);
            this.labelBackup.Name = "labelBackup";
            this.labelBackup.Size = new System.Drawing.Size(187, 20);
            this.labelBackup.TabIndex = 1;
            this.labelBackup.Text = "Create AddictDB Backup";
            // 
            // labelWowPro
            // 
            this.labelWowPro.AutoSize = true;
            this.labelWowPro.Location = new System.Drawing.Point(12, 175);
            this.labelWowPro.Name = "labelWowPro";
            this.labelWowPro.Size = new System.Drawing.Size(213, 20);
            this.labelWowPro.TabIndex = 2;
            this.labelWowPro.Text = "Wow Pro Grail Quest Disable";
            // 
            // labelRecount
            // 
            this.labelRecount.AutoSize = true;
            this.labelRecount.Location = new System.Drawing.Point(19, 318);
            this.labelRecount.Name = "labelRecount";
            this.labelRecount.Size = new System.Drawing.Size(173, 20);
            this.labelRecount.TabIndex = 4;
            this.labelRecount.Text = "Unify Recount Settings";
            // 
            // buttonRecount
            // 
            this.buttonRecount.Location = new System.Drawing.Point(23, 354);
            this.buttonRecount.Name = "buttonRecount";
            this.buttonRecount.Size = new System.Drawing.Size(183, 36);
            this.buttonRecount.TabIndex = 5;
            this.buttonRecount.Text = "Recount Settings";
            this.buttonRecount.UseVisualStyleBackColor = true;
            this.buttonRecount.Click += new System.EventHandler(this.buttonRecount_Click);
            // 
            // FormAddictDbBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2383, 656);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FormAddictDbBackup";
            this.Text = "FormAddictDbBackup";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button buttonBackup;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.RichTextBox richTextBoxLog;
        private System.Windows.Forms.Button buttonWowPro;
        private System.Windows.Forms.Label labelWowPro;
        private System.Windows.Forms.Label labelBackup;
        private System.Windows.Forms.Button buttonRecount;
        private System.Windows.Forms.Label labelRecount;
    }
}