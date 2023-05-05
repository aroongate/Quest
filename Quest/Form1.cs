using Quest.archer;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void swordmanTextBox_Click(object sender, EventArgs e)
        {
            swordman swordman = new swordman(nameTextBox.Text);
            MessageBox.Show("Вы выбрали рыцаря. Ваша миссия состоит в том, чтобы победить дракона и спасти королевство.");
            Hide();
            formSwordMan formSwordMan = new formSwordMan();
            formSwordMan.ShowDialog();
        }

        private void wizardTextBox_Click(object sender, EventArgs e)
        {
            Wizard wizard = new Wizard(nameTextBox.Text);
            MessageBox.Show("Вы выбрали мага. Путешествуя по королевству, вы натыкаетесь на маленький городок, который терроризирует злой колдун. Горожане просят вас о помощи.");
            Hide();
            formWizard formWizard = new formWizard();
            formWizard.ShowDialog();
        }

        private void archerTextBox_Click(object sender, EventArgs e)
        {
            Archer Archer = new Archer(nameTextBox.Text);
            MessageBox.Show("Вы выбрали Лучника. Ваша миссия состоит в том, чтобы защитить королевство от армии вторжения. ");
            MessageBox.Show("Путешествуя по королевству, вы натыкаетесь на пограничный город, который подвергается нападению армии вторжения.");
            Hide();
            formArcher formArcher = new formArcher();
            formArcher.Show();
        }
    }
}
