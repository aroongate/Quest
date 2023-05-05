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
    public partial class formArcher : Form
    {
        public formArcher()
        {
            InitializeComponent();
        }

        private void formArcher_Load(object sender, EventArgs e)
        {

        }

        private void formArcher_Shown(object sender, EventArgs e)//Показывает окно выбора
        {
            formArcherText formArcherText= new formArcherText();
            formArcherText.Show();
        }
    }
}
