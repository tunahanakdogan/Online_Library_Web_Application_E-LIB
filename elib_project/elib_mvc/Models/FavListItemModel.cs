using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace elib_mvc.Models
{
    public class FavListItemModel
    {
        public int FavListItemId { get; set; }
        public int bookId { get; set; }
        public string bookName { get; set; }
        public string bookAuthor { get; set; }
        public string bookImgUrl { get; set; }
    }
}