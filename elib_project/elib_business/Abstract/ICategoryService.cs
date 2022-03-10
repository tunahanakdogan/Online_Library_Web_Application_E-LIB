using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using elib_entity;

namespace elib_business.Abstract
{
    public interface ICategoryService
    {
        Category GetById(int id);
        Category GetByIdWithBooksList(int id);
        List<Category> GetAll();
        void Create(Category entity);
        void Update(Category entity);
        void Delete(Category entity);
        void DeleteBookFromCategory(int bookId, int categoryId);
    }
}