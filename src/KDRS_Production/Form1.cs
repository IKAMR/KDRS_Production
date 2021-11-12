using KDRS_Produksjon;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpenEventLog_Click(object sender, EventArgs e)
        {
            pnlEventLog.Visible = true;

            txtBxEventTime.Text = DateTime.Now.ToString("yyyy.MM.ddTHH:mm:ss");

            cbBxStatus.Items.AddRange( new object[]
            {
                "Godkjent",
                "Godkjent med avvik",
                "Avvik",
                "Avvist"
            });
        }

        private void bntSaveEvent_Click(object sender, EventArgs e)
        {

            Log logger = new Log();

            Event ev = new Event
            {
                TimeStamp = txtBxEventTime.Text,
                ID = txtBxPackID.Text,
                Description = txtBxDescription.Text,
                Status = cbBxStatus.Text,
                Comments= txtBxComments.Text
            };

            string targetPath = txtBxOutPath.Text;

            string dbPath = targetPath + @"\log.sqlite";

            logger.LogEvent(dbPath, ev);
        }
    }
}
