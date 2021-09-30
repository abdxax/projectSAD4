using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Project4SAD.ViewModel
{
    public class ViewModelRegister
    {
        [Required(ErrorMessage ="الرجاء ادخال البريد الالكتروني بشكل صحيح")]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string pass { get; set; }
    }
}
