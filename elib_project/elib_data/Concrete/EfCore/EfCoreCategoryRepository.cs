using System.Collections.Generic;
using System.Linq;
using elib_data.Abstract;
using elib_entity;
using Microsoft.EntityFrameworkCore;

namespace elib_data.Concrete.EfCore
{
    public class EfCoreCategoryRepository : EfCoreGenericRepository<Category, LibraryContext>, ICategoryRepository
    {
        public void DeleteBookFromCategory(int bookId, int categoryId)
        {
            using (var context = new LibraryContext())
            {
                var command = "DELETE FROM bookcategory WHERE bookId=@p0 and categoryId=@p1";
                context.Database.ExecuteSqlRaw(command, bookId, categoryId);
            }
        }

        public Category GetByIdWithBookList(int categoryId)
        {
            using (var context = new LibraryContext())
            {
                return context.Categories.Where(i => i.categoryId == categoryId).Include(i => i.BookCategories).ThenInclude(i => i.Book).FirstOrDefault();
            }
        }
    }
}