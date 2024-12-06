using System.Collections.Generic;
using System;

namespace Libre_MEJG.Data.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string FullName { get; set; }


        // Propiedades de navegación

        public List<Book_Author> Book_Author { get; set; }
    }
}
