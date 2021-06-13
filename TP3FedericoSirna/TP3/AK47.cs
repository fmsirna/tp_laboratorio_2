using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3
{
    public class AK47:Arma
    {
        
        public AK47() 
        {
            this.Daño = 150;
            this.Alcance = "medio";
            this.Manufacturador = "strikeIndustries";
        }
        public AK47(int daño, string alcance) : base(daño, alcance)
        {
        }

        public override string InfoArma()
        {
            StringBuilder strb = new StringBuilder();
            strb.AppendLine("Nombre: AK47 ");
            strb.AppendLine("Daño: " + this.Daño);
            strb.AppendLine("alcance: " + this.Alcance);
            return strb.ToString();
        }

    }
}
