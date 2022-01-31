using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Threading;
using System.Diagnostics;
using System.IO;

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
    class ProgSharpK3
    {
        public static void Uppgift301()
        {
            Console.Write("Hur gammal är du?: ");
            int ålder = int.Parse(Console.ReadLine());

            if (ålder >= 50)
            {
                Console.WriteLine("Du får vara med i senior golfen!");
            }
            else
            {
                Console.WriteLine("Du får inte vara med i senior golfen! :(");
            }
        }
        public static void Uppgift302()
        {
            Console.Write("Vilket land vann VM i damfotboll 2015): ");
            string Answer = Console.ReadLine().ToLower();
            if (Answer == "usa")
            {
                Console.WriteLine("Rätt!");
            }
            else
            {
                Console.WriteLine("Fel! :(");
            }
        }
        public static void Uppgift303()
        {
            Console.Write("Vad heter du?: ");
            string Name = Console.ReadLine();
            if (Name == "Stig")
            {
                Console.WriteLine("Du har namnsdag idag!");
            }
            else if (Name == "Abraham")
            {
                Console.WriteLine("Du har namnsdag imorgon"!);
            }
            else
            {
                Console.WriteLine("Du har varken namnsdag idag eller imorgon.");
            }
        }

        public static void Uppgift304()
        {
            Console.Write("Hur mycket poäng fick du?: ");
            int Score = int.Parse(Console.ReadLine());
            if (Score >= 55)
            {
                Console.WriteLine("Du fick ett A!");
            }
            else if (Score >= 46)
            {
                Console.WriteLine("Du fick ett B!");
            }
            else if (Score >= 35)
            {
                Console.WriteLine("Du fick ett C!");
            }
            else if (Score >= 27)
            {
                Console.WriteLine("Du fick ett D!");
            }
            else if (Score > 18)
            {
                Console.WriteLine("Du fick ett E!");
            }
            else
            {
                Console.WriteLine("Du fick ett F. :(");
            }
        }
        public static void Uppgift305()
        {
            Console.Write("Hur gammal är du? Svara i år: ");
            int Age = int.Parse(Console.ReadLine());
            Console.Write("Hur mycket tjänar du i månaden? Svara i kronor: ");
            int Salary = int.Parse(Console.ReadLine());
            if (Age < 39)
            {
                if (Salary <= 36100)
                {
                    Console.WriteLine("Du är yngre än medelåldern och tjänar mindre än medellönen.");
                }
                if (Salary == 36100)
                {
                    Console.WriteLine("Du är yngre än medelåldern och tjänar lika mycket som medellönen.");
                }
                if (Salary >= 36100)
                {
                    Console.WriteLine("Du är yngre än medelåldern och tjänar mer än medellönen.");
                }
            }
            else if (Age == 39)
            {
                if (Salary <= 36100)
                {
                    Console.WriteLine("Du lika gammal som medelåldern och tjänar mindre än medellönen.");
                }
                if (Salary == 36100)
                {
                    Console.WriteLine("Du lika gammal som medelåldern och tjänar lika mycket som medellönen.");
                }
                if (Salary >= 36100)
                {
                    Console.WriteLine("Du lika gammal som medelåldern och tjänar mer än medellönen.");
                }
            }
            else if (Age > 39)
            {
                if (Salary <= 36100)
                {
                    Console.WriteLine("Du är äldre än medelåldern och tjänar mindre än medellönen.");
                }
                if (Salary == 36100)
                {
                    Console.WriteLine("Du är äldre än medelåldern och tjänar lika mycket som medellönen.");
                }
                if (Salary >= 36100)
                {
                    Console.WriteLine("Du är äldre än medelåldern och tjänar mer än medellönen.");
                }
            }
            else
            {
                Console.WriteLine("Något blev fel. :(");
            }
        }
        public static void Uppgift306()
        {
            Console.Write("Hur lång är du? Svara i meter: ");
            double Height = double.Parse(Console.ReadLine());

            if (Height >= 1.5 && Height <= 1.9)
            {
                Console.WriteLine("Grattis, du får åka berg-och-dalbanan!");
            }
            else
            {
                Console.WriteLine("Tyvärr, du får inte åka berg-och-dalbanan.");
            }
        }
        public static void Uppgift307()
        {
            Console.Write("Hur gammal är du?Svara i år: ");
            int Age = int.Parse(Console.ReadLine());
            if ((Age >= 10 && Age <= 18) || Age >= 65)
            {
                Console.WriteLine("Du får rabatt!");
            }
            else
            {
                Console.WriteLine("Du får inte rabatt!");
            }
        }
        public static void Uppgift308()
        {
            Console.Write("Skriv ord ett: ");
            string Word1 = Console.ReadLine();
            Console.Write("Skriv ord två: ");
            string Word2 = Console.ReadLine();
            Console.Write("Skriv ord tre: ");
            string Word3 = Console.ReadLine();

            if (Word1.CompareTo(Word2) < 0 && Word1.CompareTo(Word3) < 0)
            {
                Console.WriteLine("Det första ordet kommer först i bokstavsordning.");
            }
        }
        public static void Uppgift309()
        {
            Console.Write("Skriv en sträng: ");
            string Input = Console.ReadLine();

            if (Input.Contains("+"))
            {
                if (Input.Contains("-"))
                {
                    Console.WriteLine("Strängen innehåller både + och -.");
                }
                else
                {
                    Console.WriteLine("Strängen innehåller ett +.");
                }
            }
            else if (Input.Contains("-"))
            {
                Console.WriteLine("Strängen innehåller ett -.");
            }
            else
            {
                Console.WriteLine("Strängen innehåller varken ett + eller -");
            }
        }
        public static void Uppgift310()
        {
            Console.Write("Vilken plats kom du i idrottsturneringen?: ");
            int Placement = int.Parse(Console.ReadLine());

            switch (Placement)
            {
                case 1:
                    Console.WriteLine("Grattis, du fick guld!");
                    break;
                case 2:
                    Console.WriteLine("Grattis, du fick silver!");
                    break;
                case 3:
                    Console.WriteLine("Grattis, du fick brons.");
                    break;
                default:
                    Console.WriteLine("Du fick ingen medalj.");
                    break;
            }
        }
        public static void Uppgift311()
        {
            Console.WriteLine("Välj ett ämne: \n1. Musik \n2. Geografi \n3. Historia");
            string Choice = Console.ReadLine();

            switch (Choice)
            {
                case "1":
                    Console.Write("Musik: Vilket år dog Michael Jackson?: ");
                    int Answer1 = int.Parse(Console.ReadLine());
                    switch (Answer1)
                    {
                        case 2009:
                            Console.WriteLine("Rätt Svar!");
                            break;
                        default:
                            Console.WriteLine("Fel!");
                            break;
                    }
                    break;
                case "2":
                    Console.Write("Geografi: På vilken kontinent ligger Kina?: ");
                    string Answer2 = Console.ReadLine();
                    switch (Answer2)
                    {
                        case "Asien":
                            Console.WriteLine("Rätt Svar!");
                            break;
                        default:
                            Console.WriteLine("Fel!");
                            break;
                    }
                    break;
                case "3":
                    Console.Write("Historia: Vilket år blev Gustav Vasa kung? ");
                    int Answer3 = int.Parse(Console.ReadLine());
                    switch (Answer3)
                    {
                        case 1523:
                            Console.WriteLine("Rätt Svar!");
                            break;
                        default:
                            Console.WriteLine("Fel!");
                            break;
                    } 
                    break;
                default:
                    Console.WriteLine("Skriv en siffra, 1-3.");
                    break;
            }
        }
        public static void Uppgift312()
        {
            Console.Write("Hur många datorer har du?: ");
            int Amount = int.Parse(Console.ReadLine());
            string Conjuction = Amount == 1 ? "dator" : "datorer";
            Console.Write($"Du har {Amount} {Conjuction}."); 
        }
        public static void Uppgift321()
        {
            Console.Write("Skriv ett uttryck med ett eller två plustecken: ");
            string Problem = Console.ReadLine();
            int FirstIndex = Problem.IndexOf("+");
            int SecondIndex = FirstIndex + 1 + Problem[(FirstIndex+1)..].IndexOf("+");
            if (FirstIndex == SecondIndex) SecondIndex = Problem.Length;
            double Term1 = double.Parse(Problem[..FirstIndex]);
            double Term2 = double.Parse(Problem[FirstIndex..SecondIndex]);
            double Term3 = 0;
            if ((SecondIndex + 1) <= Problem.Length) Term3 = double.Parse(Problem[(SecondIndex + 1)..]);
            Console.WriteLine($"Svaret är: {Term1 + Term2 + Term3}");
        }
    }
    class ProgSharpK4
    {
        public static void Uppgift401()
        {
            string Answer = "";
            Console.WriteLine("Vilket är världens folkrikaste land?: ");
            while (Answer != "kina")
            {
                Console.Write("Ditt svar: ");
                Answer = Console.ReadLine().ToLower();
            }
            Console.WriteLine("Rätt!");
        }
        public static void Uppgift402()
        {
            int Number = 50;
            while (Number > 0)
            {
                Console.WriteLine(Number);
                Number--;
            }
        }
        public static void Uppgift403()
        {
            int Choice = 0;
            
            while (Choice != 3)
            {
                Console.WriteLine("\nVälj ett av följande alternativ. \n1. Omvandla meter till kilometer. \n2. Omvandla kilometer till meter. \n3. Avsulta programmet.");
                Choice = int.Parse(Console.ReadLine());
                switch (Choice)
                {
                    case 1:
                        Console.Write("Skriv antal meter:");
                        Console.WriteLine((double.Parse(Console.ReadLine()) / 1000));
                        break;
                    case 2:
                        Console.Write("Skriv antal kilometer:");
                        Console.WriteLine((double.Parse(Console.ReadLine()) * 1000));
                        break;
                    case 3:
                        Console.WriteLine("Programmet avslutas.");
                        break;
                    default:
                        Console.WriteLine("Skriv ett giltligt nummer.");
                        break;
                }
            }
        }
        public static void Uppgift404()
        {
            for (int i = 40; i <= 80; i++)
            {
                Console.WriteLine(i);
            }
        }
        public static void Uppgift405()
        {
            for (int year = 1495; year >= 1400; year -= 5)
            {
                Console.WriteLine(year);
            }
        }
        public static void Uppgift406()
        {
            Console.Write("Skriv ett ord:");
            string Message = Console.ReadLine();
            for (int i = Message.Length; i > 0; i--)
            {
                Console.WriteLine(Message[i-1]);
            }
        }
        public static void Uppgift407()
        {
            Console.Write("Skriv en rad siffror: ");
            string Numbers = Console.ReadLine();
            int Sum = 0;
            for (int i = 0; i < Numbers.ToString().Length; i++)
            {
                Sum += int.Parse(Numbers[i].ToString());
            }
            Console.WriteLine(Sum);
        }
        public static void Uppgift408()
        {
            Console.Write("Skriv ett tal: ");
            string Number = Console.ReadLine();
            bool NumberContain = Number.Contains("3") || Number.Contains("7");
            if (NumberContain)
            {
                Console.WriteLine("Talet innehåller 3 eller 7.");
            }
            else
            {
                Console.WriteLine("Talet innehåller varken 3 eller 7.");
            }
        }
        public static void Uppgift409()
        {
            Console.Write("Hur många kvadrattal?: ");
            int x = int.Parse(Console.ReadLine());
            for (int i = 1;  i <= x; i++)
            {
                Console.WriteLine($"{i} * {i} = {i * i}");
            }
        }
        public static void Uppgift410()
        {
            for (int i = 1; i <= 30; i++)
            {
                if (i == 12 || i == 27)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
        }
        public static void Uppgift411()
        {
            Console.WriteLine("Vilket är Europas folkrikaste land?: ");
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Ditt Svar: ");
                string Answer = Console.ReadLine().ToLower();
                if (Answer == "kina")
                {
                    Console.WriteLine("Rätt!");
                    break;
                }
                Console.Write("Fel!");
            }
        }
        public static void Uppgift412()
        {
                for (int u = 1; u < 7; u++)
                {
                    Console.WriteLine($"{u} {u * 2} {u * 3} {u * 4} {u*5} {u*6}");
                }
        }
        public static void Uppgift413()
        {
            Console.Write("Välj höjd: ");
            int Height = int.Parse(Console.ReadLine());
            Console.Write("Välj bredd: ");
            int Width = int.Parse(Console.ReadLine());

            for (int i = 0; i < Height; i++)
            {
                if (i == 0 || i == Height - 1)
                {
                    Console.WriteLine("");
                    for (int u = 0; u < Width; u++)
                    {
                        Console.Write("X");
                    }
                }
                else
                {
                    Console.Write("X");
                    for (int v = 0; v < Width - 2; v++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write("X");
                }
            }
        }
        public static void Uppgift414()
        {
            Console.Write("Skriv ett ord: ");
            string Word = Console.ReadLine();

            for (char i = (char)0; i <= 256; i++)
            {
                int Freq = 0; //Amount of '\' in RowInput
                foreach (char c in Word)
                {
                    if (c == i) Freq++;
                }
                if (Freq > 1)
                {
                    Console.WriteLine($"Teckent {i} förekommer {Freq} gånger");
                }
            }
        }
        public static void Uppgift415()
        {
            string Message = "Hej! Är 3,14 ett heltal? Tack, för att du, läste meddelandet.";
            for (int i = 0; i < Message.Length; i++)
            {
                Console.Write(Message[i]);
                if (Message[i] == '.' || Message[i] == '!' || Message[i] == '?' || Message[i] == ',')
                {
                    Thread.Sleep(750);
                }
                else
                {
                    Thread.Sleep(50);
                }
            }
        }
        public static void Uppgift416()
        {
            string Message = "Hej! Är 3,14 ett heltal? Tack, för att du, läste meddelandet.";
            for (int i = 0; i < Message.Length; i++)
            {
                Console.Write(Message[i]);
                if (Message[i] == '.' || Message[i] == '!' || Message[i] == '?' || (Message[i] == ',' && Message[i + 1] == ' '))
                {
                    Thread.Sleep(750);
                }
                else
                {
                    Thread.Sleep(50);
                }
            }
        }
        public static void Uppgift417()
        {
            string Word = "Hello";
            string Word2 = Word[-1..];
        }
        public static void Uppgift418()
        {
            int x = int.Parse("x");
        }
        public static void Uppgift419()
        {
            Console.WriteLine("Detta program har en loop");
            Console.WriteLine("Loopen räknar ut summan av talen 0 till 4");
            int summa = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Nu skrivs värdet av i ut");
                Console.WriteLine($"i = {i}");
                // Öka summa-variabeln med värdet av i
                summa += i;
            }

            Console.WriteLine($"Summan av talen är {summa}");
        }
        public static void Uppgift424()
        {
            for (int i = 1; i < 101; i++)
            {
                if (i % 3 == 0 && i % 5 == 0) Console.WriteLine("FizzBuzz");
                else if (i % 3 == 0) Console.WriteLine("Fizz");
                else if (i % 5 == 0) Console.WriteLine("Buzz");
                else Console.WriteLine(i);
            }
        }
        public static void Uppgift426()
        {
            Console.Write("Skriv in ett tal: ");
            string input = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                if (int.Parse(input[i].ToString()) == 9) Console.Write(0);
                else Console.Write(int.Parse(input[i].ToString()) + 1); 
            }
        }
        public static void Uppgift430()
        {
            Console.Write("Hur många O per grupp?: ");
            int Os = int.Parse(Console.ReadLine());
            Console.Write("Hur många X per grupp?: ");
            int Xs = int.Parse(Console.ReadLine());
            Console.Write("Hur många O grupper?: ");
            int OGroups = int.Parse(Console.ReadLine());
            Console.Write("Hur många rader??: ");
            int Rows = int.Parse(Console.ReadLine());

            for (int r = 0; r < Rows; r++)
            {
                for (int og = 0; og < OGroups; og++)
                {
                    for (int x = 0; x < Xs; x++)
                    {
                        Console.Write("X");
                    }
                    Console.Write("-");
                    for (int o = 0; o < Os; o++)
                    {
                        Console.Write("O");
                    }
                    Console.Write("-");
                }
                for (int x = 0; x < Xs; x++)
                {
                    Console.Write("X");
                }
                Console.WriteLine();
            }
        }
        public static void Uppgift431()
        {
            Console.Write("Ange ett ord: ");
            string Word = Console.ReadLine();
            bool AtleastOneTrueCase = false;

            for (int i = 0; i < Word.Length; i++)
            {
                int Freq = 0;
                for (int j = 0; j < Word.Length; j++)
                {                
                    if (Word[i] == Word[j])
                    {
                        Freq++;
                    }                    
                }
                if (i == Word.IndexOf(Char.ToString(Word[i])) && Freq > 1) //Kollar om det är första gången Word[i] kollas samt om den förekommer fler än en gång.
                {
                    AtleastOneTrueCase = true; //Om minst en bokstav har förekommit fler än en gång så kommer detta förbli true
                    Console.WriteLine($"{Word[i]} förekommer {Freq} gånger");
                }
            }
            if (AtleastOneTrueCase != true)
            {
                Console.Write("Ingen bokstav förekommer fler än en gång.");
            }
        }
        public static void Uppgift432()
        {
            Console.Write("Bestäm kvadratens sidlängd: ");
            int Side = int.Parse(Console.ReadLine());
            Console.Write("Bestäm rutnätets bredd: ");
            int Width = int.Parse(Console.ReadLine());
            Console.Write("Bestäm rutnätets höjd: ");
            int Height = int.Parse(Console.ReadLine());

            for (int h = 0; h < Height; h++)
            {
                for (int k = 0; k < Side; k++)
                {
                    for (int j = 0; j < Width; j++)
                    {
                        for (int i = 0; i < Side; i++)
                        {
                            Console.Write("*");
                        }
                        Console.Write(" ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }
        public static void Uppgift433()
        {
            Console.Write("Ange ord ett: ");
            string Word1 = Console.ReadLine();
            Console.Write("Ange ord två: ");
            string Word2 = Console.ReadLine();
            string Output = "";
            for (char i = (char)0; i <= 256; i++)
            {
                int Freq1 = 0;
                int Freq2 = 0;
                foreach (char c in Word1) //Counts char c in word 1
                {
                    if (c == i) Freq1++;
                }
                foreach (char c in Word2) //Counts char c in word 2
                {
                    if (c == i) Freq2++;
                }
                if (Freq1 > Freq2) //Om det finns fler char c i word 1 än word 2, lägg till char c i output strängen. 
                {
                    Output += i;
                }
            }
            Console.WriteLine(Output);
        }
    }
    public static class Other
    {
        public static void Kroppkakeuppgiften()
        {
            Console.WriteLine("Välj en maträtt: \n1. Kroppkakor \n2. Ugnspannkaka \n3. Ostkaka");
            int Meal = int.Parse(Console.ReadLine());
            Console.WriteLine("Välj tillbehör: \n1. Lingonsylt \n2. Jordgubbssylt");
            int Extra = int.Parse(Console.ReadLine());
            if ((Meal == 1 && Extra == 1) || (Meal == 2) || (Meal == 3 && Meal == 2))
            {
                Console.Write("Du har valt en bra kombination!");
            }
            else if (Meal >= 1 && Meal <= 3 && Extra >= 1 && Extra <= 2)
            {
                Console.Write("Du har valt en dålig kombination.");
            }
            else
            {
                Console.WriteLine("Skriv giltliga siffror.");
            }
        }
        public static void Average()
        {
            double sum = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Skriv ett tal: ");
                double input = double.Parse(Console.ReadLine());
                sum += input;
            }
            Console.WriteLine($"Medelvärdet är {sum / 10}.");
        }
        static Random rand = new Random();
        public static int?[] RandomArray()
        {
            int?[] arr = new int?[9];
            for (int i = 0; i < 9; i++)
            {
                while (arr[i] == null)
                {
                    int k = rand.Next(1, 10);
                    if ((Array.Exists(arr, element => element == k)) == false)
                    {
                        arr[i] = k;
                    }
                }
            }
            return arr;
        }
        public static void SudokuFillTest()
        {
            int?[,] SolvedBoard = new int?[9, 9];

            for (int i = 0; i < 9; i++)
            {
                int s = 0;
                for (int j = 0; j < 9; j++)
                {
                    bool NumberFound = false;
                    int m = 0;
                    int r = 0;

                    while (NumberFound == false)
                    {

                        int?[] RandomArray = new int?[9]; //Creates and array with numbers 1-9 in random order.
                        for (int k = 0; k < 9; k++)
                        {
                            while (RandomArray[k] == null)
                            {
                                int l = new Random().Next(1, 10);
                                if ((Array.Exists(RandomArray, element => element == l)) == false)
                                {
                                    RandomArray[k] = l;

                                }
                            }
                        }
                        Console.Write(RandomArray[m]);
                        bool number_clear = true;

                        int rowStart = (i / 3) * 3;
                        int colStart = (j / 3) * 3;

                        for (int l = 0; l < 9; ++l)
                        {
                            if (SolvedBoard[i, l] == RandomArray[m]) number_clear = false;
                            if (SolvedBoard[l, j] == RandomArray[m]) number_clear = false;
                            if (SolvedBoard[rowStart + (l % 3), colStart + (l / 3)] == RandomArray[m]) number_clear = false;
                        }
                        if (number_clear)
                        {
                            NumberFound = true;
                            SolvedBoard[i, j] = RandomArray[m];
                            Console.Write("Clear");
                            Console.WriteLine(SolvedBoard[i, j]);
                        }
                        if (m == 8)
                        {
                            m = 0;
                            if ( r >= 32)
                            {
                                for (int l = 0; l < 9; l++) //If a row paints itself into a corner, remake the row after a few tries.
                                {
                                    SolvedBoard[i, l] = null;
                                    j = 0;
                                }
                                Console.WriteLine($"------------- ^Invalid Row for Row {i}");
                                s++;
                            }
                        }
                        else m++; r++;
                        if (s >= 6) //Restart grid generation if it comes to a dead end
                        {
                            Console.WriteLine("Grid Reset");
                            for (int k = 0; k < 9; k++)
                            {
                                for (int l = 0; l < 9; l++)
                                {
                                    SolvedBoard[k, l] = null;
                                    i = 0;
                                    j = 0;
                                    s = 0;
                                }
                            }
                        }
                    }
                }
                Console.WriteLine($"------------- ^Row {i}");
            }
            for (int i = 0; i < 9; i++) //Print final board
            {
                for (int j = 0; j < 9; j++)
                {
                    Console.Write(SolvedBoard[i, j].ToString());
                }
                Console.WriteLine();
            }
        } 
        public static int?[,] SudokuSolver(int?[,] arr)
        {
            int?[,] temp_board = new int?[9, 9];

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (arr[i, j] != null)
                    {

                    }
                }
            }
            return temp_board;
        }
        public static void Loopar3()
        {
            int guess = new Random().Next(1, 101);
            int tries = 1;
            bool number_found = false;

            while (!number_found)
            {
                Console.Write($"Är {guess} högt eller lågt eller rätt?: ");
                string högt_eller_lågt = Console.ReadLine().ToLower();
                if (högt_eller_lågt == "högt")
                {
                    guess = new Random().Next(1, guess);
                }
                else if (högt_eller_lågt == "lågt")
                {
                    guess = new Random().Next(guess, 101);
                }
                else if (högt_eller_lågt == "rätt")
                {
                    number_found = true;
                    Console.WriteLine($"Det tog {tries} gissningar att hitta dit tal som var {guess}.");
                }
                tries++;
            }
        }
        public static void Loopar4D()
        {
            Console.Write("Ange ett tal: ");
            int input = int.Parse(Console.ReadLine());
            List<int> legal_numerators = new List<int>();

            for (int i = 2; i < Math.Sqrt(input); i++)
            {
                if (input % i == 0)
                {
                    legal_numerators.Add(i);
                }
            }
            if (!legal_numerators.Any())
            {
                Console.WriteLine($"{input} är ett primtal.");
            }
            else
            {
                Console.WriteLine($"{input} är inte ett primtal, {input} är delbart med alla dessa tal: ");
                foreach (int item in legal_numerators)
                {
                    Console.WriteLine(item); 
                }
            }
        }
        public static void Calculator()
        {
            Console.Write("Skriv ett uttryck med endast +,-,*,/ tecken utan mellanslag: ");
            string input = Console.ReadLine();
            bool has_div_or_mult = false;
            bool has_add_or_sub = false;
            char[] charsAll = {'*', '/', '+', '-' };
            char[] charsMultiDiv = {'*', '/' };
            char[] charsAddSub = {'+', '-' };
            if (input.Contains('*') || input.Contains('/')) has_div_or_mult = true;
            while (has_div_or_mult)
            {
                double tempAnswer = 0;
                int op_index = input.IndexOfAny(charsMultiDiv);
                int start_index = input[..op_index].IndexOfAny(charsAll);
                int end_index = input[(op_index + 1)..].IndexOfAny(charsAll) + op_index;

                double first_term;
                if (start_index < 0)
                {
                    first_term = double.Parse(input[..op_index]);
                    start_index = 0;
                }
                else
                {
                    first_term = double.Parse(input[start_index..op_index]);
                    start_index += 1;
                }
                double second_term;
                if (input[(op_index + 1)..].IndexOfAny(charsAll) < 0)
                {
                    second_term = double.Parse(input[(op_index + 1)..]);
                    end_index = input.Length;
                }
                else second_term = double.Parse(input[(op_index + 1)..(end_index + 1)]);
                if (input[op_index] == '*') tempAnswer = first_term * second_term;
                else if (input[op_index] == '/') tempAnswer = first_term / second_term;
                if (input[start_index] == '+' || input[start_index] == '-')
                {
                    if (input[(op_index + 1)..].IndexOfAny(charsAll) < 0) input = input.Remove((start_index + 1), (end_index - start_index));
                    else input = input.Remove((start_index + 1), (end_index + op_index) - start_index + 1);
                }
                else
                {
                    if (input[(op_index + 1)..].IndexOfAny(charsAll) < 0) input = input.Remove(start_index, (end_index - start_index));
                    else input = input.Remove(start_index, ((end_index) - start_index) + 1);
                }

                input = input.Insert(start_index, tempAnswer.ToString());
                if ((input.Contains('*') == false && input.Contains('/') == false)) has_div_or_mult = false;
            }
            Console.WriteLine(input);

            if (input.Contains('+') || input.Contains('-')) has_add_or_sub = true;
            while (has_add_or_sub)
            {
                double tempAnswer = 0;
                int op_index = input.IndexOfAny(charsAddSub);
                int start_index = input[..op_index].IndexOfAny(charsAll);
                int end_index = input[(op_index + 1)..].IndexOfAny(charsAll) + op_index;

                double first_term;
                if (start_index < 0)
                {
                    first_term = double.Parse(input[..op_index]);
                    start_index = 0;
                }
                else
                {
                    first_term = double.Parse(input[start_index..op_index]);
                    start_index += 1;
                }

                double second_term;
                if (input[(op_index + 1)..].IndexOfAny(charsAll) < 0)
                {
                    second_term = double.Parse(input[(op_index + 1)..]);
                    end_index = input.Length;
                }
                else second_term = double.Parse(input[(op_index + 1)..(end_index + 1)]);

                if (input[op_index] == '+') tempAnswer = first_term + second_term;
                else if (input[op_index] == '-') tempAnswer = first_term - second_term;


                if (input[start_index] == '+' || input[start_index] == '-')
                {
                    if (input[(op_index + 1)..].IndexOfAny(charsAll) < 0) input = input.Remove((start_index + 1), (end_index - start_index));
                    else input = input.Remove((start_index + 1), ((end_index + op_index) - start_index) + 1);
                }
                else
                {
                    if (input[(op_index + 1)..].IndexOfAny(charsAll) < 0) input = input.Remove(start_index, (end_index - start_index));
                    else input = input.Remove(start_index, ((end_index) - start_index) + 1);
                }

                input = input.Insert(start_index, tempAnswer.ToString());
                if ((input.Contains('+') == false && input.Contains('-') == false)) has_add_or_sub = false;
            }
            Console.WriteLine(input);
        }
        public static void UppgiftA()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Ange ett tal mellan 1 och 10: ");
                string input = Console.ReadLine();
                int? parsedInput = null;
                if (int.TryParse(input, out int result))
                {
                    parsedInput = int.Parse(input);
                    if (parsedInput >= 1 && parsedInput <= 5)
                    {
                        for (int j = 0; j < parsedInput; j++)
                        {
                            Console.WriteLine(parsedInput);
                        }
                    }
                    else if (parsedInput >= 6 && parsedInput <= 10)
                    {
                        Console.WriteLine(parsedInput);
                    }
                    else Console.WriteLine("Talet var inte mellan 1 och 10.");
                }
                else Console.WriteLine("Du angav inte en siffra");
            }
        }
        public static void UppgiftB()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Ange ett tal mellan 1 och 10: ");
                string input = Console.ReadLine();
                int? parsedInput = null;
                if (int.TryParse(input, out int result))
                {
                    parsedInput = int.Parse(input);
                    if (parsedInput == 0)
                    {
                        Console.WriteLine("Du angav en nolla, avslutar...");
                        break;
                    }
                    else if (parsedInput >= 1 && parsedInput <= 5)
                    {
                        for (int j = 0; j < parsedInput; j++)
                        {
                            Console.WriteLine(parsedInput);
                        }
                    }
                    else if (parsedInput >= 6 && parsedInput <= 10)
                    {
                        Console.WriteLine(parsedInput);
                    }
                    else Console.WriteLine("Talet var inte mellan 1 och 10.");
                }
                else Console.WriteLine("Du angav inte en siffra");
            }
        }
        public static void Prov1()
        {
            int value = new Random().Next(1, 101); //101 Eftersom random ger som högst övre gräns - 1.
            Console.Write("Du ska gissa på ett heltal mellan 1 och 100, du har 5 gissningar. \nGissning nr 1: ");
            int guess = int.Parse(Console.ReadLine());

            for (int i = 0; i < 4; i++)
            {
                if (guess == value)
                {
                    Console.WriteLine($"Bra jobbat, talet var {value}.");
                    break;
                }
                string highOrLow = guess >= value ? "högt" : "lågt";
                Console.Write($"Du gissade för {highOrLow}, gissa igen: ");
                guess = int.Parse(Console.ReadLine());
            }
            if (guess != value) Console.WriteLine($"Dinna gissningar tog slut, talet var {value}");
        }
        public static void Prov2()
        {
            int value = new Random().Next(1, 101); //101 Eftersom random ger som högst övre gräns - 1.
            Console.Write("Du ska gissa på ett heltal mellan 1 och 100, du har 5 gissningar. \nGissning nr 1: ");
            int guess = int.Parse(Console.ReadLine());

            for (int i = 1; i < 5; i++)
            {
                if (guess == value)
                {
                    Console.WriteLine($"Bra jobbat, talet var {value}."); //Uppgift 3: Console.WriteLine($"Bra jobbat, det tog dig {i} gånger att gissa rätt på {value}.");
                    break;
                }
                string highOrLow = guess > value ? "högt" : "lågt";
                Console.Write($"Gissning nr {i + 1 }, du gissade för {highOrLow}, gissa igen: ");
                guess = int.Parse(Console.ReadLine());
            }
            if (guess != value) Console.WriteLine($"Dina gissningar tog slut, talet var {value}");
        }
        public static void Prov3()
        {
            int value = new Random().Next(1, 101); //101 Eftersom random ger som högst övre gräns - 1.
            Console.Write("Du ska gissa på ett heltal mellan 1 och 100, du har 5 gissningar. \nGissning nr 1: ");
            int guess = int.Parse(Console.ReadLine());

            for (int i = 1; i < 5; i++)
            {
                if (guess == value)
                {
                    string gångOrGånger = i == 1 ? "gång" : "gånger";
                    Console.WriteLine($"Bra jobbat, det tog dig {i} {gångOrGånger} att gissa rätt på {value}.");
                    break;
                }
                string highOrLow = guess > value ? "högt" : "lågt";
                Console.Write($"Gissning nr {i + 1 }, du gissade för {highOrLow}, gissa igen: ");
                guess = int.Parse(Console.ReadLine());
            }
            if (guess != value) Console.WriteLine($"Dina gissningar tog slut, talet var {value}");
        }
        public static void Projekt2()
        {
            string[] tables = new string[8];
            string choice = "";
            Console.WriteLine("Detta är Centralrestaurangens bordshanterare");
            if (!File.Exists("Bord.txt"))
            {
                for (int i = 1; i <= 8; i++)
                {
                    tables[i - 1] = $"Bord {i} - Tomt";
                }
                File.WriteAllLines("Bord.txt", tables);
                Console.WriteLine("Hittade ingen sparad fil, skapade en ny.");
            }
            else
            {
                tables = File.ReadAllLines("Bord.txt");
                Console.WriteLine("Information lästes in från sparad fil.");
            }

            while (choice != "5")
            {
                Console.WriteLine("\nMeny: \n1. Lista alla bord \n2. Lägg till eller ändra bordsinformation \n3. Markera att ett bord är tomt \n4. Töm alla bord \n5. Avsulta programmet");
                choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        foreach (string row in tables)
                        {
                            Console.WriteLine(row);
                        }
                        break;

                    case "2":
                        Console.Write("Bordnummer: ");
                        if (!Int32.TryParse(Console.ReadLine(), out int tableNumber))
                        {
                            Console.WriteLine("Ange en siffra 1-8 för att välja bord.");
                            break;
                        }
                        Console.Write("Antal gäster vid bordet: ");
                        if (!Int32.TryParse(Console.ReadLine(), out int guests))
                        {
                            Console.WriteLine("Ange en siffra för antal gäster");
                            break;
                        }
                        Console.Write("Namn: ");
                        string name = Console.ReadLine();
                        tables[tableNumber - 1] = $"Bord {tableNumber} - Gäster: {guests}, Namn: {name}";
                        File.WriteAllLines("Bord.txt", tables);
                        break;

                    case "3":
                        Console.Write("Bordnummer: ");
                        if (!Int32.TryParse(Console.ReadLine(), out int tableNumber2))
                        {
                            Console.WriteLine("Ange en siffra 1-8 för att välja bord.");
                            break;
                        }
                        tables[tableNumber2 - 1] = $"Bord {tableNumber2} - Tomt";
                        File.WriteAllLines("Bord.txt", tables);
                        break;

                    case "4":
                        for (int i = 1; i <= 8; i++)
                        {
                            tables[i - 1] = $"Bord {i} - Tomt";
                        }
                        File.WriteAllLines("Bord.txt", tables);
                        break;

                    case "5":
                        break;

                    default:
                        Console.WriteLine("Ange en siffra 1-5 för att välja.");
                        break;
                }
            }
        }
    }
    public static class Projekt3Class
    {
        public static void Projekt3()
        {
            char[,] playerBoard = new char[9, 9];
            Fill2DArray(playerBoard, '-');
            char[,] computerBoard = new char[9, 9];
            Fill2DArray(computerBoard, '-');

            Console.WriteLine("Welcome to BattleShips! \nThis is your board: ");
            Print2DArray(playerBoard);
            Console.WriteLine("Press enter to place out your ships!");
            Console.ReadKey();
            Console.Clear();
            PlaceShip(playerBoard, 5);
            PlaceShip(playerBoard, 4);
            PlaceShip(playerBoard, 3);
            PlaceShip(playerBoard, 3);
            PlaceShip(playerBoard, 2);
            Console.WriteLine("You have placed all your 5 ships, this is your finsihed board!:");
            Print2DArray(playerBoard);



        }
        public static void PlaceShip(this Array arr, int ShipSize)
        {
            Console.Clear();
            bool ShipPlaced = false;
            Console.WriteLine($"Place the {ShipSize}-size ship by entering x and y values for both ends of the ship!");
            Console.WriteLine("It is only allowed to place the ship horzontally or vertically, not diagonally. (1, 1)  is top left corner.");
            Console.WriteLine("This is your current board: ");
            Print2DArray(arr);

            do
            {
                Console.Write("First X-value: ");
                int FirstX = int.Parse(Console.ReadLine()) - 1;
                Console.Write("First Y-value: ");
                int FirstY = int.Parse(Console.ReadLine()) - 1;
                Console.Write("Second X-value: ");
                int SecondX = int.Parse(Console.ReadLine()) - 1;
                Console.Write("Second Y-value: ");
                int SecondY = int.Parse(Console.ReadLine()) - 1;
                if (Math.Sqrt(Math.Pow(SecondX - FirstX, 2) + Math.Pow(SecondY - FirstY, 2)) == ShipSize)
                {
                    int LargestY = FirstY <= SecondY ? FirstY : SecondY;
                    if (SecondX - FirstX == 0)
                    {
                        for (int i = LargestY; i < LargestY + ShipSize; i++)
                        {
                            arr.SetValue('O', FirstX, i);
                        }
                    };
                    int LargestX = FirstX <= SecondX ? FirstX : SecondX;
                    if (SecondY - FirstY == 0)
                    {
                        for (int i = LargestX; i < LargestX + ShipSize; i++)
                        {
                            arr.SetValue('O', i, FirstY);
                        }
                    }
                    Console.WriteLine("This is your board now: ");
                    Print2DArray(arr);
                    Console.WriteLine("Are you happy with this ships' placement? [Y/N]");
                    if (Console.ReadLine().ToLower() == "y") ShipPlaced = true;
                    else Console.WriteLine("Place out the ship again.");
                }
                else
                {
                    Console.WriteLine("Coordinates were not valid, try again.");
                }
            } while (ShipPlaced == false);



        }
        public static void Fill2DArray(this Array arr, object value)
        {
            for (int i = 0; i < arr.GetLength(0) - 1; i++)
            {
                for (int j = 0; j < arr.GetLength(1) - 1; j++)
                {
                    arr.SetValue(value, i, j);
                }
            }
        }
        public static void Print2DArray(this Array arr)
        {
            for (int i = 0; i < arr.GetLength(0) - 1; i++)
            {
                for (int j = 0; j < arr.GetLength(1) - 1; j++)
                {
                    switch (arr.GetValue(i, j))
                    {
                        case '-':
                            Console.ForegroundColor = ConsoleColor.Blue;
                            break;
                        case 'O':
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            break;
                        case 'X':
                            Console.ForegroundColor = ConsoleColor.Red;
                            break;
                    }
                    Console.Write(arr.GetValue(i, j));
                }
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
    public class Sudoku
    {
        public static int?[,] SudokuFillTest()
        {
            int?[,] SolvedBoard = new int?[9, 9];

            for (int i = 0; i < 9; i++)
            {
                int s = 0;
                for (int j = 0; j < 9; j++)
                {
                    bool NumberFound = false;
                    int m = 0;
                    int r = 0;

                    while (NumberFound == false)
                    {
                        int?[] RandomArray = new int?[9]; //Creates and array with numbers 1-9 in random order.
                        for (int k = 0; k < 9; k++)
                        {
                            while (RandomArray[k] == null)
                            {
                                int l = new Random().Next(1, 10);
                                if ((Array.Exists(RandomArray, element => element == l)) == false)
                                {
                                    RandomArray[k] = l;

                                }
                            }
                        }
                        if (NumberValid(SolvedBoard, i, j, RandomArray[m]))
                        {
                            NumberFound = true;
                            SolvedBoard[i, j] = RandomArray[m];
                        }
                        if (m == 8)
                        {
                            m = 0;
                            if (r >= 32)
                            {
                                for (int l = 0; l < 9; l++) //If a row paints itself into a corner, remake the row after a few tries.
                                {
                                    SolvedBoard[i, l] = null;
                                    j = 0;
                                }
                                s++;
                            }
                        }
                        else m++; r++;
                        if (s >= 6) //Restart grid generation if it comes to a dead end
                        {
                            for (int k = 0; k < 9; k++)
                            {
                                for (int l = 0; l < 9; l++)
                                {
                                    SolvedBoard[k, l] = null;
                                    i = 0;
                                    j = 0;
                                    s = 0;
                                }
                            }
                        }
                    }
                }
            }
            return SolvedBoard;
        }
        public static bool SudokuSolverRandom(int?[,] arr, out int?[,] solvedBoard)
        {
            solvedBoard = arr;
            int?[] randomArray = Other.RandomArray();
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (solvedBoard[i, j] == null)
                    {

                        for (int k = 0; k <= 8; k++)
                        {

                            if (NumberValid(arr, i, j, randomArray[k]))
                            {

                                solvedBoard[i, j] = randomArray[k];
                                if (SudokuSolverRandom(arr, out solvedBoard))
                                {
                                    return true;
                                }
                                else solvedBoard[i, j] = null;

                            }
                        }
                        return false;
                    }
                }
            }
            return true;
        }
        public static bool SudokuSolver(int?[,] arr, out int?[,] solvedBoard)
        {            solvedBoard = arr;
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (solvedBoard[i, j] == null)
                    {
                        for (int k = 1; k <= 9; k++)
                        {

                            if (NumberValid(arr, i, j, k))
                            {

                                solvedBoard[i, j] = k;
                                if (SudokuSolver(arr, out solvedBoard))
                                {
                                    return true;
                                }
                                else solvedBoard[i, j] = null;

                            }
                        }
                        return false;
                    }
                }
            }
            return true;
        }
        public static bool SudokuSolverReverse(int?[,] arr, out int?[,] solvedBoard)
        {
            solvedBoard = arr;
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (solvedBoard[i, j] == null)
                    {
                        for (int k = 9; k >= 1; k--)
                        {

                            if (NumberValid(arr, i, j, k))
                            {

                                solvedBoard[i, j] = k;
                                if (SudokuSolver(arr, out solvedBoard))
                                {
                                    return true;
                                }
                                else solvedBoard[i, j] = null;

                            }
                        }
                        return false;
                    }
                }
            }
            return true;
        }
        public static int?[,] removeNumberRandom(int?[,] input_arr, int numbers_to_remove)
        {
            int?[,] copy = (int?[,])input_arr.Clone();

            for (int i = numbers_to_remove; i > 0; i--)
            {
                int row = new Random().Next(0, 9);
                int column = new Random().Next(0, 9);
                if (copy[row, column] != null) copy[row, column] = null;
                else i++;
            }
            return copy;
        }
        static Random rand = new Random();
        public static int?[,] removeNumberV2(int?[,]input_arr, int numbers_to_remove)
        {
            int upperBound = 3;
            for (int i = numbers_to_remove; i > 0; i--)
            {
                int cell = new Random().Next(upperBound - 3, upperBound);
                int row = cell / 9;
                int col = cell % 9;
                if (input_arr[row, col] != null)
                {
                    input_arr[row, col] = null;
                }
                else i++;

                if (upperBound == 81) upperBound = 3;
                else upperBound += 3;
            }
            return input_arr;
        }
        public static int?[,] removeNumberV3(int?[,]input_arr, int numbers_to_remove)
        {
            int[] oneOptionCells = new int[81];
            oneOptionCells = updateOneOptionCells(input_arr, oneOptionCells);
            for (int i = 0; i < 81; i++) oneOptionCells[i] = i;
            int cell, row, col;
             while (oneOptionCells.Length > 0)
            {
                cell = oneOptionCells[rand.Next(0, oneOptionCells.Length)];
                row = cell / 9;
                col = cell % 9;
                input_arr[row, col] = null;
                oneOptionCells = updateOneOptionCells(input_arr, oneOptionCells);
            } 
            return input_arr;

        }
        public static int[] updateOneOptionCells(int?[,] board, int[] oneOptionCells)
        {
            for (int i = 0; i < oneOptionCells.Length; i++)
            {
                if (countNumbersValid(board, oneOptionCells[i]) == 1) oneOptionCells[i] = i;
                else oneOptionCells = removeInArray(oneOptionCells, i);
            }
            return oneOptionCells;
        }
        public static int countNumbersValid(int?[,] input_arr, int cell)
        {
            int count = 0;
            int row = cell / 9;
            int col = cell % 9;
            for (int i = 0; i < 9; i++)
            {
                if (NumberValid(input_arr, row, col, i)) count++;
            }

            return count;
        }
        public static int[] removeInArray(int[] input_arr, int position)
        {
            List<int> nums = new List<int>(input_arr);
            nums.RemoveRange(position, 1);
            input_arr = nums.ToArray();
            return input_arr;
        }

        public static bool NumberValid(int?[,] board, int row, int column, int? value)
        {
            int rowStart = (row / 3) * 3;
            int colStart = (column / 3) * 3;

            for (int i = 0; i < 9; ++i)
            {
                if (board[row, i] == value) return false;
                if (board[i, column] == value) return false;
                if (board[rowStart + (i % 3), colStart + (i / 3)] == value) return false;
            }

            return true;
        }
        public static int?[,] generateBoard(int emptyCells)
        {
            int?[,] board = (int?[,])SudokuFillTest().Clone();
            int?[,] boardClone = new int?[9, 9];
            int tries = 1;
            bool boardFound = false;

            do
            {
                boardClone = (int?[,])board.Clone();
                boardClone = removeNumberV2(boardClone, emptyCells);
                Console.WriteLine($"Try number: {tries}");
                tries++;
                for (int i = 0; i < 9; i++) //Print final board
                {
                    for (int j = 0; j < 9; j++)
                    {
                        if (boardClone[i, j] == null) Console.Write(".");
                        else Console.Write(boardClone[i, j].ToString());
                    }
                    Console.WriteLine();
                }
                if (solutionUnique(boardClone))
                {
                    boardFound = true;
                    board = boardClone;
                }
                /*if (countCells(boardClone) <= (81 - emptyCells))
                {
                    boardFound = true;
                    board = boardClone;
                }*/
            } while (!boardFound);
            return board;
        }
        public static int countCells(int?[,] board)
        {
            int count = 0;
            for (int i = 0; i < board.GetLongLength(0); i++)
            {
                for (int j = 0;j < board.GetLongLength(1); j++)
                {
                    if (board[i, j] != null) count++;
                }
            }
            return count;
        }
        public static bool solutionUnique(int?[,] unsolved_arr)
        {
            int?[,] copy1 = (int?[,])unsolved_arr.Clone();
            int?[,] copy2 = (int?[,])unsolved_arr.Clone();
            Sudoku.SudokuSolver(copy1, out copy1);
            Sudoku.SudokuSolverReverse(copy2, out copy2);

            if (arrayEqual(copy1, copy2) && gridFull(copy1)) return true;
            return false;
        }
        public static bool arrayEqual(int?[,] arr1, int?[,] arr2)
        {
            if (arr1.GetLength(0) != arr2.GetLength(0)) return false;
            if (arr1.GetLength(1) != arr2.GetLength(1)) return false;

            for (int i = 0; i < arr1.GetLength(0); i++)
            {
                for (int j = 0; j < arr1.GetLength(1); j++)
                {
                    if (arr1[i, j] != arr2[i, j]) return false;
                }
            }
            return true;
        }
        public static bool arrayContainsInteger(int?[] arr, int value)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == value) return true;
            }
            return false;
        }
        public static bool gridFull(int?[,] board)
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (board[i, j] == null) return false;
                }
            }
            return true;
        }
        public static int?[,] generateBoardV2(int emptyCells)
        {
            int?[,] board = new int?[9, 9];
            int i = 0;

            while (true)
            {
                Console.WriteLine($"Try nr. {i++}.");
                while (81 - emptyCells >= 0)
                {
                    int Cell = rand.Next(0, 81);
                    int potentialNumber = rand.Next(1, 10);
                    if (board[Cell / 9, Cell % 9] == null && NumberValid(board, Cell / 9, Cell % 9, potentialNumber))
                    {
                        board[Cell / 9, Cell % 9] = potentialNumber;
                        emptyCells++;
                    }
                }
                if (solutionUnique(board)) return board;
            }
        }
    }
}
    


    




                
 