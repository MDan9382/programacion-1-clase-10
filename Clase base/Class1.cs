using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programacion_1_clase_10.Clase_base
{
    internal class ClsConsola
    {
        public string marca { get; set; }
        public int aniolanzamineto { get; set; }   
        public void mostrardetalles()
        {
            Console.WriteLine($"marca: {marca}, año: {aniolanzamineto}");
        }
    }
}
