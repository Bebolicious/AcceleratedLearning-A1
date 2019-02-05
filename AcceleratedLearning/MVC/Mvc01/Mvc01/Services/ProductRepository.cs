using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Rendering;
using Mvc01.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Mvc01.Services
{
    public class ProductRepository : IProductRepository
    {
        private IHostingEnvironment _env;
        public ProductRepository(IHostingEnvironment env)
        {
            _env = env;
        }

        public List<Spell> GetAll()
        {

        
            string root = _env.ContentRootPath;
            //return Ok(_env.ContentRootPath + @"\data\products.txt");
            string filename = Path.Combine(root, "Data", "spells.txt");
            //return Ok(filename);
            List<Spell> prodList = new List<Spell>();
            var prodarr = System.IO.File.ReadAllLines(filename);
            foreach (var item in prodarr)
            {
                var spell = new Spell
                {
                    Id = int.Parse(item.Split(',')[0]),
                    Name = item.Split(',')[1],
                    Description = item.Split(',')[2]
                };
                prodList.Add(spell);
            }
            //return Ok(prodarr);
            return prodList;
                

        }

        public Spell GetById(int id)
        {
            List<Spell> prodList = GetAll();
            return prodList.First(x => x.Id == id);
        }
        public IEnumerable<SelectListItem> GetAllNames()
        {
            List<Spell> prodList = GetAll();
            return prodList.Select(x =>new SelectListItem() {Value=x.Id.ToString(), Text=x.Name });
        }

        public void AddItem(Spell product)
        {
            product.Id = GetAll().Max(x => x.Id) + 1;
            string root = _env.ContentRootPath;
            //return Ok(_env.ContentRootPath + @"\data\products.txt");
            string filename = Path.Combine(root, "Data", "products.txt");
            File.AppendAllText(filename, Environment.NewLine+ $"{product.Id},{product.Name}, {product.Description}");
        }
    }
}
