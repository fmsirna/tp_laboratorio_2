using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3
{
    /// <summary>
    /// clase para crear la estructura del arma, el cuerpo
    /// </summary>
    public class Cuerpo
    {
        private string nombre;
        private eMaterial material;
        private int cantBalas;

        public string Nombre { get => nombre; set => nombre = value; }
        public eMaterial Material { get => material; set => material = value; }
        public int CantBalas { get => cantBalas; set => cantBalas = value; }

        public Cuerpo(string nombre, eMaterial material, int cantBalas)
        {
            this.nombre = nombre;
            this.material = material;
            this.cantBalas = cantBalas;
        }
        public Cuerpo() { }

        /// <summary>
        /// funcion para obtener el detalle de material y cant de balas del cuerpo 
        /// </summary>
        public string InfoCuerpo()
        {
            StringBuilder strb = new StringBuilder();
            strb.AppendLine("Cuerpo nombre: " + this.nombre);
            strb.AppendLine("Conformado por: ");
            strb.AppendLine("material: " + this.material);
            strb.AppendLine("cantidad Balas: " + this.cantBalas);
            return strb.ToString();
        }
        public override string ToString()
        {
            return this.nombre;
        }

    }
}
