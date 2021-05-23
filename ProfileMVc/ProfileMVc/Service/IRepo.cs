using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProfileMVc.Service
{
    public interface IRepo<T>
    {
        IEnumerable<T> GetAll();
        T Get(int id);
        void Add(T t);
        void update(int id, T t);
    }
}