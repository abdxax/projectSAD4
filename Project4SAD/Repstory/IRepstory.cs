using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project4SAD.Repstory
{
    interface IRepstory<T>
    {
        IEnumerable<T> GetAll();
        T GetItem(int id);
        bool Add(T item);
        int Add2(T item);
        bool Update(int id);
        bool Delete(int id);
    }
}
