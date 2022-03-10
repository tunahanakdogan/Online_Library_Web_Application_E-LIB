using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using elib_data.Abstract;
using elib_data.Concrete.EfCore;
using elib_entity;
using Microsoft.EntityFrameworkCore;

namespace elib_data.Concrete
{
    public class EfCoreBookRepository : EfCoreGenericRepository<Book, LibraryContext>, IBookRepository
    {
        public Book GetBookByIdWithCategories(int id)
        {
            using (var context = new LibraryContext())
            {
                return context.Books.Where(b => b.bookId == id).Include(b => b.BookCategories).ThenInclude(b => b.category).FirstOrDefault();
            }
        }

        public Book GetBookDetails(string url)
        {
            using (var context = new LibraryContext())
            {

                return context.Books.Where(i => i.url == url).Include(i => i.BookCategories).ThenInclude(i => i.category).FirstOrDefault();
            }
        }

        public int GetCountByCategory(string category)
        {
            using (var context = new LibraryContext())
            {
                var books = context.Books.AsQueryable();
                if (!string.IsNullOrEmpty(category))
                {
                    books = books.Include(i => i.BookCategories).ThenInclude(i => i.category).Where(i => i.BookCategories.Any(a => a.category.url.ToLower() == category.ToLower()));
                }
                return books.Count();
            }
        }



        public List<Book> GetSearchResults(string searchWord)
        {
            using (var context = new LibraryContext())
            {
                var books = context.Books.Where(i => i.name.ToLower().Contains(searchWord.ToLower())).AsQueryable();
                Console.WriteLine(books);
                return books.ToList();
            }
        }

        public void Update(Book entity, int[] categoryId)
        {
            using (var context = new LibraryContext())
            {
                var book = context.Books.Include(b => b.BookCategories)
                .FirstOrDefault(b => b.bookId == entity.bookId);
                if (book != null)
                {
                    book.name = entity.name;
                    book.bookUrl = entity.bookUrl;
                    book.author = entity.author;
                    book.description = entity.description;
                    book.url = entity.url;
                    book.imgUrl = entity.imgUrl;
                    book.BookCategories = categoryId.Select(c => new BookCategory()
                    {
                        BookId = entity.bookId,
                        CategoryId = c
                    }).ToList();
                    context.SaveChanges();
                }
            }
        }

        List<Book> IBookRepository.GetBooksByCategory(string name, int page, int pageSize)
        {
            using (var context = new LibraryContext())
            {
                var books = context.Books.AsQueryable();
                if (!string.IsNullOrEmpty(name))
                {
                    books = books.Include(i => i.BookCategories).ThenInclude(i => i.category).Where(i => i.BookCategories.Any(a => a.category.url.ToLower() == name.ToLower()));
                }
                return books.Skip((page - 1) * pageSize).Take(pageSize).ToList();
            }

        }
    }
}