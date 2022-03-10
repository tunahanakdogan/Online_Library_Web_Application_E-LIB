using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace elib_mvc.Models
{
    public class FavListModel
    {
        public int favListId { get; set; }
        public List<FavListItemModel> FavListBooks { get; set; }
    }
}