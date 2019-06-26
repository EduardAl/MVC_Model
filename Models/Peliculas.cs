using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MVC_Model.Models
{
    public class Peliculas
    {
        public int Id { get; set; }
        public String Titulo { get; set; }
        public DateTime FechaSalida { get; set; }
        public String Genero { get; set; }
        public Decimal Precio { get; set; }

    }
    public class PeliculasDbContext : DbContext
    {
        public DbSet<Peliculas> peli { get; set; }
        public PeliculasDbContext()
            : base("name=PeliculasModelConeccion")
        { }
    }
}