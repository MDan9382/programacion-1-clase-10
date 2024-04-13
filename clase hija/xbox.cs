using programacion_1_clase_10.Clase_base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programacion_1_clase_10.clase_hija
{
    internal class xbox : ClsConsola
    {
        public bool gamepass {  get; set; } 
        public string mostrardetallesxb()
        {
            mostrardetalles();
            return $"tiene game pass: {gamepass}";
        }
    }
}
