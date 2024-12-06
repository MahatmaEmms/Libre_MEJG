using System;
using System.Collections.Generic;

namespace Libre_MEJG.Data.Models
{
    public class publisher
    {
        public int Id { get; set; }
        public string Name { get; set; }


        // Propiedades de navegación
        public List<Book> Books { get; set; }
    }
}

