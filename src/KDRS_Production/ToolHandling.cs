using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KDRS_Production
{
    public partial class ToolHandling : Form
    {
        public ToolHandling()
        {
            InitializeComponent();

            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(ToolHandling_FormClosing);
        }

        private void btnImportLog_Click(object sender, EventArgs e)
        {

        }

        private void btnSelectLog_Click(object sender, EventArgs e)
        {
            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
                txtBxLogPath.Text = openFileDialog1.FileName;
        }

        private void ToolHandling_FormClosing(Object sender, FormClosingEventArgs e)
        {
            Console.WriteLine("Closing form");
        }
    }
}
