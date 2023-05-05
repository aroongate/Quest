using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quest.archer
{
    public partial class formArcherText : Form
    {
        public formArcherText()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)//Показывает результат вашего выбора
        {
            Hide();
            MessageBox.Show("Вы решаете помочь городу и присоединяетесь к обороне.");
            MessageBox.Show("Вы используете 'Мощный выстрел', чтобы помочь защитить город, уничтожив многих захватчиков.");
            MessageBox.Show("Несмотря на ваши усилия, город в конечном счете захвачен");
            formContinueArcher formContinueArcher = new formContinueArcher();
            formContinueArcher.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)//Показывает результат вашего выбора
        {
            Hide();
            MessageBox.Show("Вы решаете не обращать внимания на город и продолжить свое путешествие.");
            MessageBox.Show("Продолжая свое путешествие, вы слышите новости о том, что все больше городов попадает под власть армии вторжения.");
            MessageBox.Show("Чувствуя себя виноватым за то, что не помог раньше, вы поворачиваете назад, чтобы присоединиться к борьбе с захватчиками.");
            MessageBox.Show("По пути вы собираете союзников и ресурсы, создавая сильную силу сопротивления.");
            MessageBox.Show("Вы ведете свою армию в нескольких успешных сражениях с захватчиками, оттесняя их назад и отвоевывая потерянные города.");
            MessageBox.Show("Наконец, вы добираетесь до города, где впервые столкнулись с захватчиками. Вы начинаете последнюю атаку, и с помощью ваших союзников вы можете победить захватчиков и спасти королевство.");
            MessageBox.Show("Вас приветствуюь как героя, и ваше имя запечатлено в истории");
            MessageBox.Show("Игра окончена");
            Application.Exit();
        }

        private void formArcherText_Load(object sender, EventArgs e)
        {

        }
    }
}
