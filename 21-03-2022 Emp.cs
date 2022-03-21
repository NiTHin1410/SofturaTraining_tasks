using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;

namespace Task_10
{
    class _21_03_2022_Emp
    {
        public static void Main()
        {
            Dictionary<int, string> dic = new Dictionary<int, string>();
            dic.Add(1, "Ni1234");
            dic.Add(2, "Nithin");
            dic.Add(3, "Male");
            dic.Add(4, "21");
            FileStream fs = new FileStream("D:\\OFFICE\\21-03-2022_EMP1.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            BinaryWriter bw = new BinaryWriter(fs);
            foreach (var v in dic)
                Console.WriteLine( v.Key +" ."+ v.Value);
            foreach (var v in dic)
            {
                bw.Write(v.Key + v.Value);
                bw.Write("\n");
            }
            bw.Flush();
            fs.Close();
            Console.ReadLine();
        }
    }
}

