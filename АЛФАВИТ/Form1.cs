﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void начать_Click(object sender, EventArgs e)
        {
           // this.Close();
            this.Hide();
            Form ifr = new Form2();
            ifr.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // this.Close();
            this.Hide();
            Form sprav = new SPRAVKA();
            sprav.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form OFprogram = new OFprogram();
            OFprogram.Show();
        }
    }
}
