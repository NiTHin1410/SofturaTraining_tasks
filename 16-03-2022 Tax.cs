using System;
class VAT{
public void Tax1(double n1)
{
 double vat=n1*(1+0.2);
 Console.WriteLine(vat);
}
}
class GST:VAT
{
 public void Tax2(float n1, float n2)
{
   float gst =(n1*n2)/100;
   Console.WriteLine(gst);
}
public static void Main()
{
  GST obj= new GST();
  obj.Tax1(20);
  obj.Tax2(1000,20);
}
}
