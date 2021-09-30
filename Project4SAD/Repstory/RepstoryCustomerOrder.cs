using Project4SAD.Data;
using Project4SAD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project4SAD.Repstory
{
    public class RepstoryCustomerOrder : IRepstory<CustomerOrder>
    {
        private readonly DbAppContext _db;
        public RepstoryCustomerOrder(DbAppContext db)
        {
            _db = db;
        }
        public bool Add(CustomerOrder item)
        {
            _db.customerOrders.Add(item);
            _db.SaveChanges();
            return true;
        }

        public int Add2(CustomerOrder item)
        {
            _db.customerOrders.Add(item);
            _db.SaveChanges();
            return item.Id;

        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CustomerOrder> GetAll()
        {
            throw new NotImplementedException();
        }

        public CustomerOrder GetItem(int id)
        {
            return _db.customerOrders.FirstOrDefault(x => x.Id == id);
        }

        public bool Update(int id)
        {
            throw new NotImplementedException();
        }
    }
}
