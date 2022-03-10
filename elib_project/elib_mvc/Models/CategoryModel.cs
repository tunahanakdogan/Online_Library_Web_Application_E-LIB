using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using elib_entity;

namespace elib_mvc.Models
{
    public class CategoryModel
    {
        public int categoryId { get; set; }
        [Required(ErrorMessage = "Name is required")]

        public string name { get; set; }
        public List<Book> Books { get; set; }
        [Required(ErrorMessage = "Url is required")]
        public string url { get; set; }
        public List<BookCategory> BookCategories { get; set; }
    }
}