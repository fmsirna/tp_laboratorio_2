using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP3;
using Archivos;

namespace WindowsForms
{
    public partial class Principal : Form
    {
        public Almacen almacen;
        public Principal()
        {
            InitializeComponent();
            almacen = new Almacen();
           
            Cuerpo ligero = new Cuerpo("ligero", eMaterial.FibraCarbono, 70);
            Cuerpo artillero = new Cuerpo("artillero", eMaterial.Metal, 250);

            almacen += ligero;
            almacen += artillero;
        }

        private void Cuerpobtn_Click(object sender, EventArgs e)
        {
            FormCuerpo showForm = new FormCuerpo(almacen);
            showForm.StartPosition = FormStartPosition.CenterParent;
            showForm.ShowDialog();
        }

        private void btnArma_Click(object sender, EventArgs e)
        {
            FormArma showForm = new FormArma(almacen);
            showForm.StartPosition = FormStartPosition.CenterParent;
            showForm.ShowDialog();
        }

        private void FormClose(object sender, FormClosingEventArgs e)
        {
            DialogResult d = MessageBox.Show("seguro?", "cerrar?", MessageBoxButtons.YesNo);
            if (d == DialogResult.Yes)
            {
                Dispose();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void btnInforme_Click(object sender, EventArgs e)
        {
            FormInforme showForm = new FormInforme(almacen);
            showForm.StartPosition = FormStartPosition.CenterParent;
            showForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormHilosCuerpo showForm = new FormHilosCuerpo(almacen);
            showForm.StartPosition = FormStartPosition.CenterParent;
            showForm.ShowDialog();
        }
    }
}
