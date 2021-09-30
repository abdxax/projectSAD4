using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project4SAD.Data;
using Project4SAD.Models;
using Project4SAD.Repstory;
using Project4SAD.ViewModel;
using System.IO;
using System.Linq;

namespace Project4SAD.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        private readonly IRepstory<Pizza> _repPizaa;
        private readonly IWebHostEnvironment _host;
        private readonly DbAppContext _db;
        public AdminController(DbAppContext db, IWebHostEnvironment host)
        {
            _db = db;
            _repPizaa = new RepstoryPizza(db);
            _host = host;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Items()
        {
            var allItem = _repPizaa.GetAll();
            return View(allItem);

        }
        public IActionResult AddItem()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddItem(ViewModelAddItem item,IFormFile ImgPath)
        {
            if(item.ImgPath == null || item.ImgPath.Length==0)
            {
                return Content("no file ");
            }
            else
            {
                var path = Path.Combine(_host.ContentRootPath, "wwwroot\\image", item.ImgPath.FileName);
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    ImgPath.CopyTo(stream);
                    var m = new Pizza()
                    {
                        NameItem= item.NameItem,
                        Description=item.Description,
                        price=item.price,
                        ImgPath=path
                    };
                    if (_repPizaa.Add(m))
                    {
                        return Redirect("Items");
                    }

                }
            }
            return Redirect("AddItem");

        }

        public IActionResult Orders()
        {
            var b = (from i in _db.customerOrders select i ).ToList();
            return View(b);
        }

        public IActionResult Delete(int id)
        {
            _repPizaa.Delete(id);
            return Redirect("Items");
        }
    }
}
