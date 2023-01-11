//Декларирайте две променливи от тип string със стойности "Hello" и 
//"World".
//Декларирайте променлива от тип object.
//Присвоете на тази 
//променлива стойността, която се получава от конкатенацията на двете 
//стрингови променливи (добавете интервал, ако е необходимо).
//Отпечатайте променливата от тип object.

namespace _07_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string greeting1 = "Hello";
            string greeting2 = "World";
            object mainGreeting = greeting1 + " " + greeting2;
            Console.WriteLine(mainGreeting);
        }
    }
}