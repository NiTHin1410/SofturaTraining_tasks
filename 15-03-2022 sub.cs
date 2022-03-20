using System;
class subject
{
public static void Main()
{
int [] arr = new int[5];
Console.WriteLine("Enter your Marks : ");
for(int i=0;i<5;i++)
{
arr[i]=Convert.ToInt32(Console.ReadLine());
}
int sum=0;
for(int i=0;i<5;i++)
{
sum = arr[i]+sum;
}
int per;
per = sum/5;
Console.WriteLine("Total:"+sum);
Console.WriteLine("Percentage: "+per);
}
}