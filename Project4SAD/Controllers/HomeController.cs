using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.Office.CustomUI;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Project4SAD.Data;
using Project4SAD.Models;
using Project4SAD.Repstory;
using Project4SAD.ViewModel;

namespace Project4SAD.Controllers
{
    public class HomeController : Controller
    {
        private readonly RepstoryPizza _pizza;
        private readonly RepstoryCustomer _customer;
        private readonly RepstoryCustomerOrder _corder;
        private readonly RepstoryOrder _order;
       // private readonly DbAppContext _db;
        private static List<Pizza> items =  new List<Pizza>();

        public HomeController(DbAppContext db)
        {
           // _db = db;
            _pizza =new RepstoryPizza(db);
            _customer = new RepstoryCustomer(db);
            _corder = new RepstoryCustomerOrder(db);
            _order = new RepstoryOrder(db);
           
        }
        public IActionResult Index()
        {
            var result = _pizza.GetAll();
            var vie = new ViewModelIndex()
            {
                pizzas = result,
                carShoping = items.Count
            };
            
            return View(vie);
        }

        public IActionResult getData(int id)
        {
          //  List<Pizza> p = new List<Pizza>();
            Pizza x = _pizza.GetItem(id);

            if (AddToList(x))
            {
              //  HttpContext.Session.SetString("item", JsonConvert.SerializeObject(items));
                return RedirectToAction("Index","Home");
            }
            return Content(items.Count+"e");
        }

        public IActionResult ShowCar()
        {
            IEnumerable<Pizza> p = items;
            var show = new ViewModelShowCar()
            {
                pizzas = p
        };
            return View(show);
        }

        public IActionResult AddListItem(ViewModelShowCar car)
        {
            var x = _customer.Add2(car.customer);
            var b = _customer.GetItem(x);
            var c = new CustomerOrder()
            {
                customer=b,
                Status="new"
            };
            var bc= _corder.Add2(c);
            var ord = _corder.GetItem(bc);
            foreach (var i in items)
            {
                var m = new Order()
                {
                    customerOrder=bc,
                    Pizza=i.Id,
                    Count=1
                };
                _order.Add(m);
                  
            }
            items.Clear();
           
           
            return Redirect("Index");
        }
           
       
        public bool AddToList (Pizza p)
        {
            items.Add(p);
            
            return true;
        }
    }
}
