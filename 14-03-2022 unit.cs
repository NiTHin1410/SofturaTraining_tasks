using System;
class interview{
public static void Main()
{
 int unit,u,total;
 Console.WriteLine("Enter the unit:");
 unit=Convert.ToInt32(Console.ReadLine());
if(unit<=200){
     u=(unit*2);
     Console.WriteLine(u);
   }
   else if(unit>200 && unit<350)
     {
      u=(unit-200);
      total=(200*2)+(u*3);
      Console.WriteLine(total);  
      } 
      else if(unit>350 && unit<500)
     {
      u=(unit-350);
      total=(200*2)+((350-200)*3)+(u*5);
      Console.WriteLine(total);  
      } 
	else if(unit>500)
     {
      u=(unit-500);
      total=(200*2)+((350-200)*3)+((500-350)*5)+(u*7);
      Console.WriteLine(total);  
      } 
}
}