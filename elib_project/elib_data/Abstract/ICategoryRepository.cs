using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using elib_entity;
namespace elib_data.Abstract
{
    public interface ICategoryRepository : IRepository<Category>
    {
        Category GetByIdWithBookList(int categoryId);
        void DeleteBookFromCategory(int bookId, int categoryId);
    }
}