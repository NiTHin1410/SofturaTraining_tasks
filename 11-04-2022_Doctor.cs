using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LynQ
{
    class Day_25__Doctor
    {
        public static void Main()
        {
            IList<Doctor> DocData = new List<Doctor>()
            {
            new Doctor() { DoctorId = 1, DoctorName = "Kavi", Experience = 10 , SpID =1},
            new Doctor() { DoctorId = 2, DoctorName = "Rukesh", Experience = 5,SpID =3 },
            new Doctor() { DoctorId = 3, DoctorName = "Nithin", Experience = 6,SpID =2 },
            new Doctor() { DoctorId = 4, DoctorName = "Bharath", Experience = 10 ,SpID =2},
            new Doctor() { DoctorId = 5, DoctorName = "Deepak", Experience = 12 ,SpID =3},
            new Doctor() { DoctorId = 6, DoctorName = "KaviRaj", Experience = 15,SpID =1 },
            new Doctor() { DoctorId = 7, DoctorName = "Dhinesh", Experience = 12 ,SpID =4},
            new Doctor() { DoctorId = 8, DoctorName = "mohan", Experience = 13,SpID =1 },
            };
            IList<Specialize> SpeData = new List<Specialize>()
            {
                new Specialize() {SpID=1,specialized="Neurologist"},
                new Specialize() {SpID=2,specialized="Surgen"},
                new Specialize() {SpID=3,specialized="Cardiologist"},
                new Specialize() {SpID=4,specialized="Family Medicine"},
            };
            var Doc = from doct in SpeData
                      join spd in DocData
                      on doct.SpID equals spd.SpID
                      into DocList
                      select new
                      {
                          Doctors = DocList,
                          specialized = doct.specialized
                      };
            foreach (var item in Doc)
            {
                Console.WriteLine("Specialized in => {0}",item.specialized);
                    foreach (var i in item.Doctors)
                    Console.WriteLine("Doctor-ID: {0}  DoctorName: {1}", i.DoctorId ,i.DoctorName);
            }
            //foreach(var i in Doc)
        }
    }
    public class Doctor
    {
        public int DoctorId { set; get; }
        public string DoctorName { set; get; }
        public int Experience { get; set; }
        public int SpID { get; set; }
    }
    public class Specialize
    {
       public int SpID { get; set; }
        public string specialized { get; set; }
    }
}
