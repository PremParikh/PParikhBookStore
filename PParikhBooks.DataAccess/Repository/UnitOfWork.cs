using PParikhBooks.DataAccess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PParikhBooks.DataAccess.Repository
{
    public class UnitOfWork
    {
        private readonly ApplicationDbConetext _db;

        public UnitOfWork(ApplicationDbConetext db)
        {
            _db = db;
            Category = new CategoryRepository(_db);
            SP_Call = new SP_Call(_db);
        }

        public ICategoryReposiyory Category { get; private set; }
        public ISP_Call SP_Call
        {
            get;
            private set;
        }
        public void Dispose()
        {
            _db.Dispose();
        }
        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
