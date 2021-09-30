using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


namespace Project4SAD.Models
{
    public class Pizza
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string NameItem { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string price { get; set; }
        [Required]
        public string ImgPath { get; set; }
    }
}
