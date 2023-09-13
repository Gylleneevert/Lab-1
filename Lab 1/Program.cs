using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading.Channels;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Lab_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            Console.WriteLine("Skriv in slumpade siffror och tryck enter");
            string input = Console.ReadLine();

            List<string> strings = new List<string>();

            for (int myNumbers = 0; myNumbers < input.Length - 1; myNumbers++)
            {
                for (int j = myNumbers + 1; j < input.Length; j++)
                {
                    if (char.IsLetter(input[j]))
                    {
                        break;
                    }

                    if (input[myNumbers] == input[j])
                    {

                        strings.Add(input[myNumbers..(j + 1)]);

                        break;
                    }
                }
            }
            strings.ForEach(s =>
            {
                Console.Write(input[0..input.IndexOf(s, 0)]);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(s);
                Console.ResetColor();
                Console.WriteLine(input[(input.IndexOf(s, 0) + s.Length)..^0]);
                Console.ResetColor();
            });
            long total = strings.Select(s => long.Parse(s)).Sum();
            Console.WriteLine($"The total sum is; {total}!");













































        }





























    }
}

