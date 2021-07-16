using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Archivos
{
    public class Serializer
    {

        /// <summary>
        /// Para guardar las listas de armas en formato XML
        /// </summary>
        public bool Guardar<T>(string nombre, List<T> list)
        {
            bool retorno = false;

            try
            {
                using (XmlTextWriter newTW = new XmlTextWriter(AppDomain.CurrentDomain.BaseDirectory + nombre, Encoding.UTF8))
                {
                    XmlSerializer nuevoXml = new XmlSerializer(typeof(List<T>));
                    nuevoXml.Serialize(newTW, list);
                    retorno = true;
                }

            }
            catch (Exception e)
            {
                throw e;
            }

            return retorno;

        }


        /// <summary>
        /// para leer las listas de armas del formato xml
        /// </summary>
        public List<T> Leer<T>(string nombre)
        {
            List<T> list = null;
            try
            {
                XmlSerializer nuevoXml = new XmlSerializer(typeof(List<T>));

                using (XmlTextReader newTR = new XmlTextReader(AppDomain.CurrentDomain.BaseDirectory + nombre))
                {
                    list = (List<T>)nuevoXml.Deserialize(newTR);

                }

            }
            catch (Exception e)
            {
                throw e;
            }

            return list;

        }

    }
}
