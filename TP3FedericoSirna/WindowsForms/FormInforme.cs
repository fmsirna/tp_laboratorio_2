using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using TP3;
using Archivos;

namespace WindowsForms
{
    public partial class FormInforme : Form
    {
        public Almacen almacen;
        public FormInforme(Almacen almacen)
        {
            this.almacen = almacen;
            InitializeComponent();
        }

        private void btnArchivo_Click(object sender, EventArgs e)
        {
            try
            {
                string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\ListaGeneral.txt";
                //string ruta2 = AppDomain.CurrentDomain.BaseDirectory + @"\Prueba2.txt";
                Txt arch = new Txt();
                arch.Guardar(ruta, almacen.informe());
                MessageBox.Show("se guardo el listado en el escritorio!", "Suceso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (UnauthorizedAccessException ex)
            {
                Console.WriteLine("acceso no authorizado" + ex);
            }
            catch (Exception ex)
            {
                Console.WriteLine("error inesperado" + ex);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
