//Декларирайте променлива от тип char и присвоете като стойност
//символа, който има Unicode код 72 (използвайте калкулатора на
//Windows, за да намерите шестнайсетичното представяне на 72).
//the Unicode of tipe char and the solution of task 5 is  U + 0048
using System.Diagnostics.SymbolStore;

namespace _05_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char symbol = 'H';
            Console.WriteLine(symbol);
        }
    }
}