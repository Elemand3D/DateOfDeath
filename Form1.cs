using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateOfDeath
{
    public partial class FormDateOfDeath : Form
    {
        RandomDate date;
        RandomStory story;
        public FormDateOfDeath()
        {
            InitializeComponent();
            date = new RandomDate();
            story = new RandomStory();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            pictureBox1.BackColor = Color.Transparent;
            pictureBoxTittleLeftToLive.BackColor = Color.Transparent;
            label1.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label4.BackColor = Color.Transparent;
            pictureBoxNeon.BackColor = Color.Transparent;
            linkLabel1.BackColor = Color.Transparent;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox1.Image = DateOfDeath.Properties.Resources.DeathButtonOnTouch;
        }
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBox1.Image = DateOfDeath.Properties.Resources.DeathButton;
        }
        public string GetCityName(int city)
        {
            switch (city)
            {
                case 0: return "Рязани";
                case 1: return "Владимире";
                case 2: return "Новосибирске";
                case 3: return "Питере";
                case 4: return "Москве";
                case 5: return "Омске";
                case 6: return "Нальчике";
                case 7: return "Урюпинске";

            }
            return "Неизвестно";
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            

            string[] storyrnd =
            {
            $"Вы умрёте во время секс-вечеринки. Подруга позовёт вас на элитную оргию. Вы с ней будете там единственными девушками! Вас свяжут и будут издеваться, пока вы не умрёте от увечий.",
            $"Вы скончаетесь от смеха, наблюдая, как пьяный флейм пытается играть в танки на раздевание.",
            $"Вы будете гордиться своей самой длинной в мире бородой - 1,4 м. Но, когда однажды случится пожар, забыв замотать бороду, вы упадёте, запутавшись в ней, и сломаете себе шею.",
            $"Вы сожрёте очень много шаурмы. Владелец шаурмешной подсыпет кокаин в свою шаувуху, а вы не в силах совладать с зависимостью траванётесь летальной дозой особого соуса.",
            $"Вы умрёте сидя за компом обоссавшись и обосравшись.",
            $"Вы прыгнете с парашютом и со своей новенькой видеокамерой Blackmagic. К сожалению видеокамера окажется настолько дорогой, что вам не хватит на парашют",
            $"Вы будете страстно желалать доказать своему приятелю, что уайт-спирит горит - поэтому обльёте себя растворителем и подожжёте. Вскоре скончаетесь через 6 дней от страшных ожогов.",
            $"Вы умерёте после лобового столкновения с собственным радиоуправляемым самолетиком. Взглянув на солнце, вы потеряете 3-килограммовую машину из виду, в то время как самолет врежется вам в голову на скорости около 65 км/ч.",
            $"Вы купите квартиру в {GetCityName(story.nameCity)}. Российские воздушные силы убьют трех жителей {GetCityName(story.nameCity)}, когда сбросят им на голову ящик с шавухой. На самом деле пилоты просто будут принимать участие в гуманитарной миссии и спасать россиян от голода.",
            $"Вы найдёте себе девушку, но после ссоры со своей подружкой вы повеситесь на железнодорожной станции на табличке с надписью «выход».",
            $"Вы попадёте под машину. Вы совершенно не пострадаете, однако умный прохожий, ставший свидетелем, посоветует вам притвориться серьезно пострадавшим и потребовать компенсацию. Вы согласитесь, но как только вы снова ляжете перед машиной, та сдвинунется с места и задавит вас насмерть.",
            $"Ваша жена поверит слухам, что вы ей изменяете, затем бросится с третьего этажа и упадёт прямо на вас, который возвращался домой к любимой супруге. Позже она придёт в себя в госпитале, а вот «изменщик» скончается на месте.",
            $"Посмотрев тайваньский сериал о сверхъестественном, трое долбаёов съедят дыню, начиненную крысиным ядом, чтобы «отправиться путешествовать в ад». Они оставят записку со словами: «Если в аду так же плохо, как здесь, то мы вернемся». Двоих удалось вернуть, а вам, видимо, там понравилось.",
            $"За всю вашу безумную жизнь вы совершите шесть подъемов на Эверест. Вы умерёте у себя дома, когда, меняя лампочку, упадёте с лестницы и ударитесь головой о раковину...",
            $"В Италии вы будете долго спорить со своим соседом, кто будет сидеть на единственном стуле в тени пальмы. Вы выиграете спор, после чего дерево упадёт прямо на вас.",
            $"Вы и около 50 любопытных соберётесь на мосту, чтобы понаблюдать за самоубийством молоденькой девушки. Мост не выдержит вашего веса и рухнет в реку. Погибнет девять человек, в том числе и вы. Девушку спасли.",
            $"Ваш сын, которому будет {story.sonYear} лет повздорит с вами по поводу пропавшей упаковки шоколадной глазури для торта. Ссора будет становиться все более эмоциональной, и в отчаянии вы вложите в руку сына нож со словами: «если так меня ненавидишь, то ударь.» И ваш сын вас же и ёбнет. Нехуй пиздить глазурь.",

            };

            int sto1 = rnd.Next(storyrnd.Length);
            label3.Text = ((storyrnd[sto1]));
            date.LogicRandomDate();
            story.LogicRandomStory();
            label1.Text = $"{date.year} {date.yearTitle}, {date.day} {date.dayTitle}, {date.houre} {date.houreTitle}, \n {date.minute} {date.minuteTitle}, {date.second} {date.secondTitle}.";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process prc = new Process();
            prc.StartInfo.FileName = @"https://vk.com/indi_v_razrezah";
            prc.StartInfo.UseShellExecute = true;
            prc.Start();
        }
    }
}
