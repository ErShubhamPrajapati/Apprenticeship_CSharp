using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class car
    {
        [Required]
        public string company { get; set; }
        public string model { get; set; }
        public int price { get; set; }

    }
}