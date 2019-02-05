using System;
using System.ComponentModel.DataAnnotations;

namespace NewsApp.Models
{
    public class News
    {
        public int Id { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 5)]
        public string Header { get; set; }

        [Required]
        [StringLength(200)]
        public string Intro { get; set; }

        [Required]
        [StringLength(2000)]
        public string Body { get; set; }

        [Required]
        public DateTime UpdatedDate { get; set; }

        [Required]
        public DateTime CreatedDate { get; set; }

        public Category Category { get; set; }

    }
}
