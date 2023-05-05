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
    public partial class formSwordMan : Form
    {
        public formSwordMan()
        {
            InitializeComponent();
           
        }

        private void formSwordMan_Load(object sender, EventArgs e)//Показывает результат вашего выбора
        {
            MessageBox.Show("Вы отправляетесь в свое путешествие и натыкаетесь на маленькую деревню. Жители деревни говорят вам, что дракон терроризирует деревню, и они отчаянно нуждаются в вашей помощи.");
            
        }

        private void formSwordMan_Activated(object sender, EventArgs e)
        {

        }

        private void formSwordMan_Shown(object sender, EventArgs e)//Открывает окно выбора
        {
            Выбор formText = new Выбор();
            formText.Show();
        }
    }
}
