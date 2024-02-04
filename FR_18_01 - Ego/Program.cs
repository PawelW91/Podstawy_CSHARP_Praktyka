namespace FR_18_01___Ego
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ileTestow, dzien;
            ileTestow = int.Parse(Console.ReadLine());

            string[] kto =
                {
                        "DAWID",
                        "GRZESIEK",
                        "MACIEK",
                        "MARCIN",
                        "MARIUSZ",
                        "RAFAL"
                    };

            while (ileTestow-- > 0)
            {
                dzien = int.Parse(Console.ReadLine());

                switch ((dzien - 1) / 7)
                {
                    case 0:
                    case 6: Console.WriteLine(kto[0]);      break;
                    case 1:
                    case 7: Console.WriteLine(kto[1]);      break;
                    case 2:
                    case 8: Console.WriteLine(kto[2]);      break;
                    case 3:
                    case 9: Console.WriteLine(kto[3]);      break;
                    case 4:
                    case 10:Console.WriteLine(kto[4]);      break;
                    case 5: Console.WriteLine(kto[5]);      break;
                }
            }
        }
    }
}
