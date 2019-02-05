using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class Document
    {
        public string Title { get; set; }
        public int Pages { get; set; }
        public bool Summary { get; set; }
        public DateTime Publish { get; set; }
        public int Price { get; set; }
        public enum Filetype
        {
            pdf,
            doc,
            docx,
            txt
        }
      public List<string> Tags { get; set; }




    }
}
