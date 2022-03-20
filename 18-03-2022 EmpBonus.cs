using System;
class Salesmarket
{
double bs;
public void SM(double sms)
{
    bs = sms*0.2;
    Console.WriteLine("Bonus salary for Sales & MArketing : "+ (sms+bs));
}
}
class Production:Salesmarket
{
double bs;
public void Pro(double s)
{
     bs = s*0.1;
    Console.WriteLine("Bonus Salary For Production : "+(bs+s));
}
}
class Emp
{
  public static void Main()
{
 
  Console.WriteLine("Enter the name: ");
  string Name=Console.ReadLine();
   Console.WriteLine("Enter the Empid: ");
  double EmpId = Convert.ToInt32(Console.ReadLine()); 
  Console.WriteLine("Enter the Gender: ");
   string Gender=Console.ReadLine();
  Console.WriteLine("Enter the Years of exp:");
  int YOE=Convert.ToInt32(Console.ReadLine());
   Console.WriteLine("Enter the Salary: ");
  double Salary=Convert.ToInt32(Console.ReadLine());


  Production obj=new Production();
  obj.Pro(Salary);
  obj.SM(Salary);
}
}