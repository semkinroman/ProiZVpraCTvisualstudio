using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace АЛФАВИТ
{
    public partial class Glassnoe : Form
    {
        int kum = 0;
        Timer timer1 = new Timer();
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();

        public Glassnoe()
        {
            InitializeComponent();
            pictureBox1.BackColor = Color.Transparent;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            //this.Hide();
            Form back = new Form2();
            back.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                timer.Interval = 4000; // here time in milliseconds
                timer.Tick += timer_Tick;
                timer.Start();
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;// place get random code here

                if (kum == 11)
                    kum -= 11;
                if (kum < 11)

                    kum++;
                {
                    if (kum == 1) pictureBox1.BackgroundImage = Image.FromFile("./alhpabet/A.png");
                    if (kum == 2) pictureBox1.BackgroundImage = Image.FromFile("./alhpabet/O.png");
                    if (kum == 3) pictureBox1.BackgroundImage = Image.FromFile("./alhpabet/Y.png");
                    if (kum == 4) pictureBox1.BackgroundImage = Image.FromFile("./alhpabet/iii.png");
                    if (kum == 5) pictureBox1.BackgroundImage = Image.FromFile("./alhpabet/EEE.png");
                    if (kum == 6) pictureBox1.BackgroundImage = Image.FromFile("./alhpabet/LA.png");
                    if (kum == 7) pictureBox1.BackgroundImage = Image.FromFile("./alhpabet/EKRAT.png");
                    if (kum == 8) pictureBox1.BackgroundImage = Image.FromFile("./alhpabet/YOU.png");
                    if (kum == 9) pictureBox1.BackgroundImage = Image.FromFile("./alhpabet/N.png");
                    if (kum == 10) pictureBox1.BackgroundImage = Image.FromFile("./alhpabet/E.png");
                }
                if (kum == 1)
                    //string musicPath = "./audiof/AN.wav";
                    //using (SoundPlayer soundPlayer = new SoundPlayer(musicPath))
                    using (SoundPlayer soundPlayer = new SoundPlayer("./audiof/AA.wav"))
                        soundPlayer.Play();
                if (kum == 2)
                    using (SoundPlayer soundPlayer = new SoundPlayer("./audiof/O.wav"))
                        soundPlayer.Play();
                if (kum == 3)
                    using (SoundPlayer soundPlayer = new SoundPlayer("./audiof/Y.wav"))
                        soundPlayer.Play();
                if (kum == 4)
                    using (SoundPlayer soundPlayer = new SoundPlayer("./audiof/iii.wav"))
                        soundPlayer.Play();
                if (kum == 5)
                    using (SoundPlayer soundPlayer = new SoundPlayer("./audiof/EEE.wav"))
                        soundPlayer.Play();
                if (kum == 6)
                    using (SoundPlayer soundPlayer = new SoundPlayer("./audiof/LA.wav"))
                        soundPlayer.Play();
                if (kum == 7)
                    using (SoundPlayer soundPlayer = new SoundPlayer("./audiof/EKRAT.wav"))
                        soundPlayer.Play();
                if (kum == 8)
                    using (SoundPlayer soundPlayer = new SoundPlayer("./audiof/YOU.wav"))
                        soundPlayer.Play();
                if (kum == 9)
                    using (SoundPlayer soundPlayer = new SoundPlayer("./audiof/N.wav"))
                        soundPlayer.Play();
                if (kum == 10)
                    using (SoundPlayer soundPlayer = new SoundPlayer("./audiof/E.wav"))
                        soundPlayer.Play();


            
        }
        void timer_Tick(object sender, System.EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            timer.Stop();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
                timer.Interval = 4000; // here time in milliseconds
                timer.Tick += timer_Tick;
                timer.Start();
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;// place get random code here

                if (kum == -11)
                    kum += 11;
                if (kum > -11)

                    kum--;
                {
                    if (kum == 1) pictureBox1.BackgroundImage = Image.FromFile("./alhpabet/AA.png");
                    if (kum == 2) pictureBox1.BackgroundImage = Image.FromFile("./alhpabet/O.png");
                    if (kum == 3) pictureBox1.BackgroundImage = Image.FromFile("./alhpabet/Y.png");
                    if (kum == 4) pictureBox1.BackgroundImage = Image.FromFile("./alhpabet/iii.png");
                    if (kum == 5) pictureBox1.BackgroundImage = Image.FromFile("./alhpabet/EEE.png");
                    if (kum == 6) pictureBox1.BackgroundImage = Image.FromFile("./alhpabet/LA.png");
                    if (kum == 7) pictureBox1.BackgroundImage = Image.FromFile("./alhpabet/EKRAT.png");
                    if (kum == 8) pictureBox1.BackgroundImage = Image.FromFile("./alhpabet/YOU.png");
                    if (kum == 9) pictureBox1.BackgroundImage = Image.FromFile("./alhpabet/N.png");
                    if (kum == 10) pictureBox1.BackgroundImage = Image.FromFile("./alhpabet/E.png");
                }
                if (kum == 1)
                    //string musicPath = "./audiof/AN.wav";
                    //using (SoundPlayer soundPlayer = new SoundPlayer(musicPath))
                    using (SoundPlayer soundPlayer = new SoundPlayer("./audiof/AA.wav"))
                        soundPlayer.Play();
                if (kum == 2)
                    using (SoundPlayer soundPlayer = new SoundPlayer("./audiof/O.wav"))
                        soundPlayer.Play();
                if (kum == 3)
                    using (SoundPlayer soundPlayer = new SoundPlayer("./audiof/Y.wav"))
                        soundPlayer.Play();
                if (kum == 4)
                    using (SoundPlayer soundPlayer = new SoundPlayer("./audiof/iii.wav"))
                        soundPlayer.Play();
                if (kum == 5)
                    using (SoundPlayer soundPlayer = new SoundPlayer("./audiof/EEE.wav"))
                        soundPlayer.Play();
                if (kum == 6)
                    using (SoundPlayer soundPlayer = new SoundPlayer("./audiof/LA.wav"))
                        soundPlayer.Play();
                if (kum == 7)
                    using (SoundPlayer soundPlayer = new SoundPlayer("./audiof/EKRAT.wav"))
                        soundPlayer.Play();
                if (kum == 8)
                    using (SoundPlayer soundPlayer = new SoundPlayer("./audiof/YOU.wav"))
                        soundPlayer.Play();
                if (kum == 9)
                    using (SoundPlayer soundPlayer = new SoundPlayer("./audiof/N.wav"))
                        soundPlayer.Play();
                if (kum == 10)
                    using (SoundPlayer soundPlayer = new SoundPlayer("./audiof/E.wav"))
                        soundPlayer.Play();


            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
