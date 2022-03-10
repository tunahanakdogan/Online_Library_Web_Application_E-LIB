using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace elib_entity
{
    public class FavListItem
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public FavList favList { get; set; }
        public Book book { get; set; }
        public int FavListId { get; set; }
    }
}