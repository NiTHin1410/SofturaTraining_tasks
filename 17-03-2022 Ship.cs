using System;
interface Package
{
void Silver();
void Gold();
void Platinum();
}
class MemberShip:Package
{
public void Silver()
{
  Console.WriteLine("Silver:");
  Console.WriteLine("3 Days accomodation at Resort");
}
public void Gold()
{
  Console.WriteLine("Gold:");
  Console.WriteLine("5 days accomodation at Resort & 2 dinners on the house");
}
public void Platinum()
{
Console.WriteLine("Platinum:");
  Console.WriteLine("7 days accomodation at Resort & 5 Dinners on the house");
}

public static void Main()
{
MemberShip obj= new MemberShip();
obj.Silver();
obj.Gold();
obj.Platinum();
}
}
