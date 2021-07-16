using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3
{
    public class Uzi:Arma
    {
        public Uzi() 
        {
            this.Daño = 100;
            this.Alcance = "corto";
            this.Manufacturador = "strikeIndustries";
        }
        public Uzi(int daño, string alcance) : base(daño, alcance)
        {
        }

        public override string InfoArma()
        {
            StringBuilder strb = new StringBuilder();
            strb.AppendLine("Nombre: Uzi ");
            strb.AppendLine("Daño: " + this.Daño);
            strb.AppendLine("alcance: " + this.Alcance);
            return strb.ToString();
        }
    }
}
