namespace FR_18_04___Opony
{
    using System;
    using System.Collections.Generic;
    class Program
    {
        static void Main()
        {
            HashSet<string> uniqueStrings = new HashSet<string>();
            string x;
            while ((x = Console.ReadLine()) != null)
            {
                if (uniqueStrings.Contains(x))
                {
                    uniqueStrings.Remove(x);
                }
                else
                {
                    uniqueStrings.Add(x);
                }
            }

            foreach (var str in uniqueStrings)
            {
                Console.WriteLine(str);
            }
        }
    }

}
