using System;
using System.Collections.Generic;

internal static class ProgramHelpers
{
    public static void Main()
    {
        Dictionary<string, bool> characters = new Dictionary<string, bool>()
{
{ "Luke", true },
{ "Han", false },
{ "Chewbacca", false }
};
        static List<string> ProcessToKill(List<string> process)
        {
            List<string> processToKill = new List<string>(3);
            Console.WriteLine(String.Format("Capacity {0}", processToKill.Capacity));

            Console.WriteLine(String.Format("Count {0}", processToKill.Count));

            foreach (var p in process)
            {
                if (!p.Equals("Explorer.exe")) { processToKill.Add(p); }
            }

            foreach (var p in processToKill)
            {
                Console.WriteLine(p);
            }
            return processToKill;
        }
    }
}