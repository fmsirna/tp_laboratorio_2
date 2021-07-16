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
    public partial class FormCuerpo : Form
    {
        public Almacen almacen;
        public FormCuerpo(Almacen almacen)
        {
            this.almacen = almacen;
            InitializeComponent();            
        }

        private void FormCuerpo_Load(object sender, EventArgs e)
        {
            cmbMaterial.DataSource = Enum.GetValues(typeof(eMaterial));
                     

        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(textBox1.Text))
            {
                Cuerpo cuerpo = new Cuerpo(textBox1.Text,(eMaterial)cmbMaterial.SelectedIndex,(int)numericUpDown1.Value);
                almacen += cuerpo;
                MessageBox.Show("Cuerpo Creado!", "Suceso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("campos vacios", "Revisar!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
