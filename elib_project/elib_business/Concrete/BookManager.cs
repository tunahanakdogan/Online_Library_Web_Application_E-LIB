
using System.Collections.Generic;
using elib_business.Abstract;
using elib_data.Abstract;
using elib_data.Concrete;
using elib_entity;

namespace elib_business.Concrete
{
    public class BookManager : IBookService
    {

        private IBookRepository _bookRepository;
        public BookManager(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public void Create(Book entity)
        {
            _bookRepository.Create(entity);
        }

        public void Delete(Book entity)
        {
            _bookRepository.Delete(entity);
        }

        public List<Book> GetAll()
        {
            return _bookRepository.GetAll();
        }

        public Book GetBookByIdWithCategories(int id)
        {
            return _bookRepository.GetBookByIdWithCategories(id);
        }

        public Book GetBookDetails(string url)
        {
            return _bookRepository.GetBookDetails(url);
        }

        public List<Book> GetBooksByCategory(string name, int page, int pageSize)
        {
            return _bookRepository.GetBooksByCategory(name, page, pageSize);
        }

        public Book GetById(int id)
        {
            return _bookRepository.GetById(id);
        }

        public int GetCountByCategory(string category)
        {
            return _bookRepository.GetCountByCategory(category);
        }

        public List<Book> GetSearchResults(string searchWord)
        {
            return _bookRepository.GetSearchResults(searchWord);
        }

        public void Update(Book entity)
        {
            _bookRepository.Update(entity);
        }

        public void Update(Book entity, int[] categoryId)
        {
            _bookRepository.Update(entity, categoryId);
        }
    }
}