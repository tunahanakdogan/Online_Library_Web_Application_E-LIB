using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using elib_entity;

namespace elib_mvc.Models
{
    public class BookDetailModel
    {
        public Book Book { get; set; }
        public List<Category> Categories { get; set; }
    }
}