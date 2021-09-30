using Project4SAD.Data;
using Project4SAD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project4SAD.Repstory
{
    public class RepstoryCustomer : IRepstory<Customer>
    {
        private readonly DbAppContext _db;
        public RepstoryCustomer(DbAppContext db)
        {
            _db = db;
        }
        public bool Add(Customer item)
        {
            _db.customers.Add(item);
            _db.SaveChanges();
            return true;
        }

        public int Add2(Customer item)
        {
           var x= _db.customers.Add(item);
            _db.SaveChanges();
            return item.Id;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Customer> GetAll()
        {
            throw new NotImplementedException();
        }

        public Customer GetItem(int id)
        {
            return _db.customers.FirstOrDefault(x => x.Id == id);
        }

        public bool Update(int id)
        {
            throw new NotImplementedException();
        }
    }
}
