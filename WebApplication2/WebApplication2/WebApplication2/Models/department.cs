using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class department
    {
        [Required]
        public int id { get; set; }
        public string name { get; set; }
        public string hodName { get; set; }
    }
}