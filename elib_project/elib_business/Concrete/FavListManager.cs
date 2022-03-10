using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using elib_business.Abstract;
using elib_data.Abstract;
using elib_entity;

namespace elib_business.Concrete
{
    public class FavListManager : IFavListService
    {

        private IFavListRepository _favListRepository;
        public FavListManager(IFavListRepository favListRepository)
        {
            _favListRepository = favListRepository;
        }

        public void AddToList(string userId, int bookId)
        {
            var favList = GetFavListByUserId(userId);
            var index = favList.favListItems.FindIndex(i => i.BookId == bookId);

            if (index < 0)
            {
                favList.favListItems.Add(new FavListItem()
                {
                    BookId = bookId,
                    FavListId = favList.Id
                });
            }
            foreach (var item in favList.favListItems)
            {
                Console.WriteLine(bookId);
            }
            _favListRepository.Update(favList);
        }

        public void DeleteFromFavList(string userId, int bookId)
        {
            var favlist = GetFavListByUserId(userId);
            _favListRepository.DeleteFromFavList(favlist.Id, bookId);
        }

        public FavList GetFavListByUserId(string userId)
        {
            return _favListRepository.GetByUserId(userId);
        }

        public void InitializeList(string userId)
        {
            _favListRepository.Create(new FavList() { UserId = userId });
        }
    }
}