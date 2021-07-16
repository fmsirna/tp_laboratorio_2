using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
        }

        private static double Operar(string numero1, string numero2, string operador)
        {
            Numero num1 = new Numero(numero1);
            Numero num2 = new Numero(numero2);

            return Calculadora.Operar(num1, num2, operador);
        }


        private void btnOperar_Click(object sender, EventArgs e)
        {
            this.lblResultado.Text = FormCalculadora.Operar(this.txtNumero1.Text, this.txtNumero2.Text, this.boxOperator.Text).ToString();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtNumero1.Clear();
            this.txtNumero2.Clear();
            this.boxOperator.Text = String.Empty;
            this.lblResultado.Text = String.Empty;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConvertBinary_Click(object sender, EventArgs e)
        {
            if (!(String.IsNullOrWhiteSpace(this.lblResultado.Text)))
            {
                string strNum = this.lblResultado.Text;                
                this.lblResultado.Text = Numero.DecimalBinario(strNum);
            }
        }

        private void btnConvertDec_Click(object sender, EventArgs e)
        {
            if (!(String.IsNullOrWhiteSpace(this.lblResultado.Text)))
            {
                string strNum = this.lblResultado.Text;
                this.lblResultado.Text = Numero.BinarioDecimal(strNum);
            }
        }
         

        private void formClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult resp = new DialogResult();

            resp = MessageBox.Show("Esta seguro que desea salir?", "Aviso!", MessageBoxButtons.YesNo);

            if (resp == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void keyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                this.lblResultado.Text = FormCalculadora.Operar(this.txtNumero1.Text, this.txtNumero2.Text, this.boxOperator.Text).ToString();
            }
        }
    }
}
