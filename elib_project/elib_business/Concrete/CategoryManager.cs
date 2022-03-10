using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using elib_business.Abstract;
using elib_data.Abstract;
using elib_entity;

namespace elib_business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private ICategoryRepository _categoryRepository;
        public CategoryManager(ICategoryRepository categorRepository)
        {
            _categoryRepository = categorRepository;
        }
        public void Create(Category entity)
        {
            _categoryRepository.Create(entity);
        }

        public void Delete(Category entity)
        {
            _categoryRepository.Delete(entity);
        }

        public void DeleteBookFromCategory(int bookId, int categoryId)
        {
            _categoryRepository.DeleteBookFromCategory(bookId, categoryId);
        }

        public List<Category> GetAll()
        {
            return _categoryRepository.GetAll();
        }

        public Category GetById(int id)
        {
            return _categoryRepository.GetById(id);
        }

        public Category GetByIdWithBooksList(int id)
        {
            return _categoryRepository.GetByIdWithBookList(id);
        }

        public void Update(Category entity)
        {
            _categoryRepository.Update(entity);
        }
    }
}