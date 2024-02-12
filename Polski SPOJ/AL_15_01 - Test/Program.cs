namespace AL_15_01___Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string Darek, Jarek, Marek;
            int max_pkt = 0;
            Darek = Console.ReadLine();
            Jarek = Console.ReadLine();
            Marek = Console.ReadLine();
            for (int i = 0; i < Darek.Length; i++)
            {
                if (Darek[i] != Marek[i] && Marek[i] == Jarek[i])
                {
                    max_pkt += 2;
                }
                if (Darek[i] != Jarek[i] && Marek[i] != Jarek[i] && Darek[i] != Marek[i])
                {
                    max_pkt++;
                }
                if ((Darek[i] == Marek[i] && Darek[i] != Jarek[i]) || (Darek[i] == Jarek[i] && Darek[i] != Marek[i]))
                {
                    max_pkt++;
                }
            }
            Console.WriteLine(max_pkt);
        }
    }
}
