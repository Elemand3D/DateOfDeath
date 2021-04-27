using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateOfDeath
{
    public partial class Form1 : Form
    {
        RandomDate date;
        public Form1()
        {
            InitializeComponent();
            date = new RandomDate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Transparent;
            pictureBoxTittleLeftToLive.BackColor = Color.Transparent;
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            pictureBoxNeon.BackColor = Color.Transparent;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox1.Image = DateOfDeath.Properties.Resources.DeathButtonOnTouch;
        }
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBox1.Image = DateOfDeath.Properties.Resources.DeathButton;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            
            string[] rumor1 =
           {
                $"Здарова, . ", $"О! Смотрите!  припёрся. ",
                $"Слыш,  ну ка подь сюды. ", $"Ну здравствуй уважаемый  чё надо? ",
                $"Здравствуй . Если тебе нужно дать в долг, могу сразу сказать, денег у меня нет. Но зато у меня есть" +
                $" значительный набор умений. Умений, которые я приобрел за свою долгую карьеру. Если ты сейчас забудешь то что я тебе скажу, на этом все" +
                $" закончится. Я не стану тебя искать. И не буду тебя преследовать. Но если нет, я буду тебя искать. Я найду тебя. И я тебя убью. "
            };

            int rum1 = rnd.Next(rumor1.Length);
            label3.Text = ((rumor1[rum1]));
            date.LogicRandomDate();
            label1.Text = $"{date.year} Лет, {date.day} Дней.";
        }
    }
}
