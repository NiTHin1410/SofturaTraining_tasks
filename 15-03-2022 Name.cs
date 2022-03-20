using System;
class name{
public static void Main()
{
   string n;
   int age;
   Console.WriteLine("Enter the name:");
   n=Console.ReadLine();
   Console.WriteLine("Given name is:  "+n);
   Console.WriteLine("Enter the age:");
   age=Convert.ToInt32(Console.ReadLine());
   for(int i=0;i<=age;i++){
   Console.WriteLine(n);
  }
}
}
   