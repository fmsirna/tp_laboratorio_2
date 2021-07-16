using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3
{
    [Serializable]
    /// <summary>
    /// clase para almacenar listas de arma segun su clase.
    /// aqui se aplica  tipo Generico
    /// </summary>
    public class Almacen
    {       
        
        private List<ArmaFabricada<Dragunov>> listaDragunov;
        private List<ArmaFabricada<AK47>> listaAK47;
        private List<ArmaFabricada<Uzi>> listaUzi;
        private List<Cuerpo> listaCuerpo;
        private int cantidad;
      
        public int Cantidad 
        {
            get => cantidad;
            set
            {
                if (value > 0)
                { cantidad = value; };
            }
        }

        public List<ArmaFabricada<Dragunov>> ListaDragunov { get => listaDragunov; set => listaDragunov = value; }
        public List<ArmaFabricada<AK47>> ListaAK47 { get => listaAK47; set => listaAK47 = value; }
        public List<ArmaFabricada<Uzi>> ListaUzi { get => listaUzi; set => listaUzi = value; }
        public List<Cuerpo> ListaCuerpo { get => listaCuerpo; set => listaCuerpo = value; }

        /// <summary>
        /// Cosntructor para generar una lista de cada arma
        /// </summary>
        public Almacen()
        {
            this.listaDragunov = new List<ArmaFabricada<Dragunov>>();
            this.listaAK47 = new List<ArmaFabricada<AK47>>();
            this.listaUzi = new List<ArmaFabricada<Uzi>>();
            this.listaCuerpo = new List<Cuerpo>();
        }


        /// <summary>
        /// sobrecarga del operador + para agragar armas a las listas
        /// </summary>
        public static Almacen operator +(Almacen almacen1, ArmaFabricada<Dragunov> arma)
        {
            almacen1.listaDragunov.Add(arma);
            almacen1.Cantidad = (almacen1.listaDragunov.Count + almacen1.listaAK47.Count + almacen1.listaUzi.Count) ; 
            return almacen1;
        }
        public static Almacen operator +(Almacen almacen1, ArmaFabricada<AK47> arma)
        {
            almacen1.listaAK47.Add(arma);
            almacen1.Cantidad = (almacen1.listaDragunov.Count + almacen1.listaAK47.Count + almacen1.listaUzi.Count);
            return almacen1;
        }
        public static Almacen operator +(Almacen almacen1, ArmaFabricada<Uzi> arma)
        {
            almacen1.listaUzi.Add(arma);
            almacen1.Cantidad = (almacen1.listaDragunov.Count + almacen1.listaAK47.Count + almacen1.listaUzi.Count);
            return almacen1;
        }

        public static Almacen operator +(Almacen almacen1, Cuerpo cuerpo)
        {
            almacen1.listaCuerpo.Add(cuerpo);           
            return almacen1;
        }
        public string informe()
        {
            StringBuilder strb = new StringBuilder();

            foreach (ArmaFabricada<Uzi> item in this.listaUzi)
            {
                strb.AppendLine(item.Detalle());
            }
            foreach (ArmaFabricada<AK47> item in this.listaAK47)
            {
                strb.AppendLine(item.Detalle());
            }
            foreach (ArmaFabricada<Dragunov> item in this.listaDragunov)
            {
                strb.AppendLine(item.Detalle());
            }

            return strb.ToString();

        }
    }
}
