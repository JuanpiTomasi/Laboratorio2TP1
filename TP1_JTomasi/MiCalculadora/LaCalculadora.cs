using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiCalculadora
{
    public partial class LaCalculadora : Form
    {
        public LaCalculadora()
        {
            InitializeComponent();
            Limpiar();
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            string n1 = txtNumero1.Text;
            string n2 = txtNumero2.Text;
            string operador = cmbOperador.SelectedItem.ToString();
            lblResultado.Text = Operar(n1,n2,operador).ToString();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lblResultado.Text))
            {
                lblResultado.Text = Numero.DecimalBinario(lblResultado.Text);
            }
        }

        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lblResultado.Text))
            {
                lblResultado.Text = Numero.BinarioDecimal(lblResultado.Text);
            }
        }

        private void Limpiar()
        {
            txtNumero1.Text = "";
            txtNumero2.Text = "";
            lblResultado.Text = "";
            cmbOperador.SelectedItem = null;
        }

        public static double Operar(string numero1, string numero2, string operador)
        {
            Numero n1 = new Numero(numero1.Replace(".",","));
            Numero n2 = new Numero(numero2.Replace(".", ","));
            return Calculadora.Operar(n1, n2, operador);
        }

    }
}
