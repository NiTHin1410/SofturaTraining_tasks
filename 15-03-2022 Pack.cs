using System;
class package
{
 public static void Main()
   {
     Console.WriteLine("Enter the package:");
     string pack=Console.ReadLine();
     switch(pack)
{
 case "package A":
        Console.WriteLine("1.South Special"+"\n "+"2.Children's club"+ "\n "+" 3.Movies");
        Console.WriteLine("Rate:250");
        break;
case "package B":
        
        Console.WriteLine("1.News"+"\n "+"2.Sports"+"\n "+"3.Movies"+"\n "+"4.Regional");
        Console.WriteLine("Rate:450");
        break;
case "package C":
        
        Console.WriteLine("1.Discovery "+ "\n "+"2.History"+ "\n "+"3.National");
        Console.WriteLine("Rate:350");
        break;
}
}
}