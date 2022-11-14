//using AndrewsBooks.DataAccess.Repository.IRepository;
using PParikhBookStore.DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AndrewsBooks.DataAccess.Repository.IRepository;

namespace PParikhBooks.DataAccess.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly ApplicationDbContext _db;
        internal Dbset<T> dbset;



        public Repository(ApplicationDbConetext db)
        {
            _db = db;
            this.dbset = db.Set<T>();
        }
        public void Add(T enttity)
        {

        }
    }
}

