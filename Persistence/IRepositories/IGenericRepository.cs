using System;
using System.Collections.Generic;
using System.Text;

namespace Persistence.IRepositories
{
   public interface IGenericRepository<T> where T : class
    {
        IEnumerable<T> GetAll(int page, int pageLength);
        T GetById(object id);
        T Insert(T obj);
        void Update(T obj);
        void Delete(object id);
        void Save();
    }
}
