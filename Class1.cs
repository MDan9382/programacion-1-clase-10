using programacion_1_clase_10.Clase_base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programacion_1_clase_10
{
    internal class playstation : ClsConsola
    {
        public string control { get; set; }
        public string mostrardetallesps()
        {
            mostrardetalles();
            return $"control modelo{control}";

        }
    }
}
