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
    public partial class FormLog : Form
    {
        public FormLog()
        {
            InitializeComponent();
        }

        public void ClearLogText()
        {
            richTextBoxLog.Text = "";
        }

        public void SetLogText(string text, bool addCr=true)
        {
            richTextBoxLog.Text += text;
            if (addCr) richTextBoxLog.Text += "\n";
        }
    }
}
