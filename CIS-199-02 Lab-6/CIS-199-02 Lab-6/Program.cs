// Lab 6
// CIS-199-02
// Due: 3/21/2021
// By: S9223 (ID)

// A simple console application that utilizes for loops to show a series of patterns.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS_199_02_Lab_6
{
    using static System.Console;
    class Program
    {
        static void Main(string[] args)
        {
            // Highest possible rows and characters.
            const int Max = 10;
            // Lowest possible rows and characters.
            const int Least = 1;


            // code with for loops for the first pattern.
            WriteLine("Pattern A");
            for (int row = Least;  row <= Max; row++)
            {
                for (int star = Least; star <= row; star++)
                    Write("*");
                WriteLine();
            }

            // code with for loops for the second pattern.
            WriteLine("Pattern B");
            for (int row = Max; row >= Least; row--)
            {
                for (int star = Least; star <= row; star++)
                    Write("*");
                WriteLine();
            }

            // code with nested for loops for the third pattern.
            WriteLine("Pattern C");
            for (int row = Max; row >= Least; row--)
            {
                for (int space = Least; space <= Max - row; space++)
                    Write(" ");
                for (int star = Least; star <= row; star++)
                    Write("*");
                WriteLine();
            }

            // code with nested for loops for the fourth pattern. 
            WriteLine("Pattern D");
            for (int row = Least; row <= Max; row++)
            {
                for (int space = Least; space <= Max - row; space++)
                    Write(" ");
                for (int star = Least; star <= row; star++)
                    Write("*");
                WriteLine();
            }
        }
    }
}
