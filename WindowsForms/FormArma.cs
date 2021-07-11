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

namespace WindowsForms
{
    public partial class FormArma : Form
    {
        public Almacen almacen;
        public FormArma(Almacen almacen)
        {
            this.almacen = almacen;
            InitializeComponent();
        }

        private void formLoading(object sender, EventArgs e)
        {            
            listBox1.DataSource = almacen.ListaCuerpo;
            cmbCañon.DataSource = Enum.GetValues(typeof(eCañoñ));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rbAk47.Checked)
            {
                AK47 rifle1 = new AK47();
                ArmaFabricada<AK47> arma1 = new ArmaFabricada<AK47>(rifle1, (Cuerpo)this.listBox1.SelectedItem, (eCañoñ)cmbCañon.SelectedIndex);
                almacen += arma1;               
                MessageBox.Show("Arma Creada!", "Suceso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (rbDragunov.Checked)
            {
                Dragunov sniper1 = new Dragunov();
                ArmaFabricada<Dragunov> arma = new ArmaFabricada<Dragunov>(sniper1, (Cuerpo)this.listBox1.SelectedItem, (eCañoñ)cmbCañon.SelectedIndex);
                almacen += arma;
                MessageBox.Show("Arma Creada!", "Suceso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (rbUzi.Checked)
            {
                Uzi submachine = new Uzi();             
                ArmaFabricada<Uzi> arma3 = new ArmaFabricada<Uzi>(submachine, (Cuerpo)this.listBox1.SelectedItem, (eCañoñ)cmbCañon.SelectedIndex);
                almacen += arma3;
                MessageBox.Show("Arma Creada!", "Suceso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("campos vacios", "Revisar!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
