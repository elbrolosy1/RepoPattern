using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Core.Reps.Igeneric
{
    public interface IGenericRepo<T> where T : class
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
        void Add(T item);
        void Update(T item);
        void Delete (int id);
        void Save();
    }
}
