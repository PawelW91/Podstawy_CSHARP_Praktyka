namespace TABLICA___Tablica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] numbers = input.Split(' ');

            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                int X = int.Parse(numbers[i]);
                Console.Write(X + " ");
            }
            Console.WriteLine();
        }
    }
}
