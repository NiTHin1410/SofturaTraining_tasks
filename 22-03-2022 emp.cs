using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Soap;

namespace _22_03_2022_Day11
{
    [Serializable]//attribute
    class Student
    {
        public string name = "Nithin";
        public string empId = "Ni1234";
        public string gender = "Male";
        public int age = 21;

    }
    class Serial
    {
        public void SererialFile()
        {
            Student st = new Student();
            FileStream fs = new FileStream("Emp.txt", FileMode.OpenOrCreate, FileAccess.Write);
            SoapFormatter f = new SoapFormatter();
            f.Serialize(fs, st);
            fs.Close();
        }
       
       public void DeserialData()
        {
            FileStream fs = new FileStream("Emp.txt", FileMode.Open, FileAccess.ReadWrite);
            SoapFormatter f = new SoapFormatter();
            Student str = (Student)f.Deserialize(fs);
            Console.WriteLine("Name : "+str.name);
            Console.WriteLine("EmpId : "+str.empId);
            Console.WriteLine("Gender : "+str.gender);
            Console.WriteLine("Age : "+str.age);

        }

        public static void Main()
        {
            Serial obj = new Serial();
            obj.SererialFile();
            obj.DeserialData();
            Console.ReadLine();
        }
    }
}
