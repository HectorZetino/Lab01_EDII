using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab01_EDII
{
    public class Datos
    {
        //Permite controlar y manejar la conversacion de datos en el arbol.
        private static Datos d = null;
        private static Busqueda b = new Busqueda();

        public static Datos data
        {
            get
            {
                if (d == null) d = new Datos();
                return d;
            }
        }
    }
}
