using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace АЛФАВИТ
{
    public partial class OFprogram : Form
    {
        public OFprogram()
        {
            InitializeComponent();
            //RichTextBox. = "";
            textBox1.Text = "Программу разработал Семкин Роман Борисович\r\n студент отделения информационных технологий\r\n группы ИС-32.";
            textBox1.TextAlign = HorizontalAlignment.Center;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            //this.Hide();
            Form back = new Form1();
            back.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
