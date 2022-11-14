using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PParikhBooks.DataAccess.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryReposiyory
    {
        public readonly ApplicationDbConetext _db;
        
        public CategoryRepository(ApplicationDbConetext db) : base (db)
        {
            _db = db;

        }
        public void Update(Category category)
        {
            //throw new NotImplementedException();
            var objFromDb = _db.Categories.FirstOrDefault(s => s.Id == category.Id);
            if (objFromDb != null)
            {
                objFromDb.Name = category.Name;
                _db.SaveChanges();
            }
        }
    }
}
