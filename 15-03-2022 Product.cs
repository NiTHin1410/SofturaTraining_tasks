using System;
class arr3{
  public static void Main(){
     string[][] arr=new string[3][];
     arr[0]=new string[]{"Milk","Good day","Oreo","mari gold"};
     arr[1]=new string[]{"dairy milk","Munch","Fuse","Kit kat","Mango bit"};
     arr[2]=new string[]{"mazza","slize","thumps up","coco","sprite","7-up"};  
for(int i=0;i<arr.Length;i++) 
  {
   for(int j=0;j<arr[i].Length;j++)
   Console.Write(arr[i][j]+" \t");
   Console.WriteLine();
   }
}
}