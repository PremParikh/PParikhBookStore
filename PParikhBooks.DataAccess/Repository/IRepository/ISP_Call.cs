using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PParikhBooks.DataAccess.Repository.IRepository
{
    public interface ISP_Call : IDisposable
    {
        T single<T>(string procedurename, DynamicParameters param = null);
        void Execute(string procedurname, DynamicParameters param = null);
        T OneRecord<T>(string procedurename, DynamicParameters param = null);

        IEnumerable<T> List<T>(string procedurename, DynamicParameters param = null);

        Tuple<IEnumerable<T1>, IEnumerable<T2>> List<T1, T2>(string procedurename, DynamicParameters param = null);
//        T Single<T>(string procedurename, DynamicParameters)
    }
}
