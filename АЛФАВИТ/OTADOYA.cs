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
    public partial class AYA : Form
    {
        int kum = 0;
        Timer timer1 = new Timer();
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();

        public AYA()
        {
            InitializeComponent();
            pictureBox1.BackColor = Color.Transparent;
            this.ControlBox = false;
        }

        void timer_Tick(object sender, System.EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            timer.Stop();
        }





        private void button1_Click_1(object sender, EventArgs e)
        {
           
                    timer.Interval = 4000; // here time in milliseconds
                    timer.Tick += timer_Tick;
                    timer.Start();
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;// place get random code here

                        if (kum == 34)
                            kum -= 34;
                        if (kum < 34)

                            kum++;
                            {
                                if (kum == 1) pictureBox1.BackgroundImage = Image.FromFile("./alhpabet/A.png");
                                if (kum == 2) pictureBox1.BackgroundImage = Image.FromFile("./alhpabet/B.png");
                                if (kum == 3) pictureBox1.BackgroundImage = Image.FromFile("./alhpabet/VE.png");
                                if (kum == 4) pictureBox1.BackgroundImage = Image.FromFile("./alhpabet/G.png");
                                if (kum == 5) pictureBox1.BackgroundImage = Image.FromFile("./alhpabet/D.png");
                                if (kum == 6) pictureBox1.BackgroundImage = Image.FromFile("./alhpabet/E.png");
                                if (kum == 7) pictureBox1.BackgroundImage = Image.FromFile("./alhpabet/EKRAT.png");
                                if (kum == 8) pictureBox1.BackgroundImage = Image.FromFile("./alhpabet/GE.png");
                                if (kum == 9) pictureBox1.BackgroundImage = Image.FromFile("./alhpabet/Z.png");
                                if (kum == 10) pictureBox1.BackgroundImage = Image.FromFile("./alhpabet/N.png");
                                if (kum == 11) pictureBox1.BackgroundImage = Image.FromFile("./alhpabet/NT.png");
                                if (kum == 12) pictureBox1.BackgroundImage = Image.FromFile("./alhpabet/K.png");
                                if (kum == 13) pictureBox1.BackgroundImage = Image.FromFile("./alhpabet/L.png");
                                if (kum == 14) pictureBox1.BackgroundImage = Image.FromFile("./alhpabet/M.png");
                                if (kum == 15) pictureBox1.BackgroundImage = Image.FromFile("./alhpabet/AN.png");
                                if (kum == 16) pictureBox1.BackgroundImage = Image.FromFile("./alhpabet/O.png");
                                if (kum == 17) pictureBox1.BackgroundImage = Image.FromFile("./alhpabet/P.png");
                                if (kum == 18) pictureBox1.BackgroundImage = Image.FromFile("./alhpabet/R.png");
                                if (kum == 19) pictureBox1.BackgroundImage = Image.FromFile("./alhpabet/S.png");
                                if (kum == 20) pictureBox1.BackgroundImage = Image.FromFile("./alhpabet/T.png");
                                if (kum == 21) pictureBox1.BackgroundImage = Image.FromFile("./alhpabet/Y.png");
                                if (kum == 22) pictureBox1.BackgroundImage = Image.FromFile("./alhpabet/F.png");
                                if (kum == 23) pictureBox1.BackgroundImage = Image.FromFile("./alhpabet/X.png");
                                if (kum == 24) pictureBox1.BackgroundImage = Image.FromFile("./alhpabet/C.png");
                                if (kum == 25) pictureBox1.BackgroundImage = Image.FromFile("./alhpabet/HE.png");
                                if (kum == 26) pictureBox1.BackgroundImage = Image.FromFile("./alhpabet/SH.png");
                                if (kum == 27) pictureBox1.BackgroundImage = Image.FromFile("./alhpabet/SHA.png");
                                if (kum == 28) pictureBox1.BackgroundImage = Image.FromFile("./alhpabet/TVZN.png");
                                if (kum == 29) pictureBox1.BackgroundImage = Image.FromFile("./alhpabet/iii.png");
                                if (kum == 30) pictureBox1.BackgroundImage = Image.FromFile("./alhpabet/MGZN.png");
                                if (kum == 31) pictureBox1.BackgroundImage = Image.FromFile("./alhpabet/EEE.png");
                                if (kum == 32) pictureBox1.BackgroundImage = Image.FromFile("./alhpabet/YOU.png");
                                if (kum == 33) pictureBox1.BackgroundImage = Image.FromFile("./alhpabet/LA.png");
                            }
                            if (kum == 1)
                                using (SoundPlayer soundPlayer = new SoundPlayer("./audiof/AA.wav"))
                                    soundPlayer.Play();
                            if (kum == 2)
                                using (SoundPlayer soundPlayer = new SoundPlayer("./audiof/B.wav"))
                                    soundPlayer.Play();
                            if (kum == 3)
                                using (SoundPlayer soundPlayer = new SoundPlayer("./audiof/VE.wav"))
                                    soundPlayer.Play();
                            if (kum == 4)
                                using (SoundPlayer soundPlayer = new SoundPlayer("./audiof/G.wav"))
                                    soundPlayer.Play();
                            if (kum == 5)
                                using (SoundPlayer soundPlayer = new SoundPlayer("./audiof/D.wav"))
                                    soundPlayer.Play();
                            if (kum == 6)
                                using (SoundPlayer soundPlayer = new SoundPlayer("./audiof/E.wav"))
                                    soundPlayer.Play();
                            if (kum == 7)
                                using (SoundPlayer soundPlayer = new SoundPlayer("./audiof/EKRAT.wav"))
                                    soundPlayer.Play();
                            if (kum == 8)
                                using (SoundPlayer soundPlayer = new SoundPlayer("./audiof/GE.wav"))
                                    soundPlayer.Play();
                            if (kum == 9)
                                using (SoundPlayer soundPlayer = new SoundPlayer("./audiof/Z.wav"))
                                    soundPlayer.Play();
                            if (kum == 10)
                                using (SoundPlayer soundPlayer = new SoundPlayer("./audiof/N.wav"))
                                    soundPlayer.Play();
                            if (kum == 11)
                                using (SoundPlayer soundPlayer = new SoundPlayer("./audiof/NT.wav"))
                                    soundPlayer.Play();
                            if (kum == 12)
                                using (SoundPlayer soundPlayer = new SoundPlayer("./audiof/K.wav"))
                                    soundPlayer.Play();
                            if (kum == 13)
                                using (SoundPlayer soundPlayer = new SoundPlayer("./audiof/L.wav"))
                                    soundPlayer.Play();
                            if (kum == 14)
                                using (SoundPlayer soundPlayer = new SoundPlayer("./audiof/M.wav"))
                                    soundPlayer.Play();
                            if (kum == 15)
                                using (SoundPlayer soundPlayer = new SoundPlayer("./audiof/AN.wav"))
                                    soundPlayer.Play();
                            if (kum == 16)
                                using (SoundPlayer soundPlayer = new SoundPlayer("./audiof/O.wav"))
                                    soundPlayer.Play();
                            if (kum == 17)
                                using (SoundPlayer soundPlayer = new SoundPlayer("./audiof/P.wav"))
                                    soundPlayer.Play();
                            if (kum == 18)
                                using (SoundPlayer soundPlayer = new SoundPlayer("./audiof/R.wav"))
                                    soundPlayer.Play();
                            if (kum == 19)
                                using (SoundPlayer soundPlayer = new SoundPlayer("./audiof/S.wav"))
                                    soundPlayer.Play();
                            if (kum == 20)
                                using (SoundPlayer soundPlayer = new SoundPlayer("./audiof/T.wav"))
                                    soundPlayer.Play();
                            if (kum == 21)
                                using (SoundPlayer soundPlayer = new SoundPlayer("./audiof/Y.wav"))
                                    soundPlayer.Play();
                            if (kum == 22)
                                using (SoundPlayer soundPlayer = new SoundPlayer("./audiof/F.wav"))
                                    soundPlayer.Play();
                            if (kum == 23)
                                using (SoundPlayer soundPlayer = new SoundPlayer("./audiof/X.wav"))
                                    soundPlayer.Play();
                            if (kum == 24)
                                using (SoundPlayer soundPlayer = new SoundPlayer("./audiof/C.wav"))
                                    soundPlayer.Play();
                            if (kum == 25)
                                using (SoundPlayer soundPlayer = new SoundPlayer("./audiof/HE.wav"))
                                    soundPlayer.Play();
                            if (kum == 26)
                                using (SoundPlayer soundPlayer = new SoundPlayer("./audiof/SH.wav"))
                                    soundPlayer.Play();
                            if (kum == 27)
                                using (SoundPlayer soundPlayer = new SoundPlayer("./audiof/SHA.wav"))
                                    soundPlayer.Play();
                            if (kum == 28)
                                using (SoundPlayer soundPlayer = new SoundPlayer("./audiof/TVZN.wav"))
                                    soundPlayer.Play();
                            if (kum == 29)
                                using (SoundPlayer soundPlayer = new SoundPlayer("./audiof/iii.wav"))
                                    soundPlayer.Play();
                            if (kum == 30)
                                using (SoundPlayer soundPlayer = new SoundPlayer("./audiof/MGZN.wav"))
                                    soundPlayer.Play();
                            if (kum == 31)
                                using (SoundPlayer soundPlayer = new SoundPlayer("./audiof/EEE.wav"))
                                    soundPlayer.Play();
                            if (kum == 32)
                                using (SoundPlayer soundPlayer = new SoundPlayer("./audiof/YOU.wav"))
                                    soundPlayer.Play();
                            if (kum == 33)
                                using (SoundPlayer soundPlayer = new SoundPlayer("./audiof/LA.wav"))
                                    soundPlayer.Play();
                        
                    
                
            
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Close();
            //this.Hide();
            Form back = new Form2();
            back.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            
                timer.Interval = 4000; // here time in milliseconds
                timer.Tick += timer_Tick;
                timer.Start();
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;// place get random code here

                {
                    if (kum == -34)
                        kum += 34;
                    if (kum > -34)

                    {
                        kum--;
                        {
                            if (kum == 1) pictureBox1.BackgroundImage = Image.FromFile("./alhpabet/A.png");
                            if (kum == 2) pictureBox1.BackgroundImage = Image.FromFile("./alhpabet/B.png");
                            if (kum == 3) pictureBox1.BackgroundImage = Image.FromFile("./alhpabet/VE.png");
                            if (kum == 4) pictureBox1.BackgroundImage = Image.FromFile("./alhpabet/G.png");
                            if (kum == 5) pictureBox1.BackgroundImage = Image.FromFile("./alhpabet/D.png");
                            if (kum == 6) pictureBox1.BackgroundImage = Image.FromFile("./alhpabet/E.png");
                            if (kum == 7) pictureBox1.BackgroundImage = Image.FromFile("./alhpabet/EKRAT.png");
                            if (kum == 8) pictureBox1.BackgroundImage = Image.FromFile("./alhpabet/GE.png");
                            if (kum == 9) pictureBox1.BackgroundImage = Image.FromFile("./alhpabet/Z.png");
                            if (kum == 10) pictureBox1.BackgroundImage = Image.FromFile("./alhpabet/N.png");
                            if (kum == 11) pictureBox1.BackgroundImage = Image.FromFile("./alhpabet/NT.png");
                            if (kum == 12) pictureBox1.BackgroundImage = Image.FromFile("./alhpabet/K.png");
                            if (kum == 13) pictureBox1.BackgroundImage = Image.FromFile("./alhpabet/L.png");
                            if (kum == 14) pictureBox1.BackgroundImage = Image.FromFile("./alhpabet/M.png");
                            if (kum == 15) pictureBox1.BackgroundImage = Image.FromFile("./alhpabet/AN.png");
                            if (kum == 16) pictureBox1.BackgroundImage = Image.FromFile("./alhpabet/O.png");
                            if (kum == 17) pictureBox1.BackgroundImage = Image.FromFile("./alhpabet/P.png");
                            if (kum == 18) pictureBox1.BackgroundImage = Image.FromFile("./alhpabet/R.png");
                            if (kum == 19) pictureBox1.BackgroundImage = Image.FromFile("./alhpabet/S.png");
                            if (kum == 20) pictureBox1.BackgroundImage = Image.FromFile("./alhpabet/T.png");
                            if (kum == 21) pictureBox1.BackgroundImage = Image.FromFile("./alhpabet/Y.png");
                            if (kum == 22) pictureBox1.BackgroundImage = Image.FromFile("./alhpabet/F.png");
                            if (kum == 23) pictureBox1.BackgroundImage = Image.FromFile("./alhpabet/X.png");
                            if (kum == 24) pictureBox1.BackgroundImage = Image.FromFile("./alhpabet/C.png");
                            if (kum == 25) pictureBox1.BackgroundImage = Image.FromFile("./alhpabet/HE.png");
                            if (kum == 26) pictureBox1.BackgroundImage = Image.FromFile("./alhpabet/SH.png");
                            if (kum == 27) pictureBox1.BackgroundImage = Image.FromFile("./alhpabet/SHA.png");
                            if (kum == 28) pictureBox1.BackgroundImage = Image.FromFile("./alhpabet/TVZN.png");
                            if (kum == 29) pictureBox1.BackgroundImage = Image.FromFile("./alhpabet/iii.png");
                            if (kum == 30) pictureBox1.BackgroundImage = Image.FromFile("./alhpabet/MGZN.png");
                            if (kum == 31) pictureBox1.BackgroundImage = Image.FromFile("./alhpabet/EEE.png");
                            if (kum == 32) pictureBox1.BackgroundImage = Image.FromFile("./alhpabet/YOU.png");
                            if (kum == 33) pictureBox1.BackgroundImage = Image.FromFile("./alhpabet/LA.png");
                        }
                        if (kum == 1)
                            using (SoundPlayer soundPlayer = new SoundPlayer("./audiof/AA.wav"))
                                soundPlayer.Play();
                        if (kum == 2)
                            using (SoundPlayer soundPlayer = new SoundPlayer("./audiof/B.wav"))
                                soundPlayer.Play();
                        if (kum == 3)
                            using (SoundPlayer soundPlayer = new SoundPlayer("./audiof/VE.wav"))
                                soundPlayer.Play();
                        if (kum == 4)
                            using (SoundPlayer soundPlayer = new SoundPlayer("./audiof/G.wav"))
                                soundPlayer.Play();
                        if (kum == 5)
                            using (SoundPlayer soundPlayer = new SoundPlayer("./audiof/D.wav"))
                                soundPlayer.Play();
                        if (kum == 6)
                            using (SoundPlayer soundPlayer = new SoundPlayer("./audiof/E.wav"))
                                soundPlayer.Play();
                        if (kum == 7)
                            using (SoundPlayer soundPlayer = new SoundPlayer("./audiof/EKRAT.wav"))
                                soundPlayer.Play();
                        if (kum == 8)
                            using (SoundPlayer soundPlayer = new SoundPlayer("./audiof/GE.wav"))
                                soundPlayer.Play();
                        if (kum == 9)
                            using (SoundPlayer soundPlayer = new SoundPlayer("./audiof/Z.wav"))
                                soundPlayer.Play();
                        if (kum == 10)
                            using (SoundPlayer soundPlayer = new SoundPlayer("./audiof/N.wav"))
                                soundPlayer.Play();
                        if (kum == 11)
                            using (SoundPlayer soundPlayer = new SoundPlayer("./audiof/NT.wav"))
                                soundPlayer.Play();
                        if (kum == 12)
                            using (SoundPlayer soundPlayer = new SoundPlayer("./audiof/K.wav"))
                                soundPlayer.Play();
                        if (kum == 13)
                            using (SoundPlayer soundPlayer = new SoundPlayer("./audiof/L.wav"))
                                soundPlayer.Play();
                        if (kum == 14)
                            using (SoundPlayer soundPlayer = new SoundPlayer("./audiof/M.wav"))
                                soundPlayer.Play();
                        if (kum == 15)
                            using (SoundPlayer soundPlayer = new SoundPlayer("./audiof/AN.wav"))
                                soundPlayer.Play();
                        if (kum == 16)
                            using (SoundPlayer soundPlayer = new SoundPlayer("./audiof/O.wav"))
                                soundPlayer.Play();
                        if (kum == 17)
                            using (SoundPlayer soundPlayer = new SoundPlayer("./audiof/P.wav"))
                                soundPlayer.Play();
                        if (kum == 18)
                            using (SoundPlayer soundPlayer = new SoundPlayer("./audiof/R.wav"))
                                soundPlayer.Play();
                        if (kum == 19)
                            using (SoundPlayer soundPlayer = new SoundPlayer("./audiof/S.wav"))
                                soundPlayer.Play();
                        if (kum == 20)
                            using (SoundPlayer soundPlayer = new SoundPlayer("./audiof/T.wav"))
                                soundPlayer.Play();
                        if (kum == 21)
                            using (SoundPlayer soundPlayer = new SoundPlayer("./audiof/Y.wav"))
                                soundPlayer.Play();
                        if (kum == 22)
                            using (SoundPlayer soundPlayer = new SoundPlayer("./audiof/F.wav"))
                                soundPlayer.Play();
                        if (kum == 23)
                            using (SoundPlayer soundPlayer = new SoundPlayer("./audiof/X.wav"))
                                soundPlayer.Play();
                        if (kum == 24)
                            using (SoundPlayer soundPlayer = new SoundPlayer("./audiof/C.wav"))
                                soundPlayer.Play();
                        if (kum == 25)
                            using (SoundPlayer soundPlayer = new SoundPlayer("./audiof/HE.wav"))
                                soundPlayer.Play();
                        if (kum == 26)
                            using (SoundPlayer soundPlayer = new SoundPlayer("./audiof/SH.wav"))
                                soundPlayer.Play();
                        if (kum == 27)
                            using (SoundPlayer soundPlayer = new SoundPlayer("./audiof/SHA.wav"))
                                soundPlayer.Play();
                        if (kum == 28)
                            using (SoundPlayer soundPlayer = new SoundPlayer("./audiof/TVZN.wav"))
                                soundPlayer.Play();
                        if (kum == 29)
                            using (SoundPlayer soundPlayer = new SoundPlayer("./audiof/iii.wav"))
                                soundPlayer.Play();
                        if (kum == 30)
                            using (SoundPlayer soundPlayer = new SoundPlayer("./audiof/MGZN.wav"))
                                soundPlayer.Play();
                        if (kum == 31)
                            using (SoundPlayer soundPlayer = new SoundPlayer("./audiof/EEE.wav"))
                                soundPlayer.Play();
                        if (kum == 32)
                            using (SoundPlayer soundPlayer = new SoundPlayer("./audiof/YOU.wav"))
                                soundPlayer.Play();
                        if (kum == 33)
                            using (SoundPlayer soundPlayer = new SoundPlayer("./audiof/LA.wav"))
                                soundPlayer.Play();
                    }
                }
            

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

