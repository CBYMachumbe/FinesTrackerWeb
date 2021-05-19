using Microsoft.EntityFrameworkCore;
using Persistence.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Persistence.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected FinesTrackerContext _context;
        protected DbSet<T> table;
        public GenericRepository()
        {
            _context = new FinesTrackerContext();
            table = _context.Set<T>();
        }

        public GenericRepository(FinesTrackerContext context)
        {
            _context = context;
            table = _context.Set<T>();
        }

        public IEnumerable<T> GetAll(int page, int pageLength)
        {
            return table.ToList().Skip(pageLength * (page - 1)).Take(pageLength);
        }

        public T GetById(object id)
        {
            return table.Find(id);
        }

        public T Insert(T obj)
        {
            var inserted = table.Add(obj).Entity;
            Save();

            return inserted;
        }

        public void Update(T obj)
        {
            table.Attach(obj);
            _context.Entry(obj).State = EntityState.Modified;
            Save();
        }

        public void Delete(object id)
        {
            var existing = table.Find(id);
            table.Remove(existing);
            Save();
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
