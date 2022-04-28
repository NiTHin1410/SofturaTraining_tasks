using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Simple_Activity_2.Models
{
    public class Customer
    {
        [Key]
        [Required]
        public int CustID { get; set; }
        public string CustName  { set; get; }
        public DateTime DOB { set; get; }
        public string EmailID { set; get; }
        public string ContactNo { set; get; }
        public string Location { set; get; }
    }
}
