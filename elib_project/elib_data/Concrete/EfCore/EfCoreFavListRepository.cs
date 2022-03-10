using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using elib_data.Abstract;
using elib_entity;
using Microsoft.EntityFrameworkCore;

namespace elib_data.Concrete.EfCore
{
    public class EfCoreFavListRepository : EfCoreGenericRepository<FavList, LibraryContext>, IFavListRepository
    {
        public void DeleteFromFavList(object favListId, int bookId)
        {
            using (var context = new LibraryContext())
            {
                var command = @"delete from FavListItems where FavListId =@p0 and BookId=@p1";
                context.Database.ExecuteSqlRaw(command, favListId, bookId);
            }
        }

        public FavList GetByUserId(string userId)
        {
            using (var context = new LibraryContext())
            {
                return context.FavLists.Include(a => a.favListItems).ThenInclude(b => b.book).FirstOrDefault(u => u.UserId == userId);
            }
        }

        public override void Update(FavList entity)
        {
            using (var context = new LibraryContext())
            {
                context.FavLists.Update(entity);
                context.SaveChanges();
            }
        }

    }
}