using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConversiiASC_Vonhala_Raul
{
    internal class Program
    {
        
        
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti numarul: ");
            string numar = Console.ReadLine();
            Console.WriteLine("Introduceti baza1: ");
            int b1=int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti baza2: ");
            int b2=int.Parse(Console.ReadLine());
            string rez = Conversie(numar, b1, b2);
            Console.WriteLine($"Rezultatul conversiei este {rez}");
            Console.ReadKey();
        }
        static string Conversie(string input, int bazasursa, int bazatarget)
        {
            int decimaln = ConversieInDecimal(input, bazasursa);
            string rez = ConversieDinDecimal(decimaln, bazatarget);
            return rez;
        }

        static int ConversieInDecimal(string input,int bazasursa)
        {
            int decimaln = 0;
            int lungime = input.Length;
            for (int i = 0; i < lungime; i++)
            {
                char cif = input[i];
                int valcif = (cif >= 'A') ? (cif - 'A' + 10) : (cif - '0');
                decimaln += valcif + (int)Math.Pow(bazasursa, lungime - 1 - i);
            }
            return decimaln;
        }
        static string ConversieDinDecimal(int decimaln,int bazatarget)
        {
            string rez = " ";
            while (decimaln > 0)
            {
                int aux = decimaln % bazatarget;
                char cif = (aux < 10) ? (char)(aux + '0') : (char)(aux - 10 + 'A');
                rez = cif + rez;
                decimaln = decimaln / bazatarget;
            }
            return (rez == " ") ? "0" : rez;

        }
        
    }
}
