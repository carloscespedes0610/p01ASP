using p01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace p01.Service
{
    public class PeliculaService
    {
        public Pelicula Obtener_Pelicula() {
            return new Pelicula() {
                Titulo = "Silicon Valley",
                Duracion = 115,
                Pais = "Bolivia",
                Pubicacion = new DateTime(2018,12,26)
            };
        }
        public List<Pelicula> ObtenerPeliculas() {
            List<Pelicula> lp = new List<Pelicula>();
            lp.Add(new Pelicula() {
                Titulo = "Duro de Matar",
                Duracion = 110,
                Pais = "USA",
                Pubicacion = new DateTime(2016,11,29)
            });
            lp.Add(new Pelicula()
            {
                Titulo = "Piratas del Caribe",
                Duracion = 175,
                Pais = "Caribe",
                Pubicacion = new DateTime(2017, 12, 11)
            });
            lp.Add(new Pelicula()
            {
                Titulo = "Transformers",
                Duracion = 145,
                Pais = "USA",
                Pubicacion = new DateTime(2014, 10, 11)
            });
            return lp;
        }
    }
}