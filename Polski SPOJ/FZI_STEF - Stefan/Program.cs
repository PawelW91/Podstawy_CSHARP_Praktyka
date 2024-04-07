namespace FZI_STEF___Stefan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ile = int.Parse(Console.ReadLine());
            long curSum = 0, maxSum = 0;
            while (ile-- > 0)
            {
                int X = int.Parse(Console.ReadLine());
                curSum += X;
                if (curSum > maxSum) maxSum = curSum;
                if (curSum < 0) curSum = 0;
            }
            Console.WriteLine(maxSum);
        }
    }
}
