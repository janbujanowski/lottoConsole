using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CoreConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            var filePath = @"C:\Users\janbu\Desktop\Repos\CoreConsole\lotto.txt";
            var lines = File.ReadAllLines(filePath);
            int[] accumulated = new int[50];
            for (int i = 0; i < accumulated.Length; i++)
            {
                accumulated[i] = 0;
            }
            accumulated[0] = 99999;
            foreach (var line in lines)
            {
                var numbers = line.Split(' ')[2].Split(',');
                foreach (var numba in numbers)
                {
                    var id = Int32.Parse(numba);
                    accumulated[id]++;
                }
            }
            var accList = accumulated.Min(); 
            var min = accumulated.Min();

            for (int i = 0; i < accumulated.Length; i++)
            {
                System.Console.WriteLine($"Liczba {i} wystąpień : {(accumulated[i] - min)}"); ;
            }

        }
    }
}
