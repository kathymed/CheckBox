using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppCheckBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            string texto=" ";
            if(chkIngles.Checked == true)
                {
                    texto = texto + "Inglés" +" ";
                }
            if (chkFrances.Checked == true)
            {
                texto = texto + "Francés" +" ";
            }
            if (chkAleman.Checked == true)
            {
                texto = texto + "Alemán" +" ";
            }
            Text = texto;

         }
    }
}
