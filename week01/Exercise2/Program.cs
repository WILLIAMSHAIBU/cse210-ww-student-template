# Author : William Shaibu 
# Week number one, Assignment number two

using System;

class Program
{
    static void Main(string[] args)
    {
         Console.WriteLine("Please Enter your grade: ");
       string grade = Console.ReadLine();

       int Grade = int.Parse(grade);

       if((Grade>=90)&&(Grade<=100))
       {
        Console.WriteLine("A");
       }
       else if((Grade>=80)&&(Grade<90))
       {
        Console.WriteLine("B");
       }
       else if((Grade >= 70)&&(Grade < 80))
       {
        Console.WriteLine("C");
       }
       else if((Grade>= 60)&&(Grade < 70))
       {
        Console.WriteLine("D");
       }
       else if(Grade< 60)
       {
        Console.WriteLine("F");
       }
       else{
        Console.WriteLine("Invalid Grades");
       }
    }
}
