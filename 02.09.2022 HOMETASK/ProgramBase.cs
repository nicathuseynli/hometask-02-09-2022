using System;
using System.IO;

namespace _02._09._2022_HOMETASK
{
    internal class ProgramBase
    {
        static void Main(string[] args)
        {
            string fileName = @"mytest.txt";
            string[] ArrLines;
            int n, i;
            Console.WriteLine("Create and read the last line of a file :");

            if (File.Exists(fileName))
            {
                File.Delete(fileName);
                Console.WriteLine("Input number of lines to write in the file :");
                n = Convert.ToInt32(Console.ReadLine());
                ArrLines = new string[n];
                Console.WriteLine("Input{0} string below :\n", n);
                for (i = 0; i < n; i++)
                {
                    Console.Write("Input line {0}: ", i + 1);
                    ArrLines[i] = Console.ReadLine();
                }
                System.IO.File.WriteAllLines(fileName, ArrLines);
                Console.WriteLine("\n The content of the last line of the file {0}  is \n", fileName);
                if (File.Exists(fileName))
                {
                    string[] lines = File.ReadAllLines(fileName);
                    Console.WriteLine();
                }
            }

        }
    }
}