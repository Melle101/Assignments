using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Threading;

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
            int x = int.Parse(Console.ReadLine()) + 1;
            for (int i = 1;  i < x; i++)
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
                foreach (char c in Word1)
                {
                    if (c == i) Freq1++;
                }
                foreach (char c in Word2)
                {
                    if (c == i) Freq2++;
                }
                if (Freq1 > Freq2)
                {
                    Output += i;
                }
            }
            Console.WriteLine(Output);
        }
        public static void Projekt1()
        {

        }
    }
}
