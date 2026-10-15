using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class book
    {
        [Required]
        public int id { get; set; }
        public string title { get; set; }
        public string author { get; set; }

    }
}