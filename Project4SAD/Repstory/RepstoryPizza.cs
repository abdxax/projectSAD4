using Project4SAD.Data;
using Project4SAD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project4SAD.Repstory
{
    public class RepstoryPizza : IRepstory<Pizza>
    {
        private readonly DbAppContext dbApp;

        public RepstoryPizza(DbAppContext db)
        {
            dbApp = db;
        }
        public bool Add(Pizza item)
        {
            dbApp.pizzas.Add(item);
            dbApp.SaveChanges();
            return true;
        }

        public int Add2(Pizza item)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            var item = GetItem(id);
            dbApp.pizzas.Remove(item);
            dbApp.SaveChanges();
            return true;

        }

        public IEnumerable<Pizza> GetAll()
        {
            return dbApp.pizzas.ToList();
        }

        public Pizza GetItem(int id)
        {
            return dbApp.pizzas.FirstOrDefault(x => x.Id == id); 
        }

        public bool Update(int id)
        {
            throw new NotImplementedException();
        }
    }
}
