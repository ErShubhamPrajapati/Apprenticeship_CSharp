using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class college
    {
        [Required]
        public string collegeName { get; set; }
        public string city { get; set; }
        public string course { get; set; }
    }
}