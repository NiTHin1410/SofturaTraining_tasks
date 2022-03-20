using System;
class covid
{
 public static void Main()
  {
   string str;
   Console.WriteLine("Do you have travel history");
   str=Console.ReadLine();
   if(str=="yes")
   {
       Console.WriteLine("Do you have temperature");
       str=Console.ReadLine();
         if(str=="yes")
           {
              Console.WriteLine("Do you have Cough");
              str=Console.ReadLine();
                 if(str=="yes")
                 {
                    Console.WriteLine("Swab test");
                    str=Console.ReadLine();
                  }
                else
                {
                  Console.WriteLine("Quarantine Fever medicine");
                }
            }
           else
           {
             Console.WriteLine("Home Quarantine for 28 days");     
          }   
       }
        else
          { 
          Console.WriteLine("Safe Not covid-19");
          }
      } 
   } 