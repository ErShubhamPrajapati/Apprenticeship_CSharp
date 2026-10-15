using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class laptop
    {
        [Required]
        public string brand { get; set; }
        public string processor { get; set; }
        public int ram { get; set; }
    }
}