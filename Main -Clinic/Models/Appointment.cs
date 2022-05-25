using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Clinic_Main.Models
{
    public class Appointment
    {
        public int AppointID { get; set; }
        public int PatientID { get; set; }
        public string PatientName { get; set; }
        public string Specialization { get; set; }
        public string DoctorList { get; set; }
        [Required(ErrorMessage = "Please Enter Appointment Time")]
        public DateTime VisitDate { get; set; }
        [Required(ErrorMessage = "Please Enter Appointment Time")]
        public string AppointmenTime { get; set; }
    }
}
