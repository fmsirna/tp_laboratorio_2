using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3
{
    /// <summary>
    /// clase para fabricar un arma con la clase cuerpo y cañon
    /// aqui se aplica Interfaces y tipo Generico
    /// </summary>
    public class ArmaFabricada<T> : Icontenido where T : Arma
    {
        private T clase;
        private Cuerpo cuerpo;
        private eCañoñ cañon;
        public ArmaFabricada()
        {
        }


        /// <summary>
        /// constructor de arma fabricada para agregar las propiedades
        /// </summary>
        public ArmaFabricada(T clase, Cuerpo cuerpo, eCañoñ cañon)
        {
            this.clase = clase;
            this.cuerpo = cuerpo;
            this.cañon = cañon;
        }

        public T Clase { get => clase; set => clase = value; }
        public Cuerpo Cuerpo { get => cuerpo; set => cuerpo = value; }
        public eCañoñ Cañon { get => cañon; set => cañon = value; }

        /// <summary>
        /// funcion para dar un detalle de las partes del arma fabricada
        /// </summary>
        public string Detalle()
        {
            StringBuilder strb = new StringBuilder();
            strb.Append(Clase.InfoArma());
            strb.Append(Cuerpo.InfoCuerpo());
            strb.Append("cañoñ: " + this.Cañon);
            strb.AppendLine("");
            return strb.ToString();
        }
    }
}
