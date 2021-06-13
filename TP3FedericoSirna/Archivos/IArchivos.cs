using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archivos
{
    public interface IArchivos
    {
        void Guardar(string path, string texto);

        string Leer(string path);
    }
}
