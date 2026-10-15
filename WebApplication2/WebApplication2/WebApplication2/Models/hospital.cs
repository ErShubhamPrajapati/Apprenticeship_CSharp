using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class hospital
    {
        [Required]
        public string name { get; set; }
        public string city { get; set; }
        public int totalBeds { get; set; }
    }
}