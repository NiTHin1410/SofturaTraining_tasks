using System;
class Com
{
int a1;
public Com()
{
Console.WriteLine("My name is :  Nithin");
}
public Com(int a1)
{
 this.a1=a1;
}
public static void Main()
{
 Com obj=new Com();
 Com obj1=new Com(21);
 Console.WriteLine("My age is : "+obj1.a1);
}
}