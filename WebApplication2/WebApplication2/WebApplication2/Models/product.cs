using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class product
    {
        [Required]
        public int id { get; set; }
        public string name { get;set; }
      public int price { get; set; }
    }
}