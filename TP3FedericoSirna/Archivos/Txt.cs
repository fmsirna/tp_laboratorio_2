using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Archivos
{
    public class Txt: IArchivos
    {
        public void Guardar(string path, string texto)
        {

            StreamWriter writer = null;
            try
            {
                writer = new StreamWriter(path, false);
                writer.WriteLine(texto);
            }
            catch(Exception e)
            {
                throw e;
            }
            finally
            {
                if (writer != null)
                {
                    writer.Close();
                }
            }

        }

        public string Leer(string path)
        {
            using (StreamReader reader = new StreamReader(path))
            {
                return reader.ReadToEnd();
            }
        }

    }
}
