using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3
{
    public class Dragunov: Arma
    {
        private string nombreArma;

        public Dragunov()
        {
            this.Daño = 250;
            this.Alcance = "largo";
            this.Manufacturador = "strikeIndustries";
            this.NombreArma = this.GetType().Name;
        }
        public Dragunov(int daño, string alcance) : base(daño, alcance)
        {
            this.NombreArma = this.GetType().Name;
        }

        public string NombreArma { get => nombreArma; set => nombreArma = value; }

        public override string InfoArma()
        {
            StringBuilder strb = new StringBuilder();
            strb.AppendLine("Nombre: Dragunov ");            
            strb.AppendLine("Daño: " + this.Daño);
            strb.AppendLine("alcance: " + this.Alcance);
            return strb.ToString();
        }

    }
}
