using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace elib_entity
{
    public class FavList
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public List<FavListItem> favListItems { get; set; }
    }
}