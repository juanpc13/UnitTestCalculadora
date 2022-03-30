using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Se obtiene cadenas de texto
            string txtNum1 = inputNum1.Text;
            string txtNum2 = inputNum2.Text;

            // Se convierten a enteros
            int num1 = Convert.ToInt32(txtNum1);
            int num2 = Convert.ToInt32(txtNum2);

            // Se escribe la salida en resultado
            inputResultado.Text = (num1 + num2).ToString();
        }
    }
}
