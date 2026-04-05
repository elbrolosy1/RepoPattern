using BookStore.Core.Reps.Igeneric;
using BookStore.EF.AppDbContect;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Core.Reps.GenericRepos
{
    public class GenericRep<T> : IGenericRepo<T> where T : class
    {
        private readonly AppDbContext _context;
        private readonly DbSet<T> _dbset;

        public GenericRep(AppDbContext context)
        {
            _context = context;
            _dbset = _context.Set<T>();
        }

        public void Add(T item)
        {
            _dbset.Add(item);
            Save();
        }

        public void Delete(int id )
        {
            var res = GetById(id);
            if (res != null)
            {
                _dbset.Remove(res);
                Save();
            }
        }

        public IEnumerable<T> GetAll()
        {
            var result = _dbset.ToList();
            return result;
        }

        public T GetById(int id)
        {
            var item = _dbset.Find(id);
            return item;
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(T item)
        {
            _dbset.Update(item);
            Save();
        }
    }
}
