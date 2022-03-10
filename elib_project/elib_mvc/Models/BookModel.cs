using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using elib_entity;

namespace elib_mvc.Models
{
    public class BookModel
    {
        public int bookId { get; set; }

        public int categoryId { get; set; }
        [Required(ErrorMessage = "Book name is required")]
        public string name { get; set; }
        [Required(ErrorMessage = "Book name is required")]
        public string bookUrl { get; set; }
        [Required(ErrorMessage = "Book name url is required")]
        public string url { get; set; }
        [Required(ErrorMessage = "Book image url is required")]

        public string imgUrl { get; set; }
        [Required(ErrorMessage = "Book author is required")]

        public string author { get; set; }
        //public List<string> categories { get; set; }
        [Required(ErrorMessage = "Book description is required")]
        public string description { get; set; }
        public List<Category> CategoriesOfBook { get; set; }
    }
}