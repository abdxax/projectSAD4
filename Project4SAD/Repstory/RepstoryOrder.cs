using Project4SAD.Data;
using Project4SAD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project4SAD.Repstory
{
    public class RepstoryOrder : IRepstory<Order>
    {
        private readonly DbAppContext _db;
        public RepstoryOrder(DbAppContext db)
        {
            _db = db;
        }
        public bool Add(Order item)
        {
            _db.orders.Add(item);
            _db.SaveChanges();
            return true;
        }

        public int Add2(Order item)
        {
            _db.orders.Add(item);
            _db.SaveChanges();
            return 1;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Order> GetAll()
        {
            throw new NotImplementedException();
        }

        public Order GetItem(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(int id)
        {
            throw new NotImplementedException();
        }
    }
}
