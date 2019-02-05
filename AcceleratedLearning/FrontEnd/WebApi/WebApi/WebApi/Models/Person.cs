using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class Person
    {
        [Required]
        public string Name { get; set; }
        [Range(0, 120)]
        public int Age { get; set; }



    }
}
