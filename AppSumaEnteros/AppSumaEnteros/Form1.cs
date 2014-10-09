using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppSumaEnteros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            int numero1, numero2, suma;
            numero1 = int.Parse(txtNumero1.Text);
            numero2 = int.Parse(txtNumero2.Text);
            suma = numero1 + numero2;
            lblResultado.Text = "Resultado:" + suma.ToString();
        }
    }
}
