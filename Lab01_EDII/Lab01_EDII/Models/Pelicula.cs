using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab01_EDII
{
    public class Pelicula
    {
        public string director { get; set; }
        public double imdbRating { get; set; }
        public string genre { get; set; }
        public string releaseDate { get; set; }
        public int rottenTomatoesRating { get; set; }
        public string title { get; set; }

        public Pelicula(string D, double I, string G, string RD, int RTR, string T) 
        {
            D = director;
            I = imdbRating;
            G = genre;
            RD = releaseDate;
            RTR = rottenTomatoesRating;
            T = title;
        }
    }
}
