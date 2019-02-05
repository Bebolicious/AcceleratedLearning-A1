using Microsoft.AspNetCore.Mvc.Rendering;
using Mvc01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mvc01.ViewModels
{
    public class ProductListVm
    {
        public IEnumerable<SelectListItem> AllProducts { get; set; }
        public Spell Spell { get; set; }
    }
}
