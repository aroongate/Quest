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
    public partial class formWizard : Form
    {
        public formWizard()
        {
            InitializeComponent();
            
        }

        private void formWizard_Load(object sender, EventArgs e)
        {
           
        }

        private void formWizard_Shown(object sender, EventArgs e)//Показывает окно выбора действия
        {
            formTextWizard formText = new formTextWizard();
            formText.Show();
        }
    }
}
