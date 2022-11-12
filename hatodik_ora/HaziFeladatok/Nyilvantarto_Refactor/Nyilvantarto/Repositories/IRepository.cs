using System;
using System.Collections.Generic;
using System.Text;

namespace Nyilvantarto.Repositories
{
    public interface IRepository<T>
    {
        List<T> Get();
        T GetByName(string name);
        bool Add(T t);
        void RemoveByName(string name);
    }
}
