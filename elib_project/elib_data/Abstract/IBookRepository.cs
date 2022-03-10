using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using elib_entity;
namespace elib_data.Abstract
{
    public interface IBookRepository : IRepository<Book>
    {

        Book GetBookDetails(string url);
        Book GetBookByIdWithCategories(int id);
        List<Book> GetBooksByCategory(string categoryName, int page, int pageSize);
        List<Book> GetSearchResults(string searchWord);
        int GetCountByCategory(string category);
        void Update(Book entity, int[] categoryId);
    }
}