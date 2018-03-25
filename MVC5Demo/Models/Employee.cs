using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC5Demo.Models
{
    public class Employee
    {
        [Required(ErrorMessage ="Required")]
        public string  FirstName { get; set; }
        public string  LastName { get; set; }
        [Required(ErrorMessage ="Required")]
        [EmailAddress(ErrorMessage ="Enter Valid Email Addredd")]
        public string Email { get; set; }
        [Required(ErrorMessage ="Required")]
        public string Password { get; set; }
        [Required(ErrorMessage ="Required")]
        [Compare("Password",ErrorMessage ="Password doesn't match")]
        public string ConfirmPassword { get; set; }
        public string Age { get; set; }
    }
}