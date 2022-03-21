using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;

namespace Task_10
{
    class Desserts
    {
        public static void Main()
        {
            Queue q = new Queue();
            q.Enqueue("Ice cream");
            q.Enqueue("Falooda");
            q.Enqueue("Lassi");
            q.Enqueue("Gulab jamuns");
            FileStream fs = new FileStream("D:\\OFFICE\\21-03-2022_DESSERT.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            BinaryWriter br = new BinaryWriter(fs);
            foreach (string cal in q)
            {
                br.Write("\n"+cal);
            }
            br.Flush();
            fs.Close();
            FileInfo fs1 = new FileInfo("D:\\OFFICE\\21-03-2022_DESSERT.txt");
            Console.WriteLine(fs1.Length);
            Console.WriteLine(fs1.CreationTime);
            Console.ReadLine();
        }
    }
}
