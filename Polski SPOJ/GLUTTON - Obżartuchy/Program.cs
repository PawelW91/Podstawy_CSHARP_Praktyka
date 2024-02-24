namespace GLUTTON___Obżartuchy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ile_testow = int.Parse(Console.ReadLine());

            while (ile_testow-- > 0)
            {
                string[] input = Console.ReadLine().Split();
                int ilu_obzartuchow = int.Parse(input[0]);
                int ile_ciastek_w_pudelku = int.Parse(input[1]);

                int ile_pudelek = 0;
                int ile_ciastek_zjedza_wszystkie_obzartuchy_w_dobe = 0;

                for (int k = 0; k < ilu_obzartuchow; k++)
                {
                    int ile_zajmuje_zjedzenie_ciastka = int.Parse(Console.ReadLine());

                    if (ile_zajmuje_zjedzenie_ciastka != 0)
                    {
                        ile_ciastek_zjedza_wszystkie_obzartuchy_w_dobe += (24 * 60 * 60) / ile_zajmuje_zjedzenie_ciastka;
                    }
                }

                ile_pudelek = (ile_ciastek_zjedza_wszystkie_obzartuchy_w_dobe + ile_ciastek_w_pudelku - 1) / ile_ciastek_w_pudelku;
                Console.WriteLine(ile_pudelek);
            }
        }
    }
}
