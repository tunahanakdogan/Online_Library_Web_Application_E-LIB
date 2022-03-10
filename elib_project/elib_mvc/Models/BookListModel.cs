using System;
using System.Collections.Generic;
using elib_entity;
public class BookListModel
{
    public class PageInfo
    {
        public int totalBooks { get; set; }
        public int bookPerPage { get; set; }
        public int currentPage { get; set; }
        public string currentCategory { get; set; }
        public int totalPages()
        {
            return (int)Math.Ceiling((decimal)(totalBooks / bookPerPage)) + 1;
        }
    }
    public List<Book> books { get; set; }
    public PageInfo pageInfo { get; set; }
    public List<Category> categories { get; set; }
}