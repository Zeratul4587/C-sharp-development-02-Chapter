//Декларирайте две променливи от тип int.
//Задайте им стойности съответно 5 и 10.
//Разменете стойностите им
//и ги отпечатайте.
namespace _13_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = 5;
            int secondNumber = 10;
            //swoapimg first number and second number above
            int firstTempNumber = secondNumber;
            int secondTempNumber = firstNumber;

            Console.WriteLine(firstTempNumber + " " + secondTempNumber);
        }
    }
}