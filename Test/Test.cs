using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using TP3;
using Archivos;


namespace Test
{
    class Test
    {
        static void Main(string[] args)
        {
            Dragunov sniper1 = new Dragunov();
            AK47 rifle1 = new AK47();
            Uzi submachine = new Uzi();
            Cuerpo ligero = new Cuerpo("ligero", eMaterial.FibraCarbono, 70);
            Cuerpo pesado = new Cuerpo("Pesado", eMaterial.Metal, 150);

            Almacen almacen1 = new Almacen();
            Almacen almacen2 = new Almacen();
            ArmaFabricada<Dragunov> arma = new ArmaFabricada<Dragunov>(sniper1, ligero, eCañoñ.Cavalry34);
            ArmaFabricada<AK47> arma2 = new ArmaFabricada<AK47>(rifle1, pesado, eCañoñ.SteelFire);
            ArmaFabricada<Uzi> arma3 = new ArmaFabricada<Uzi>(submachine, ligero, eCañoñ.TitaniumStrike);



            almacen1 += arma;
            almacen1 += arma2;
            almacen1 += arma3;

            Console.WriteLine("metodo extension:");
            Console.WriteLine(almacen1.ArmaCount());

            try
            {
                string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\ListaGeneral.txt";
                //string ruta2 = AppDomain.CurrentDomain.BaseDirectory + @"\Prueba2.txt";
                Txt arch = new Txt();
                arch.Guardar(ruta, almacen1.informe());

            }
            catch (UnauthorizedAccessException e)
            {
                Console.WriteLine("acceso no authorizado" + e);
            }
            catch (Exception e)
            {
                Console.WriteLine("error inesperado" + e);
            }

            try
            {
                string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\ListaGeneral.txt";
                Txt arch = new Txt();
                Console.WriteLine(arch.Leer(ruta));

            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("acceso no authorizado");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("archivo no encontrado");
            }
            catch (Exception e)
            {
                Console.WriteLine("error inesperado" + e);
            }

            Serializer serializadora = new Serializer();

            if (serializadora.Guardar("ListaDragunov.xml", almacen1.ListaDragunov))
            {
                Console.WriteLine("Archivo Guardado exitosamente");
            }

            if (serializadora.Guardar("ListaUzi.xml", almacen1.ListaUzi))
            {
                Console.WriteLine("Archivo Guardado exitosamente");
            }
            if (serializadora.Guardar("ListaAK47.xml", almacen1.ListaAK47))
            {
                Console.WriteLine("Archivo Guardado exitosamente");
            }

            List<ArmaFabricada<AK47>> list = serializadora.Leer<ArmaFabricada<AK47>>("ListaAK47.xml");
            if (!(list is null))
            {
                almacen2.ListaAK47 = list;
                Console.WriteLine(almacen2.informe());
            }



            Console.ReadLine();
        }
    }
}
