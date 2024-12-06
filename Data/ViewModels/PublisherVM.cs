using System.Collections.Generic;
using System;

namespace Libre_MEJG.Data
{
    public class PublisherVM
    {
        public string Name { get; set; }
    }



    public class PublisherWithBooksAndAuthorsVM
    {
        public string Name { get; set; }
        public List<BookAuthorVM> BookAuthors { get; set; }
    }



    public class BookAuthorVM
    {
        public string BookName { get; set; }
        public List<string> BookAuthors { get; set; }

    }
}
