using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyFirstWebAPI.Models
{
    public class TestingWebApi
    {
        [Required]
        public string Name { get; set; }
    }
}