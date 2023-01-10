using Falcon.Models;
using Microsoft.AspNetCore.Mvc;

namespace Falcon.Controllers
{
    public class FirstController : Controller
    {
        private readonly WebDbContext _Db;
        public FirstController(WebDbContext Db)
        {
            _Db = Db;
        }
        public IActionResult Contact()
        {
            var datalist=_Db.Data.ToList();
            return View(datalist);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create (DataModel model )
        {
            _Db.Data.Add(model);
            _Db.SaveChanges();
            return RedirectToAction("Contact");
        }
        [HttpGet]
        public IActionResult Edit(int id) 
        {
            var dataa = _Db.Data.Where(x => x.Id == id).FirstOrDefault();
            return View(dataa);
        }
        [HttpPost]
        public IActionResult Edit(DataModel model)
        {
            var dataa = _Db.Data.Where(x => x.Id == model.Id).FirstOrDefault();
            if (dataa != null)
            {
                dataa.Email = model.Email;
                dataa.Password = model.Password;
                dataa.Message = model.Message;
                _Db.SaveChanges();

            }
            return View();

        }
        public IActionResult Details (int id)
        {
            var dataa = _Db.Data.Where(x => x.Id == id).FirstOrDefault();
            return View(dataa);
        }
        public IActionResult Delete(int id)
        {
            var dataa = _Db.Data.Where(x => x.Id == id).FirstOrDefault();
            _Db.Data.Remove(dataa);
            _Db.SaveChanges();
            return RedirectToAction("Contact");
        }
    }
}
