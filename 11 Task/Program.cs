//Напишете програма, която принтира на конзолата равнобедрен
//триъгълник,
//като страните му са очертани от символа "©".
//solution https://www.youtube.com/watch?v=rTqBnJ8HrSc 
namespace _11_Task

{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("\x00A9");

            Console.WriteLine("             ©               ");
            Console.WriteLine("            © ©              ");
            Console.WriteLine("           ©   ©             ");
            Console.WriteLine("          ©     ©            ");
            Console.WriteLine("         ©   ©   ©           ");
        }
    }
    
    
}