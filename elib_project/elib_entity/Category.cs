using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace elib_entity
{
    public class Category
    {
        public int categoryId { get; set; }
        public string name { get; set; }
        public string url { get; set; }
        public List<BookCategory> BookCategories { get; set; }
    }
}