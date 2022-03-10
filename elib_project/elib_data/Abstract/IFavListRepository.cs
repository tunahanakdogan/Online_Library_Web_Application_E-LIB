using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using elib_entity;

namespace elib_data.Abstract
{
    public interface IFavListRepository : IRepository<FavList>
    {
        FavList GetByUserId(string userId);
        void DeleteFromFavList(object favListId, int bookId);
    }
}