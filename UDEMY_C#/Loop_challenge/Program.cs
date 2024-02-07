namespace UDEMY_C__MASTERCLASS_LOOP_CHALLENGE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Program dla nauczyciela, ma obliczyc srednia z wynikow studentów (tylko liczby 0-20),
            //kazdy inny ciag znakow ma byc nieuwzgledniany - komunikat "Please enter a valid number: 1-20."
            //po wpisaniu "-1" ma podac wynik.
            long counter = 0, sum = 0;
            string test = "0";
            while (true)
            {
                test = Console.ReadLine();
                if (test == "-1") { break; }
                if (!long.TryParse(test, out long score) || score < 0 || score > 20)
                {
                    Console.WriteLine("Please enter a valid number: 1-20.");
                    continue;
                }
                sum += score;
                counter++;
                Console.WriteLine("Current sum is: " + sum);
                Console.WriteLine("Last input was: " + score);
                Console.WriteLine($"You entered {counter} valid numbers.");
            }
            Console.WriteLine("Average score is: " + (double)sum / counter);
        }
    }
}
