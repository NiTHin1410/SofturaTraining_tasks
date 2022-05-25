using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Clinic_Main.Models
{
    public class Login
    {

        //[RegularExpression("^[A-Za-z0-9]*$", ErrorMessage = "Special charecters are NotAllowed")]
        //public string UserName { get; set; }
        //[RegularExpression("^[A-Za-z0-9]*$", ErrorMessage = "Special charecters are NotAllowed")]
        //public string Password { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Please Provide Username", AllowEmptyStrings = false)]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Please provide password", AllowEmptyStrings = false)]
        [DataType(System.ComponentModel.DataAnnotations.DataType.Password)]
        public string Password { get; set; }
    }
}
