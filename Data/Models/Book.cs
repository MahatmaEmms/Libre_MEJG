using System.Collections.Generic;
using System.Security.Policy;
using System;

namespace Libre_MEJG.Data.Models
{
    public class Book
    {
        public int id { get; set; }

        public string Titulo { get; set; }

        public string Descripcion { get; set; }

        public bool IsRead { get; set; }

        public DateTime? DateRead { get; set; }

        public int? Rate { get; set; }

        public string Genero { get; set; }

        public string Autor { get; set; }

        public string ConverUrl { get; set; }

        public DateTime DateAdded { get; set; }

        // Propiedades de navegación (en esta parte es donde "mapeamos")
        public int Publisherid { get; set; }
        public publisher publisher { get; set; }
        public List<Book_Author> Book_Author { get; set; }

    }
}
