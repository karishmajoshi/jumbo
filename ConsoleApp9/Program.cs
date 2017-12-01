using System;
using System.IO;
using System.Linq;



namespace ConsoleApp9
{
    class Program
    {


        static void Main(string[] args)
        {
            foreach (string s in args)
            {
                string[] paths = { @".\ConsoleApp9.exe", args[0] };
                string fullPath = Path.Combine(paths);

                if (File.Exists(fullPath))
                {
                    if (Path.GetExtension(fullPath).Equals(".txt"))
                    {
                        using (StreamReader sr = new StreamReader(fullPath))
                        {
                            string line = sr.ReadToEnd();
                            Console.WriteLine(line);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid text file name");
                    }
                }

                else
                {
                    Console.WriteLine("File does not exist");
                }
                ConsoleKeyInfo keyInfo = Console.ReadKey();
                while (keyInfo.Key != ConsoleKey.Enter)
                    keyInfo = Console.ReadKey();
            }
        }
    }
}



