using Project4SAD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project4SAD.ViewModel
{
    public class ViewModelShowCar
    {
        public IEnumerable<Pizza> pizzas { get; set; }
        public Customer customer { get; set; }
    }
}
