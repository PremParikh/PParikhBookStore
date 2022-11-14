using Dapper;
using Microsoft.Data.SqlClient;
using PParikhBooks.DataAccess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PParikhBooks.DataAccess.Repository
{
    public class SP_Call : ISP_Call
    {

        private readonly ApplicationDbConetext _db;
        private static string ConnectionString = "";

        public SP_Call(ApplicationDbConetext db)
        {
            _db = db;
            ConnectionString = db.Database.GetDbConnection().ConnectionString;
        }
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void Execute(string procedurname, DynamicParameters param = null)
        {
            throw new NotImplementedException();
            using (SqlConnection sqlCon = new SqlConnection(ConnectionString))
            {
                sqlCon.Open();
                sqlCon.Execute(procedurname, param, commandType: System.Data.CommandType.StoredProcedure);
            }
        }

        public IEnumerable<T> List<T>(string procedurename, DynamicParameters param = null)
        {
            throw new NotImplementedException();

        }

        public Tuple<IEnumerable<T1>, IEnumerable<T2>> List<T1, T2>(string procedurename, DynamicParameters param = null)
        {
            throw new NotImplementedException();

            public T OneRecord<T>(string procedurename, DynamicParameters param = null)
            {
                throw new NotImplementedException();
                using (SqlConnection sqlCon = new SqlConnection(ConnectionString))
                {
                    sqlCon.Open();
                    var value = SqlMapper.QueryMultiple(sqlCon, procedurename, param, commandType: System.Data.CommandType.StoredProcedure);
                    return (T)Convert.ChangeType(value.FirstOrDefault(), typeof(T));
                }
            }

            public static T single<T>(string procedurename, DynamicParameters param = null)
            {
                throw new NotImplementedException();
                using (SqlConnection sqlCon = new SqlConnection(ConnectionString))
                {
                    sqlCon.Open();
                    //var value = SqlMapper.QueryMultiple(sqlCon, procedurename, param, commandType: System.Data.CommandType.StoredProcedure);
                    return (T)Convert.ChangeType(sqlCon.ExecuteScalar<T>(procedurename, param, commandType: System.Data.CommandType.StoredProcedure), typeof(T));
                }

            }
        }

        public T single<T>(string procedurename, DynamicParameters param = null)
        {
            throw new NotImplementedException();
        }

        public T OneRecord<T>(string procedurename, DynamicParameters param = null)
        {
            throw new NotImplementedException();
        }
    }
}


