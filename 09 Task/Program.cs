//Декларирайте две променливи от тип string и им присвоете стойност
//"The "use" of quotations causes difficulties." (без първите и 
//последни кавички).
//В едната променлива използвайте quoted string, а 
//в другата не го използвайте.

using System.Runtime.Intrinsics.X86;

namespace _09_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string solution1 = "The \"use\" of quotations causes difficulties.";
            string solution2 = @"The 'use' of quotations causes difficulties.";
            Console.WriteLine("this is escaped string: " + solution1);
            Console.WriteLine("this is verbatim string: " + solution2);
        }
    }
}