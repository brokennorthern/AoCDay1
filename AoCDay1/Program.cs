using Microsoft.VisualBasic;
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
        public static void Main()
        {
            var Input = File.ReadAllText(@"C:\Users\Mark\source\repos\AoCDay1\AoCDay1\input.txt");
            string[] Strings = Input.ToUpper().Split('\n');
            string[] Strings2 = Input.ToUpper().Split('\n');

            Console.WriteLine("The Output for Part 1 is: " + Part1(Strings));
            Console.WriteLine("The Output for Part 2 is: " + Part2(Strings2));


            static int Part1(string[] Input)
            {
                int Sum = 0;
                string output = "";
                for (int i = 0; i < Input.Length; i++)
                {
                    Input[i] = Regex.Replace(Input[i], @"[A-Za-z]+", "");
                    Input[i] = Input[i].Trim();
                    output = "";
                    output += Input[i][0];
                    output += Input[i][^1];
                    Sum += Int32.Parse(output);
                }
                return Sum;
            }

            static int Part2(string[] Input)
            {
                IDictionary<string, string> Map = new Dictionary<string, string>()
                {
                    {"ONE","O1E"},
                    {"TWO","T2O"},
                    {"THREE","TH3EE"},
                    {"FOUR","FO4R"},
                    {"FIVE","FI5E"},
                    {"SIX","S6X"},
                    {"SEVEN","SE7EN"},
                    {"EIGHT","EI8HT"},
                    {"NINE","NI9E"},
                };
                for (int i = 0; i < Input.Length; i++)
                {
                    var regex = new Regex(String.Join("|", Map.Keys));
                    Input[i] = regex.Replace(Input[i], m => Map[m.Value]);
                    Input[i] = regex.Replace(Input[i], m => Map[m.Value]);
                    //Dirty way of handling data such as "eighthree".
                    //I don't like it, but it works.
                }
                return Part1(Input);
            }
        }
    }
}