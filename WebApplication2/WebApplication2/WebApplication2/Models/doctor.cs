using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class doctor
    {
        [Required]
        public int id { get; set; }
        public string name { get; set; }
        public string specialization { get; set; }
    }
}