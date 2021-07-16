using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3
{
    /// <summary>
    /// Clase base de armas
    /// </summary>
    public class Arma
    {
        private int daño;
        private string alcance;

        private string manufacturador;

        public int Daño { get => daño; set => daño = value; }
        public string Alcance { get => alcance; set => alcance = value; }
        protected string Manufacturador { get => manufacturador; set => manufacturador = value; }

        public Arma(int daño, string alcance, string manufacturador)
        {
            this.Daño = daño;
            this.Alcance = alcance;
            this.Manufacturador = manufacturador;
        }
        /// <summary>
        /// Constructor el cual asigna strike undistries como manufacturador
        /// </summary>
        public Arma(int daño, string alcance) : this(daño,alcance,"strikeIndustries")
        {                     
        }
        public Arma()
        { }

        /// <summary>
        /// para devolver informacion del daño y alcance del arma, para ser usada por cada tipo de arma y devolver su nombre.
        /// </summary>
        public virtual string InfoArma() 
        {
            StringBuilder strb = new StringBuilder();           
            strb.AppendLine("Daño: " + this.Daño);
            strb.AppendLine("alcance: " + this.Alcance);
            return strb.ToString();
        }
     
    }
}
