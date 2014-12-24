using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVCArchitecturePractice.Web.Models
{
    public class UserRegisterModel
    {
        [Display(Name = "")]

        public string Name { get; set; }

        [Display(Name = "")]
        [Required(ErrorMessage = "")]
        [DataType(DataType.Password)]
        [StringLength(30, MinimumLength = 6, ErrorMessage = "")]
        [RegularExpression(@"[a-zA-Z]+[a-zA-Z0-9]*$", ErrorMessage = "")]
        public string Password { get; set; }

        [Display(Name = "")]
        [Required(ErrorMessage = "")]
        [System.Web.Mvc.Compare("Password", ErrorMessage = "")]  
        public string ConfirmPassword { get; set; }

        [Display(Name = "")]
        [Required(ErrorMessage = "")] 
        public string Address { get; set; }

        [Display(Name = "")]
        [Required(ErrorMessage = "")] 
        public string Email { get; set; }
    }
}