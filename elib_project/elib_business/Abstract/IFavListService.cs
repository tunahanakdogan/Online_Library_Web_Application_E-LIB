using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using elib_entity;

namespace elib_business.Abstract
{
    public interface IFavListService
    {
        void InitializeList(string userId);
        FavList GetFavListByUserId(string userId);

        void AddToList(string userId, int bookId);
        void DeleteFromFavList(string userId, int bookId);
    }
}