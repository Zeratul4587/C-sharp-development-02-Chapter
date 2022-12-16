//Инициализирайте променлива от тип int със стойност 256 в шестнадесетичен формат (256 е 10

namespace _04_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //initialise decimal number of type int with name decNum
            int decNum = 0;

            //initialise decimal number of type int with name rem for Remeinder
            int rem = 0;

            //initialise character based literal of type string with name hexNum for hexadecimal number
            string hexNum = "";

            //ask user to enter a decimal number
            Console.Write("Enter a Decimal Number: ");
            decNum = int.Parse(Console.ReadLine());

            while (decNum != 0)
            {
                rem = decNum % 16;
                if (rem < 10)
                    rem = rem + 48;
                else
                    rem = rem + 55;

                hexNum = hexNum + Convert.ToChar(rem);
                decNum = decNum / 16;
            }
            
            //initialise decimal number of type int for the variable name i short for index
            int i = 0;

            Console.Write("Hexa-decimal number: ");
            for (i = hexNum.Length - 1; i >= 0; i--)
                Console.Write(hexNum[i]);

        }
    }
}