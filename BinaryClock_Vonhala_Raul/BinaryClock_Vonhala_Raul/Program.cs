using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryClock_Vonhala_Raul
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti ora sub forma ora:minut:secunda ");
            string input=Console.ReadLine();
            if(verif(input))
            {
                string[] timp = input.Split(':');
                int ora = int.Parse(timp[0]);
                int min = int.Parse(timp[1]);
                int sec = int.Parse(timp[2]);
                string orabinara = Convert.ToString(ora, 2).PadLeft(5, '0');
                string minbinar = Convert.ToString(min, 2).PadLeft(6, '0');
                string secbinara=Convert.ToString(sec,2).PadLeft(6,'0');
                Console.WriteLine($"Ceasul binar este: {orabinara}:{minbinar}:{secbinara}");
                Console.ReadLine();
            }
        }
        static bool verif(string timp)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(timp, @"^(0[0-9]|1[0-9]|2[0-3]):[0-5][0-9]:[0-5][0-9]$");
        }

    }
}
