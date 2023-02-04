using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using АЛФАВИТ.Properties;
using static System.Net.Mime.MediaTypeNames;
using Image = System.Drawing.Image;

namespace АЛФАВИТ
{
   
    public partial class Form2 : Form
         
    {

        public Form2()
        {
            InitializeComponent();

           // pictureBox1.Image = Image.FromFile(@"bin\Debug\ad.jpg");
            //pictureBox1.Image = new Bitmap(@"D:\ANDROIDSTUD\fotoPROJ\ad.png");
            //Image image = Image.FromFile(@"..\..\Pictures\" + text + ".png");
           // this.pictureBox1.Image = image;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Glassnoe = new Glassnoe();
            Glassnoe.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form SoGlassnoe = new SoGlassnoe();
            SoGlassnoe.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form AYA = new AYA();
            AYA.Show();
        }

       
    }
}
