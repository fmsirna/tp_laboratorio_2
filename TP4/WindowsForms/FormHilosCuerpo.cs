using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP3;

namespace WindowsForms
{
    public partial class FormHilosCuerpo : Form
    {
        public Almacen almacen;

        
        private static string conexionString = @"Data Source=DESKTOP-V2GD73B;Initial Catalog=ComercioIT;Integrated Security=True";
        public Simulador simulador;
        public FormHilosCuerpo(Almacen almacen)
        {
            this.almacen = almacen;
            InitializeComponent();
            this.label2.Text = "";            
            simulador = new Simulador(almacen);
            simulador.MostrarAlmacen -= this.Mostar;
            simulador.MostrarAlmacen += this.Mostar;
            simulador.MetodoStart();
        }


        private void Mostar(Cuerpo cuerpo)
        {
            if (this.InvokeRequired)
            {
                Simulador.DelegadoMostrar d = new Simulador.DelegadoMostrar(Mostar);
                this.Invoke(d, new object[] { cuerpo });
            }
            else
            {
                this.label2.Text = cuerpo.InfoCuerpo();


            }

        }

        private void Closingg(object sender, FormClosingEventArgs e)
        {
            DialogResult d = MessageBox.Show("seguro?", "cerrar?", MessageBoxButtons.YesNo);
            if (d == DialogResult.Yes)
            {
                simulador.Cerrar();

                try
                {
                    using (SqlConnection sqlConnection = new SqlConnection(conexionString))
                    {
                        sqlConnection.Open();
                        SqlCommand comando = new SqlCommand();
                        comando.Connection = sqlConnection;
                        comando.CommandType = CommandType.Text;

                        int aux = 1;
                        foreach (Cuerpo item in almacen.ListaCuerpo)
                        {
                            
                            comando.CommandText = "INSERT INTO Cuerpos ([Nombre]," +
                            "[Material])" + $" VALUES (@NombreV{aux}, @MaterialV{aux})";

                            comando.Parameters.AddWithValue($"@NombreV{aux}", item.Nombre);
                            comando.Parameters.AddWithValue($"@MaterialV{aux}", item.Material);                           
                            comando.ExecuteNonQuery();
                            aux++;

                        }
                    }
                    
                }
                catch (Exception ex)
                {

                    throw ex;
                }

                Dispose();
            }
            else
            {
                e.Cancel = true;
            }


        }
    }
}
