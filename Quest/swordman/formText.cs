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
    public partial class Выбор : Form
    {
        public Выбор()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)//Показывает результат вашего выбора
        {
            Hide();
            MessageBox.Show("Вы решаете помочь жителям деревни и собрать информацию о местонахождении дракона");
            MessageBox.Show("После нескольких дней подготовки вы отправляетесь на встречу с драконом.");
            MessageBox.Show("Вы натыкаетесь на логово дракона и вступаете в ожесточенную битву. После упорной битвы вы успешно побеждаете дракона и спасаете деревню.");
            MessageBox.Show("Жители деревни благодарят вас за вашу храбрость, и вы продолжаете свое путешествие, чтобы спасти королевство.");
            MessageBox.Show("Игра окончена");
            Application.Exit();
        }
 
        private void button2_Click(object sender, EventArgs e)//Показывает результат вашего выбора
        {
            Hide();
            MessageBox.Show("Вы решаете не обращать внимания на жителей деревни и продолжить свое путешествие.");
            MessageBox.Show("Продолжая свое путешествие, вы натыкаетесь на путь разрушения дракона и осознаете серьезность ситуации.");
            MessageBox.Show("Чувствуя себя виноватым за то, что не помог раньше, вы возвращаетесь в деревню и готовитесь встретиться лицом к лицу с драконом.");
            MessageBox.Show("Вам не хватило времени на подготовку к сражению, и вы терпите поражение в схватке с драконом");
            MessageBox.Show("Игра окончена");
            Application.Exit();
        }

        private void Выбор_Load(object sender, EventArgs e)
        {

        }
    }
}
