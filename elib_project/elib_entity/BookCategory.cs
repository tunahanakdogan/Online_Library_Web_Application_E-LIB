using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace elib_entity
{
    public class BookCategory
    {
        public int CategoryId { get; set; }
        public Category category { get; set; }
        public int BookId { get; set; }
        public Book Book { get; set; }
    }
}
