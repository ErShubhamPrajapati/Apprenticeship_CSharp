using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class employee
    {
        [Required]
        public int id { get; set; }
        public string name { get; set; }
        public int salary { get; set; }


    }
}