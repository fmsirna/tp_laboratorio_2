using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Archivos;
using TP3;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {

        /// <summary>
        /// Este metodo de Test unitario verifica que se creen las las armas
        /// El metodo falla si alguna de las armas tienen valor null
        /// </summary>
        [TestMethod]
        public void Creararmas()
        {
            //arrange

            Dragunov sniper1 = new Dragunov();
            AK47 rifle1 = new AK47(150,"largo");
            Uzi submachine = new Uzi();

            //act
            if (sniper1.Alcance == null || rifle1 == null || submachine == null || submachine.Alcance == null)
            {
                //assert
                Assert.Fail();
            }

        }

        /// <summary>
        /// Este metodo de Test unitario leera un archivo de texto existente al pasarle el path
        /// Si no puede leer el metodo falla el Test
        /// </summary>
        [TestMethod]
        public void LeerArchivo()
        {
            //arrange
            Txt texto = new Txt();

            string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\ListaGeneral.txt";

            string datosString = "el texto se guardo exitosamente";

            //act
            texto.Guardar(ruta, datosString);

            try
            {
                texto.Leer(ruta);
            }
            catch (Exception)
            {
                Assert.Fail();
            }
        }

        /// <summary>
        /// Este metodo de Test unitario verifica que se agregen las armas al almacen
        /// El metodo falla si la lista del almacen no contiene armas
        /// </summary>
        [TestMethod]
        public void AgregarArmas()
        {
            //arrange

            Dragunov sniper1 = new Dragunov();           
            Cuerpo ligero = new Cuerpo("ligero", eMaterial.FibraCarbono, 70);
            Almacen almacen1 = new Almacen();           
            ArmaFabricada<Dragunov> arma = new ArmaFabricada<Dragunov>(sniper1, ligero, eCañoñ.Cavalry34);

            almacen1 += arma;

            //act
            if (almacen1.ListaDragunov.Count == 0)
            {
                //assert
                Assert.Fail();
            }

        }

    }
}
