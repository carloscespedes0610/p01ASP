using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace p01.Models
{
    public class Pelicula
    {
        public string Titulo { get; set; }
        public int Duracion { get; set; }
        public DateTime Pubicacion { get; set; }
        public string Pais { get; set; }
    }
}