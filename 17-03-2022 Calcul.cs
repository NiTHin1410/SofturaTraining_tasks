using System;
abstract class Calcul
{
public abstract void Add();
public abstract void Sub();
public abstract void Mul();
public abstract void Div();
}
class Addi:Calcul
{
public override void Add()
{
int n1=7,n2=4,n3;
n3=n1+n2;
Console.WriteLine("Add = "+n3);
}
     public override void Sub()
         {
            int n1=7,n2=4,n3;
n3=n1-n2;
Console.WriteLine("SuB = "+n3);
           }
      public override void Mul() 
       {  
          int n1=7,n2=4,n3;
n3=n1*n2;
Console.WriteLine("Mul = "+n3);
}
 public override void Div() 
       {  
          int n1=8,n2=4,n3;
          n3=n1/n2;
Console.WriteLine("Div = "+n3); 
        }
}
class calculator
{
public static void Main()
{
 Addi obj = new Addi();
obj.Add();
obj.Sub();
obj.Mul();
obj.Div();
}
}