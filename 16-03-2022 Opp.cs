using System;
class opp1
{
 public void AddNo(int n1,int n2)
  {
    int add = n1+n2;
    Console.WriteLine(add);
    int sub = n1-n2;
    Console.WriteLine(sub);
  }
class opp2:opp1
{
 public void AddNo2(int n1,int n2)
  {
    int mul = n1*n2;
    Console.WriteLine(mul);
    int div = n1/n2;
    Console.WriteLine(div);
  }
public static void Main()
{
 opp2 obj = new opp2();
 obj.AddNo(10,5);
 obj.AddNo2(10,5);

}
}
}  