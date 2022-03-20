using System;
class table
{
 public static void Main()
{
 Console.WriteLine("Which table do you want:");
 int n=Convert.ToInt32(Console.ReadLine());
 for(int i=1;i<=20;i++){
  Console.WriteLine(n+" * "+i +" = " + n*i);
}
}
}