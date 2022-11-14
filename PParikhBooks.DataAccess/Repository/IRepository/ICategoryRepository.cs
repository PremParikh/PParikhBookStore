//using AndrewsBooks.DataAccess.Repository.IRepository;
using AndrewsBooks.DataAccess.Repository.IRepository;
using PParikhBooks.DataAccess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PParikhBooks.DataAccess.Repository.IRepository
{
    public class ICategoryRepository : IRepository<Category>
    {
        void Update(Category category);
    }
}
