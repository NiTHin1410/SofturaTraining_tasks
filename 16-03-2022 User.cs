using System;
class userlogin
{
public void login(String n1,String n2)
{ 
  Console.WriteLine("EmailID");
  Console.WriteLine("Password");
}
public void login(String n3,int n4)
{
  Console.WriteLine("Membership");
  Console.WriteLine("Pin");
}
public void login(long n5,int n6)
{
  Console.WriteLine("Mobile number");
  Console.WriteLine("Pin");
}
public static void Main()
{
 userlogin obj=new userlogin();
 Console.WriteLine("EmailId & Passwaord:");
 obj.login(Console.ReadLine(),Console.ReadLine());
Console.WriteLine("Membership Id & Pin:");
 obj.login((Console.ReadLine()),Convert.ToInt32(Console.ReadLine()));
Console.WriteLine("Mobile number & Pin:");
 obj.login(Convert.ToInt64(Console.ReadLine()),Convert.ToInt32(Console.ReadLine()));
}

}