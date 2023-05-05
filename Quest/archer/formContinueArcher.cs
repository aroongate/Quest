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
    public partial class formContinueArcher : Form
    {
        public formContinueArcher()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)//Показывает результат вашего выбора
        {
            MessageBox.Show("Вы отступаете и город захватывают");
            MessageBox.Show("Игра окончена");
            Application.Exit();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)//Показывает результат вашего выбора
        {
            MessageBox.Show("Чувствуя решимость, вы собираете группу выживших и строите планы по возвращению города и изгнанию захватчиков.");
            MessageBox.Show("Вы разведываете город и собираете информацию о слабостях и тактике захватчиков.");
            MessageBox.Show("Вы возглавляете внезапную атаку на захватчиков, заставая их врасплох и успешно отвоевывая город.");
            MessageBox.Show("Вы продолжаете свое путешествие, помогая другим городам защищаться от захватчиков и в конечном счете вытесняя их из королевства.");
            MessageBox.Show("Игра окончена");
            Application.Exit();
            Hide();
        }

        private void formContinueArcher_Load(object sender, EventArgs e)
        {

        }
    }
}
