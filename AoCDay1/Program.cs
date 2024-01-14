using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TreeBucket
{
    class Program
    {
        public static void Main(string[] args)
        {
            var input = File.ReadAllText(@"C:\Users\Mark\source\repos\AoCDay1\AoCDay1\input.txt");
            string[] strings = Regex.Replace(input, @"[A-Za-z]+", "").Split('\n');
            int sum = 0;

            for (int i = 0; i < strings.Length; i++)
            {
                strings[i] = strings[i].Trim();
                string output = "";
                output += strings[i][0];
                output += strings[i][^1];
                sum += Int32.Parse(output);
            }

            Console.WriteLine(sum);
        }
    }
}