using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Mvc01.Models;
using Mvc01.Services;
using Mvc01.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Mvc01.Controllers
{

    public class ProductController : Controller
    {
        private IProductRepository _repo;

        public ProductController(IProductRepository env)
        {
            _repo = env;
        }
        public IActionResult Testy()
        {
            return View();
        }

        public IActionResult Index()
        {
            var vm = new ProductListVm
            {
                AllProducts = _repo.GetAllNames()
            };

            return View(vm);
        }
        [HttpPost]
        public IActionResult Index(Spell spell)
        {
            _repo.AddItem(spell);

            return RedirectToAction("ListAll");
        }
        public IActionResult Yrittää()
        {
            return View();
        }

        public IActionResult ProductList()
        {
            return View();
        }
        public IActionResult ListAll()
        {
            //var repository = new Services.ProductRepository();

            List<Spell> prodList = _repo.GetAll();

            return View(prodList);

        }

        public IActionResult GetById(int id)
        {
            //var repository = new Services.ProductRepository();

            Spell prod = _repo.GetById(id);

            return View(prod);

        }
    }
}
