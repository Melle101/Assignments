using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    public class KaggVariabler
    {
        public static void Name()
        {
            Console.WriteLine("Melker");
        }
        public static void Uppgift1()
        {
            Console.WriteLine("Hej! \nMelker Stålnakcke");
        }
        public static void Uppgift2()
        {
            Console.Write("Hej, ");
            Console.Write("jag heter ");
            Console.Write("Melker!");
        }
        public static void Uppgift3()
        {
            Console.WriteLine("\nHej,");
            Console.WriteLine("jag heter");
            Console.WriteLine("Melker!");
        }
        public static void Uppgift4()
        {
            Console.WriteLine("Hej, \njag heter \nMelker!");
        }
        public static void Uppgift5()
        {
            Console.WriteLine("+\\\"\\\"\\\"\\\"+ \n[| o o |] \n |  ^  | \n | '-' | \n +-----+");
        }
        public static void Uppgift6()
        {
            int a = 10;
            int b = 3;
            int c = a * b;
            Console.WriteLine(c);
        }
        public static void Uppgift7()
        {
            string Name = "Melker";
            string City = "Alsterbro";
            Console.WriteLine($"Hej jag heter {Name} och jag bor i {City}!");
        }
        public static void Uppgift8()
        {
            Console.Write("Please type in amount of seconds: ");
            double SecondsInput = Double.Parse(Console.ReadLine());
            double Hours = SecondsInput / 3600;
            double Minutes = ((Hours - Math.Floor(Hours)) * 60);
            double Seconds = ((Minutes - Math.Floor(Minutes)) * 60);
            Console.WriteLine($"{SecondsInput} Seconds is {Math.Floor(Hours)} Hours, {Math.Floor(Minutes)} Minutes and {Math.Round(Seconds)} Seconds!");
        }


    }
}
