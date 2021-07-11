using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3
{
    public static class ExtensionMethod
    {
        public static int ArmaCount(this Almacen almacen)
        {
            int count;
            count = almacen.ListaAK47.Count + almacen.ListaUzi.Count + almacen.ListaDragunov.Count;
            return count;
        }


    }
}
