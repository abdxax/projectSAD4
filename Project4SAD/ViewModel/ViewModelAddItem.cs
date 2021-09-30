using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Project4SAD.ViewModel
{
    public class ViewModelAddItem
    {
        [Required]
        public string NameItem { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string price { get; set; }
        [Required]
        public IFormFile ImgPath { get; set; }
    }
}
