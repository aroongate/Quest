using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quest.wizard
{
    public partial class formContinueWizard : Form
    {
        public formContinueWizard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)//Показывает результат вашего выбора
        {
            Hide();
            MessageBox.Show("Вы решаете встретиться лицом к лицу с некромантом и положить конец его планам.");
            MessageBox.Show("Вы изучаете древние тексты и готовите мощные заклинания, чтобы противостоять темной магии некроманта.");
            MessageBox.Show("Вы вступаете в ожесточенную битву, используя все свои знания и умения, чтобы победить некроманта и его армию мертвых.");
            MessageBox.Show("Когда некромант побежден, королевство снова в безопасности, и вы заканчиваете своё путешествие.");
            MessageBox.Show("Игра окончена");
            Application.Exit();
        }


        private void button2_Click(object sender, EventArgs e)//Показывает результат вашего выбора
        {
            MessageBox.Show("Вы решаете проигнорировать некроманта и продолжить свое путешествие.");
            MessageBox.Show("Через несколько дней, вы замечаете, что вас окружил некромант и его армия мёртвых, вы не успеваете среагировать, и проигрываете");
            MessageBox.Show("Игра окончена");
            Hide();
            Application.Exit();
        }

        private void formContinueWizard_Load(object sender, EventArgs e)
        {

        }
    }
}
