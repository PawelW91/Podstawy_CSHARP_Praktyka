namespace FR_01_02___Dodawanie_ułamków
{
    class Program
    {
        static ulong NWD(ulong a, ulong b)
        {
            ulong temp;
            while (b != 0)
            {
                temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
        static ulong NWW(ulong a, ulong b)
        {
            return (a * b) / NWD(a, b);
        }
        static void Main()
        {
            ulong l1, m1, l2, m2;
            ulong wm, l3, dz;
            char p;

            string input = Console.ReadLine();
            string[] parts = input.Split('/', ' ');
            l1 = ulong.Parse(parts[0]);
            m1 = ulong.Parse(parts[1]);
            l2 = ulong.Parse(parts[2]);
            m2 = ulong.Parse(parts[3]);

            wm = NWW(m1, m2);
            l3 = l1 * (wm / m1) + l2 * (wm / m2);
            dz = NWD(l3, wm);

            Console.WriteLine($"{l1}/{m1} + {l2}/{m2} = {l3 / dz}/{wm / dz}");
        }
    }
}
