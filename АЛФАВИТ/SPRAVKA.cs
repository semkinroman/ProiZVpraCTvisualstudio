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
    public partial class SPRAVKA : Form
    {
        public SPRAVKA()
        {
            InitializeComponent();
            textBox1.Text = " Программа разрботана для изучения алфавита"+"\r\n русского языка."+"\r\n Благодаря интерфейсу, содержащему"+"\r\n изображения букв и их соответствующие звуки,"+"\r\n ученик сможет изучить русский алфавит наедине с"+"\r\n самим собой."
                +"\r\n        Как работать с программой:\r\n Начините изучение перейдя в меню.\r\n        Выберите метод изучения:\r\n        \"Изучение гласных букв\"\r\n        \"Изучение согласных букв\"\r\n        \"Изучение букв от А до Я\"\r\n Рекомендуется изучать в указанном порядке\r\n        Нажмите на кнопку \"сменить\"\r\n Рассмотрите изображение и прослушайте звук буквы\r\n        Нажимая на кнопку \"вернуть\"\r\n Верните предыдущую букву если она просмотрена\r\n        Нажмите на кнопку \"меню\"\r\n (если хотите вернуться к выбору метода изучения)";
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
