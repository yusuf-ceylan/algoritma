using System;
using System.Collections.Generic;
using System.Net;
using System.Security.Cryptography.X509Certificates;

namespace algoritma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("String değer, sayı giriniz (Örnek giriş formatı: Algoritma,3 Algoritma,5 Algoritma,22 Algoritma,0): ");
            string inputValue = Console.ReadLine();

            string[] stringArray = inputValue.Split(',', ' ');
            string output = "";

            for (int i = 0; i < stringArray.Length; i += 2)
            {
                output += RemoveChartAtIndex(stringArray[i], Convert.ToInt32(stringArray[i + 1])) + " ";
            }

            Console.WriteLine(output);

        }

        public static string RemoveChartAtIndex(string str, int index)
        {
            return str.Remove(index, 1);
        }
    }
}
