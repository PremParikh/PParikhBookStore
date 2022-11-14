using System;

namespace PParikhBooks.DataAccess.Repository
{
    public class ApplicationDbConetext
    {
        public object Categories { get; internal set; }
        public object Database { get; internal set; }

        internal object Set<T>(T t) where T : class
        {
            throw new NotImplementedException();
        }

        internal void SaveChanges()
        {
            throw new NotImplementedException();
        }

        internal Dbset<T> Set<T>()
        {
            throw new NotImplementedException();
        }

        internal void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}