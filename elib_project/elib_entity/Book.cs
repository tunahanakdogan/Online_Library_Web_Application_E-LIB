using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace elib_entity
{
    public class Book
    {
        public int bookId { get; set; }

        public int categoryId { get; set; }

        public string name { get; set; }
        public string url { get; set; }
        public string bookUrl { get; set; }
        public string imgUrl { get; set; }

        public string author { get; set; }
        //public List<string> categories { get; set; }
        public string description { get; set; }
        public List<BookCategory> BookCategories { get; set; }
    }
}