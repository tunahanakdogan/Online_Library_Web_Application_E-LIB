using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using elib_entity;
namespace elib_business.Abstract
{
    public interface IBookService
    {
        Book GetById(int id);
        Book GetBookByIdWithCategories(int id);
        List<Book> GetAll();
        List<Book> GetSearchResults(string searchWord);
        List<Book> GetBooksByCategory(string name, int page, int pageSize);
        Book GetBookDetails(string url);

        void Create(Book entity);
        void Update(Book entity);
        void Delete(Book entity);
        int GetCountByCategory(string category);
        void Update(Book entity, int[] categoryId);
    }
}