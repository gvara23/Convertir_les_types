namespace Convertir_les_types
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first number : ");
            string inputFirst = Console.ReadLine();

            Console.Write("Enter the second number : ");
            string inputSecond = Console.ReadLine();

            Console.Write("Enter a message of succes : ");
            string successMessage = Console.ReadLine();

            int numberOne = Convert.ToInt32(inputFirst);
            int numberTwo = Convert.ToInt32(inputSecond);
            int result = numberOne + numberTwo;

            Console.WriteLine($"{numberOne} + {numberTwo} = {result}");
            Console.WriteLine(successMessage);
        }
    }
}
