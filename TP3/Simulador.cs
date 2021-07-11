using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace TP3
{
    public class Simulador
    {
        public delegate void DelegadoMostrar(Cuerpo cuerpo);

        public event DelegadoMostrar MostrarAlmacen;

        public List<Thread> hiloCuerpo;
        public Almacen almacen;

        public Simulador(Almacen almacen)
        {
            this.hiloCuerpo = new List<Thread>();
            this.almacen = almacen;
        }

        public void MetodoStart()
        {
            Thread nuevoHilo = new Thread(Informe);
            hiloCuerpo.Add(nuevoHilo);
            nuevoHilo.Start();
        }

        public void Informe()
        {
            foreach (Cuerpo item in almacen.ListaCuerpo)
            {
                Thread.Sleep(1500);
                this.MostrarAlmacen.Invoke(item);

            }

        }
        public void Cerrar()
        {
            foreach (Thread item in this.hiloCuerpo)
            {
                if (item.IsAlive)
                {
                    item.Abort();
                }
            }
        }




    }
}
