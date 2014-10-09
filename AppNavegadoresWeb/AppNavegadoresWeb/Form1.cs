using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppNavegadoresWeb
{
    public partial class Navegadores : Form
    {
        public Navegadores()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string texto = " ";
            if (chkChrome.Checked == true)
            {
                texto = texto + "Chrome" + " ";
            }
            if (chkMozilla.Checked == true)
            {
                texto = texto + "Mozilla Firefox" + " ";
            }
            if (chkOpera.Checked == true)
            {
                texto = texto + "Opera" + " ";
            }
            lblResultado.Text = "Resultado:" + texto.ToString();
        }
    }
}
