using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab01_EDII
{
    public class Busqueda
    {
        //Permite principalmente una busqueda o manejo de informacion predeterminado por el genero.
        public int Find(Pelicula peli, Pelicula peli2)
        {
            return peli == null || peli2 == null ? 1 : peli.genre.CompareTo(peli2.genre);
        }
    }
}
