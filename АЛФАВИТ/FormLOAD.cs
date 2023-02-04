using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace АЛФАВИТ
{
    public partial class FormLOAD : Form
    {
        public FormLOAD()
        {
            InitializeComponent();
            this.ControlBox = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
                timer1.Enabled = true;
                timer1.Interval = 20;
                if (progressBar1.Value != 100)
                {
                    progressBar1.Value += 5;
                }
                else if (progressBar1.Value == 100)
                {
                    timer1.Enabled = false;
                    this.Hide();
                    //
                    Form1 START = new Form1();
                    //frm.ShowDialog();
                    START.Show();
                // Application.Exit();
                //  this.Close();
            }
        }

        private void backgroundWorker1_DoWork_1(object sender, DoWorkEventArgs e)
        {
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = true;
        }
    
    }
}
