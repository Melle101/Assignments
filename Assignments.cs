using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

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
            double SecondsInput = Double.Parse(Console.ReadLine().Replace(',', '.'), CultureInfo.InvariantCulture); // Ser till att både ',' och '.' fungerar som decimaltecken. 
            double Hours = SecondsInput / 3600;
            double Minutes = ((Hours - Math.Floor(Hours)) * 60);
            double Seconds = ((Minutes - Math.Floor(Minutes)) * 60);
            Console.WriteLine($"{SecondsInput} Seconds is {Math.Floor(Hours)} Hours, {Math.Floor(Minutes)} Minutes and {Math.Round(Seconds, 2)} Seconds!");
        }

    }

    public class KaggInmatningUtskrift
    {
        public static void Uppgift1()
        {
            Console.Write("Hej, vad heter du?: ");
            string Name = Console.ReadLine();
            Console.WriteLine($"Hej {Name}!");
        }
        public static void Uppgift2()
        {
            Console.Write("Hej, vad är ditt förnamn?: ");
            string Firstname = Console.ReadLine();
            Console.Write("Och ditt efternamn?: ");
            string Lastname = Console.ReadLine();
            Console.WriteLine($"Hej {Firstname} {Lastname}!");
        }
        public static void Uppgift3()
        {
            Console.Write("Skriv det först talet: ");
            int Num1 = int.Parse(Console.ReadLine());
            Console.Write("Skriv det andra talet: ");
            int Num2 = int.Parse(Console.ReadLine());
            Console.WriteLine(Num1 + Num2);
        }
        public static void Uppgift4()
        {
            Console.Write("Skriv det första talet: ");
            double Num1 = double.Parse(Console.ReadLine());
            Console.Write("Skriv det andra talet: ");
            double Num2 = double.Parse(Console.ReadLine());
            Console.WriteLine($"Summan är {Num1 + Num2}.");
        }
        public static void Uppgift5()
        {
            Console.Write("Skriv det första talet: ");
            double Num1 = double.Parse(Console.ReadLine());
            Console.Write("Skriv det andra talet: ");
            double Num2 = double.Parse(Console.ReadLine());
            Console.WriteLine($"Produkten är {Num1 * Num2}.");
        }
        public static void Uppgift6()
        {
            Console.Write("Skriv det första talet: ");
            double Num1 = double.Parse(Console.ReadLine());
            Console.Write("Skriv det andra talet: ");
            double Num2 = double.Parse(Console.ReadLine());
            Console.Write("Skriv det tredje talet: ");
            double Num3 = double.Parse(Console.ReadLine());
            Console.Write("Skriv det fjärde talet: ");
            double Num4 = double.Parse(Console.ReadLine());
            Console.Write("Skriv det femte talet: ");
            double Num5 = double.Parse(Console.ReadLine());
            double Average = (Num1 + Num2 + Num3 + Num4 + Num5) / 5;
            Console.WriteLine($"Medelvärdet av talen är {Average}.");
        }
        public static void Uppgift7()
        {
            Console.Write("Skriv det första talet: ");
            double Num1 = double.Parse(Console.ReadLine());
            Console.Write("Skriv det andra talet: ");
            double Num2 = double.Parse(Console.ReadLine());
            Console.WriteLine($"Summan är {Num1 + Num2} \nSkillnaden är {Num1 - Num2}. \nProdukten är {Num1 * Num2}. \nKvoten är {Num1 / Num2}.");
        }
        public static void Uppgift8()
        {
            Console.Write("Hur många tum?: ");
            double Inches = double.Parse(Console.ReadLine());
            double Meters = Inches * 0.0254;
            Console.WriteLine($"{Inches} tum är {Meters} meter.");
        }
        public static void Uppgift9()
        {
            Console.Write("Vilket år föddes du?: ");
            int BirthYear = int.Parse(Console.ReadLine());
            Console.WriteLine($"Du är {2021 - BirthYear} år gammal");
        }
        public static void Uppgift10()
        {
            Console.Write("Vilket år föddes du?: ");
            int BirthYear = int.Parse(Console.ReadLine());
            Console.Write("Ange ett framtida årtal: ");
            int FutureYear = int.Parse(Console.ReadLine());
            Console.WriteLine($"År {FutureYear} är du {FutureYear - BirthYear} år gammal");
        }
        public static void Uppgift11()
        {
            Console.Write("Ange ett belopp i kronor: ");
            double AmountKr = double.Parse(Console.ReadLine());
            Console.WriteLine($"Det motsvarar ca. {AmountKr / 8.65} us dollar. ");
        }
        public static void Uppgift12()
        {
            Console.Write("Hur bred är rektangeln");
            double Width = double.Parse(Console.ReadLine());
            Console.Write("Hur lång är rektangeln");
            double Length = double.Parse(Console.ReadLine());
            Console.WriteLine($"Rektangeln har arean {Width * Length}");
        }
        public static void Uppgift13()
        {
            Console.Write("Ange framkörningsavgiften: ");
            double BaseCost = double.Parse(Console.ReadLine());
            Console.Write("Ange kostnad per km: ");
            double kmCost = double.Parse(Console.ReadLine());
            Console.Write("Hur lång är resan i km: ");
            double DriveLength = double.Parse(Console.ReadLine());
            double Cost = kmCost * DriveLength + BaseCost;
            Console.WriteLine($"Resan kommer kosta {Cost} kr.");
        }
    }

    public class ProgSharpK2
    {
        public static void Uppgift201()
        {
            Console.Write("Var kommer du ifrån?: ");
            string City = Console.ReadLine();
            Console.Write("Vad är ditt drömresmål?:");
            string DreamPlace = Console.ReadLine();
            Console.WriteLine($"Hej {City}-bo, jag hoppas att du får åka till {DreamPlace}.");

            Console.ReadKey();
        }

        public static void Uppgift202()
        {
            Console.Write("Vilket år är det?: ");
            int Year = int.Parse(Console.ReadLine()) + 20;
            Console.WriteLine($"Om 20 år är det år {Year}.");
        }

        public static void Uppgift203()
        {
            Console.Write("Hur högt kan du hoppa i meter?: ");
            double HeightDiff = 2.45 - double.Parse(Console.ReadLine());
            Console.WriteLine($"Du hoppar {HeightDiff} meter lägre än världsrekordet på 2,45 meter.");
        }
        
        public static void Uppgift204()
        {
            Console.Write("Välj det första talet: ");
            double Number1 = double.Parse(Console.ReadLine());
            Console.Write("Välj det andra talet: ");
            double Number2 = double.Parse(Console.ReadLine());
            double Sum = Number1 + Number2;
            Console.WriteLine($"Summan av talen är {Sum}.");
        }
        public static void Uppgift205()
        {
            Console.Write("Vilket år är det?: ");
            int CurrentYear = int.Parse(Console.ReadLine());
            int YearsLeft = 2100 - CurrentYear;
            Console.WriteLine($"Det är {YearsLeft} år kvar till 2100.");
        }
        public static void Uppgift206()
        {
            Console.Write("Ange tal ett: ");
            double Number1 = double.Parse(Console.ReadLine());
            Console.Write("Ange tal två: ");
            double Number2 = double.Parse(Console.ReadLine());
            double Average = (Number1 + Number2) / 2;
            Console.WriteLine($"Medelvärdet av {Number1} och {Number2} är {Average}.");
        }
        public static void Uppgift207()
        {
            Console.Write("Skriv en mening av två ord utan punkt: ");
            string UserSentence = Console.ReadLine();
            string FirstWord = UserSentence[..UserSentence.IndexOf(" ")];
            string LastWord = UserSentence[(UserSentence.IndexOf(" ")+1)..];
            Console.Write(LastWord + " " + FirstWord);
        }
        public static void Uppgift208()
        {
            Console.Write("Skriv ett matteproblem med två variabler utan mellanslag: ");
            string Problem = Console.ReadLine();
            if (Problem.Contains("*"))
            {
                double Variable1 = double.Parse(Problem[..Problem.IndexOf("*")]);
                double Variable2 = double.Parse(Problem[(Problem.IndexOf("*") + 1)..]);
                double Answer = Variable1 * Variable2;
                Console.WriteLine($"Svaret är {Answer}");
            }
            else if (Problem.Contains("/"))
            {
                double Variable1 = double.Parse(Problem[..Problem.IndexOf("/")]);
                double Variable2 = double.Parse(Problem[(Problem.IndexOf("/") + 1)..]);
                double Answer = Variable1 / Variable2;
                Console.WriteLine($"Svaret är {Answer}");
            }
            else if (Problem.Contains("+"))
            {
                double Variable1 = double.Parse(Problem[..Problem.IndexOf("+")]);
                double Variable2 = double.Parse(Problem[(Problem.IndexOf("+") + 1)..]);
                double Answer = Variable1 + Variable2;
                Console.WriteLine($"Svaret är {Answer}");
            }
            else if (Problem.Contains("-"))
            {
                double Variable1 = double.Parse(Problem[..Problem.IndexOf("-")]);
                double Variable2 = double.Parse(Problem[(Problem.IndexOf("-") + 1)..]);
                double Answer = Variable1 - Variable2;
                Console.WriteLine($"Svaret är {Answer}");
            }
            else
            {
                Console.WriteLine("Glöm inte ett räknesätt. :(");
            }
        }
        public static void Uppgift209()
        {
            Console.Write("Vad heter du?: ");
            Console.Write($"Hej, {Console.ReadLine()}");
        }
    }
}
