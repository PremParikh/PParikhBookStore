using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PParikhBooks.DataAccess.Repository.IRepository
{
    interface UnitOfWork : IDisposable
    {
        ICategoryRepository Category
        {
            get;
        }
        ISP_Call SP_Call { get;  }
    }

}
