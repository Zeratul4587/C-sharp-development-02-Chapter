//Декларирайте няколко променливи, като изберете за всяка една найподходящия от типовете sbyte, byte, short, ushort, int, uint, long и 
//ulong, за да им присвоите следните стойности: 52130, -115, 4825932, 
//97, -10000, 20000; 224; 970700000; 112; -44; -1000000; 1990;
//123456789123456789.

namespace _01_Task
{
    internal class Program
    {
        ushort a = 52130;// range 0 to 65 535
        sbyte b = -115;// range -128 to 127
        int c = 4825932;// range -2,147,483,648 to 2,147,483,647
        sbyte d = 97;
        short e = 10000; // range -32,768 to 32,767
        short f = 20000;
        byte g = 224; // rnage 0 to 255
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}