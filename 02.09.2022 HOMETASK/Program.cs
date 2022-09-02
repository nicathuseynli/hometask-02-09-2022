using System;
using System.Collections.Generic;
using System.IO;

//namespace _02._09._2022_HOMETASK
//{
//    #region Task 1:
//    internal class Program
//    {
//        private static void Main(string[] args)
//        {
//            string fileName = @"mytest.txt";
//            string[] ArrLines;
//            int n, i;
//            Console.WriteLine("Create and read the last line of a file :");

//            if (File.Exists(fileName))
//            {
//                File.Delete(fileName);
//                Console.WriteLine("Input number of lines to write in the file :");
//                n = Convert.ToInt32(Console.ReadLine());
//                ArrLines = new string[n];
//                Console.WriteLine("Input{0} string below :\n", n);
//                for (i = 0; i < n; i++)
//                {
//                    Console.Write("Input line {0}: ", i + 1);
//                    ArrLines[i] = Console.ReadLine();
//                }
//                System.IO.File.WriteAllLines(fileName, ArrLines);
//                Console.WriteLine("\n The content of the last line of the file {0}  is \n", fileName);
//                if (File.Exists(fileName))
//                {
//                    string[] lines = File.ReadAllLines(fileName);
//                    Console.WriteLine();
//                }
//            }

//        }
//    }
//    #endregion
//}
//#region Task 2:
//class Program
//{
//    private static object Homework02;

//    public static object Usersuser { get; private set; }

//    static void Main(string[] args)
//    {
//        DirectoryInfo d = new DirectoryInfo(@"C:\Users\user");
//        FileInfo[] f = d.GetFiles("*", SearchOption.AllDirectories);
//        Console.WriteLine(f.Length.ToString());
//    }
//}
//#endregion
//#region Task 3:
//public class Part : IEquatable<Part>
//{
//    public string PartName { get; set; }
//    public int PartId { get; set; }
//    public override string ToString()
//    {
//        return "ID: " + PartId + "   Name: " + PartName;
//    }
//    public override bool Equals(object obj)
//    {
//        if (obj == null) return false;
//        Part objAsPart = obj as Part;
//        if (objAsPart == null) return false;
//        else return Equals(objAsPart);
//    }
//    public override int GetHashCode()
//    {
//        return base.GetHashCode();
//    }
//    public bool Equals(Part other)
//    {
//        if (other == null) return false;
//        return (this.PartId.Equals(other.PartId));
//    }
//    // Should also override == and != operators.
//}
//public class Example
//{

//    public static void Main()
//    {
//        List<Part> parts = new List<Part>();

//        Console.WriteLine("\nCapacity: {0}", parts.Capacity);

//        parts.Add(new Part() { PartName = "crank arm", PartId = 1234 });
//        parts.Add(new Part() { PartName = "chain ring", PartId = 1334 });
//        parts.Add(new Part() { PartName = "seat", PartId = 1434 });
//        parts.Add(new Part() { PartName = "cassette", PartId = 1534 });
//        parts.Add(new Part() { PartName = "shift lever", PartId = 1634 }); ;

//        Console.WriteLine();
//        foreach (Part aPart in parts)
//        {
//            Console.WriteLine(aPart);
//        }

//        Console.WriteLine("\nCapacity: {0}", parts.Capacity);
//        Console.WriteLine("Count: {0}", parts.Count);

//        parts.TrimExcess();
//        Console.WriteLine("\nTrimExcess()");
//        Console.WriteLine("Capacity: {0}", parts.Capacity);
//        Console.WriteLine("Count: {0}", parts.Count);

//        parts.Clear();
//        Console.WriteLine("\nClear()");
//        Console.WriteLine("Capacity: {0}", parts.Capacity);
//        Console.WriteLine("Count: {0}", parts.Count);
//    }
//    /*
//     This code example produces the following output.
//            Capacity: 0

//            ID: 1234   Name: crank arm
//            ID: 1334   Name: chain ring
//            ID: 1434   Name: seat
//            ID: 1534   Name: cassette
//            ID: 1634   Name: shift lever

//            Capacity: 8
//            Count: 5

//            TrimExcess()
//            Capacity: 5
//            Count: 5

//            Clear()
//            Capacity: 5
//            Count: 0
//     */
//}
//#region Task 5:
//public class Program
//{
//    public static void Main()
//    {
//        Dictionary<string, bool> characters = new Dictionary<string, bool>()
//{
//{ "Luke", true },
//{ "Han", false },
//{ "Chewbacca", false }
//};
//        static List<string> ProcessToKill(List<string> process)
//        {
//            List<string> processToKill = new List<string>(3);
//            Console.WriteLine(String.Format("Capacity {0}", processToKill.Capacity));

//            Console.WriteLine(String.Format("Count {0}", processToKill.Count));

//            foreach (var p in process)
//            {
//                if (!p.Equals("Explorer.exe")) { processToKill.Add(p); }
//            }

//            foreach (var p in processToKill)
//            {
//                Console.WriteLine(p);
//            }
//            return processToKill;
//        }
//    }


//#endregion