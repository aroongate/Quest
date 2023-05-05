using Quest.wizard;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quest
{
    public partial class formTextWizard : Form
    {
        public formTextWizard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)//Показывает результат вашего выбора
        {
            Hide();
            MessageBox.Show("Вы решаете помочь горожанам и собрать информацию о местонахождении колдуна.");
            MessageBox.Show("Изучив древние тексты и подготовив мощные заклинания, вы отправляетесь на встречу с колдуном.");
            MessageBox.Show("Вы натыкаетесь на крепость колдуна и вступаете в ожесточенную магическую битву. Вы используете, свою способность 'Шар огня'. После упорной битвы вы успешно побеждаете колдуна и спасаете город.");
            MessageBox.Show("Горожане благодарят вас за вашу помощь, и вы продолжаете свое путешествие, чтобы спасти королевство.");
            MessageBox.Show("Путешествуя, вы сталкиваетесь с могущественным некромантом, который собирает армию мертвых, чтобы завоевать королевство.");
            formContinueWizard formContinueWizard = new formContinueWizard();
            formContinueWizard.Show();
        }

        private void button2_Click(object sender, EventArgs e)//Показывает результат вашего выбора
        {
            Hide();
            MessageBox.Show("Вы решаете не обращать внимания на горожан и продолжить свое путешествие.");
            MessageBox.Show("По мере того, как вы продолжаете свое путешествие, вы встречаете все больше и больше городов, которые были разрушены магией колдуна.");
            MessageBox.Show("Чувствуя себя виноватым за то, что не помог раньше, вы возвращаетесь в город и готовитесь встретиться лицом к лицу с колдуном.");
            MessageBox.Show("Изучив древние тексты и подготовив мощные заклинания, вы отправляетесь на встречу с колдуном.");
            MessageBox.Show("Вы натыкаетесь на крепость колдуна и вступаете в ожесточенную магическую битву. Вы используете, свою способность 'Шар огня'. После упорной битвы вы успешно побеждаете колдуна и спасаете город.");
            formContinueWizard formContinueWizard = new formContinueWizard();
            formContinueWizard.Show();
        }

        private void formTextWizard_Load(object sender, EventArgs e)
        {

        }
    }
}
