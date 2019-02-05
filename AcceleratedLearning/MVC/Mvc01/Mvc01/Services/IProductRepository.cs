using Microsoft.AspNetCore.Mvc.Rendering;
using Mvc01.Models;
using System.Collections.Generic;

namespace Mvc01.Services
{
    public interface IProductRepository
    {
        List<Spell> GetAll();
        Spell GetById(int id);
        IEnumerable<SelectListItem> GetAllNames();
        void AddItem(Spell spell);
    }
}