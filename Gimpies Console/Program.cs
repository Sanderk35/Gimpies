using System;
using System.Diagnostics;
using System.Threading;

namespace Gimpies_Console {
    internal class Program {
        static void Main(string[] args) {
            string realPassword = "Gimpies_Inkoop";
            string realUsername = "Inkoop";
            string password = null;
            ConsoleKeyInfo key;
            string username = null;
            int tries = 3;
            string[] brand = new string[] { "Nike", "Addidas", "Puma" };
            string[] type = new string[] { /*Nike*/"Air Max", /*Puma*/"Shuffle", /*Adidas*/"Daily 3.0", /*Nike*/"Revolution 6" };
            int[] count = new int[] { 19, 34, 27, 13 };
            int[] buyCount = new int[4];
            string[] stringCount = new string[4];
            while (true)
            {
                while (true)
                {
                    Console.Write("Typ hier de gebruikersnaam: ");
                    username = Console.ReadLine();
                    Console.Write("Typ hier het wachtwoord: ");
                    do
                    {
                        key = Console.ReadKey(true);

                        if (key.Key == ConsoleKey.Backspace && password.Length > 0)
                        {
                            password = password.Substring(0, password.Length - 1);
                            Console.Write("\b \b");
                        }
                        else if (key.Key != ConsoleKey.Enter && key.Key != ConsoleKey.Escape)
                        {
                            password += key.KeyChar;
                            Console.Write("*");
                        }
                    } while (key.Key != ConsoleKey.Enter);
                    Console.WriteLine("");
                    if (password == realPassword && username == realUsername)
                    {
                        Console.CursorVisible = false;
                        Console.WriteLine("De inloggegevens zijn correct");
                        Thread.Sleep(1000);
                        break;
                    }
                    else
                    {
                        tries = tries - 1;
                        if (tries == 0)
                        {
                            Console.WriteLine("De gegevens kloppen niet, u hebt geen pogingen meer.");
                            Thread.Sleep(3000);
                            Environment.Exit(0);
                        }
                        Console.WriteLine("De gegevens kloppen niet, u heeft nog " + tries + " poging(en) over.");
                        Thread.Sleep(2000);
                    }

                    Console.Clear();
                }
                do
                {
                    Console.Clear();
                    Console.WriteLine("Welkom inkoopmederwerker\nDruk op de bijbehorende letter om naar een pagina te gaan of om uit te loggen:\n" +
                        "\n V  | Vooraad schoenen bekijken\n S  | Schoenen inkopen\nEsc | Uitloggen");

                    key = Console.ReadKey(true);
                    if (key.Key == ConsoleKey.V)
                    {
                        Console.Clear();
                        Console.WriteLine("Dit zijn de voorraden:\n");
                        Console.WriteLine("Merk: " + brand[0] + "\nType: " + type[0] + "\nMaat: 48\nKleur: Wit\nAantal: " + count[0] + " paar\nPrijs: 89, 99\n");
                        Console.WriteLine("Merk: " + brand[2] + "\nType: " + type[1] + "\nMaat: 48\nKleur: Zwart\nAantal: " + count[1] + " paar\nPrijs: 59, 99\n");
                        Console.WriteLine("Merk: " + brand[1] + "\nType: " + type[2] + "\nMaat: 48\nKleur: Zwart\nAantal: " + count[2] + " paar\nPrijs: 64, 99\n");
                        Console.WriteLine("Druk op de spatiebalk om terug te gaan.");
                        while (true)
                        {
                            ConsoleKeyInfo keyInfo = Console.ReadKey();
                            if (keyInfo.Key == ConsoleKey.Spacebar)
                            {
                                break;
                            }
                        }
                        Console.Clear();
                    }
                    else if (key.Key == ConsoleKey.S)
                    {
                        while (true)
                        {
                            Console.Clear();
                            Console.WriteLine("Hier kun je dingen inkopen. De voorraad staat tussen de haakjes.\nDruk op de letter tussen de haakjes om het item te selecteren.\n");
                            Console.WriteLine("\n[A] " + type[0] + " (" + count[0] + ")");
                            Console.WriteLine("[S] " + type[1] + " (" + count[1] + ")");
                            Console.WriteLine("[D] " + type[2] + " (" + count[2] + ")");
                            Console.WriteLine("[R] " + type[3] + " (" + count[3] + ")");
                            Console.WriteLine("\n\nDruk op de spatiebalk om terug naar het menu te gaan.");
                            ConsoleKeyInfo keyInfo = Console.ReadKey();
                            if (keyInfo.Key == ConsoleKey.A)
                            {

                                while (true)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Voer cancel in om de inkoop te annuleren.\n\nHoeveel wil je kopen?");
                                    Console.CursorVisible = true;
                                    stringCount[0] = Console.ReadLine();
                                    if (stringCount[0] == "cancel")
                                    {
                                        break;
                                    }
                                    int.TryParse(stringCount[0], out buyCount[0]);
                                    Console.CursorVisible = false;
                                    if (buyCount[0] > 0)
                                    {
                                        count[0] = count[0] + buyCount[0];
                                        break;
                                    }
                                    if (buyCount[0] < 0)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Je kan niet iets verkopen hier");
                                        Thread.Sleep(1000);
                                    }
                                    if (buyCount[0] == 0)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Je kan niet niets kopen, als je toch niets wou kopen voer dan cancel in");
                                        Thread.Sleep(3000);
                                    }

                                }
                            }
                            if (keyInfo.Key == ConsoleKey.S)
                            {

                                while (true)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Voer cancel in om de inkoop te annuleren.\n\nHoeveel wil je kopen?");
                                    Console.CursorVisible = true;
                                    stringCount[1] = Console.ReadLine();
                                    if (stringCount[1] == "cancel")
                                    {
                                        break;
                                    }
                                    int.TryParse(stringCount[1], out buyCount[1]);
                                    Console.CursorVisible = false;
                                    if (buyCount[1] > 0)
                                    {
                                        count[1] = count[1] + buyCount[1];
                                        break;
                                    }
                                    if (buyCount[1] < 0)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Je kan niet iets verkopen hier");
                                        Thread.Sleep(1000);
                                    }
                                    if (buyCount[1] == 0)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Je kan niet niets kopen, als je toch niets wou kopen voer dan cancel in");
                                        Thread.Sleep(3000);
                                    }

                                }
                            }
                            if (keyInfo.Key == ConsoleKey.D)
                            {

                                while (true)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Voer cancel in om de inkoop te annuleren.\n\nHoeveel wil je kopen?");
                                    Console.CursorVisible = true;
                                    stringCount[2] = Console.ReadLine();
                                    if (stringCount[2] == "cancel")
                                    {
                                        break;
                                    }
                                    int.TryParse(stringCount[2], out buyCount[2]);
                                    Console.CursorVisible = false;
                                    if (buyCount[2] > 0)
                                    {
                                        count[2] = count[2] + buyCount[2];
                                        break;
                                    }
                                    if (buyCount[2] < 0)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Je kan niet iets verkopen hier");
                                        Thread.Sleep(1000);
                                    }
                                    if (buyCount[2] == 0)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Je kan niet niets kopen, als je toch niets wou kopen voer dan cancel in");
                                        Thread.Sleep(3000);
                                    }

                                }
                            }
                            if (keyInfo.Key == ConsoleKey.R)
                            {

                                while (true)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Voer cancel in om de inkoop te annuleren.\n\nHoeveel wil je kopen?");
                                    Console.CursorVisible = true;
                                    stringCount[3] = Console.ReadLine();
                                    if (stringCount[3] == "cancel")
                                    {
                                        break;
                                    }
                                    int.TryParse(stringCount[3], out buyCount[3]);
                                    Console.CursorVisible = false;
                                    if (buyCount[3] > 0)
                                    {
                                        count[3] = count[3] + buyCount[3];
                                        break;
                                    }
                                    if (buyCount[3] < 0)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Je kan niet iets verkopen hier");
                                        Thread.Sleep(1000);
                                    }
                                    if (buyCount[3] == 0)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Je kan niet niets kopen, als je toch niets wou kopen voer dan cancel in");
                                        Thread.Sleep(3000);
                                    }

                                }
                            }
                            if (keyInfo.Key == ConsoleKey.Spacebar)
                            {
                                break;
                            }
                            Console.Clear();
                        }
                    }
                    else if (key.Key == ConsoleKey.Escape)
                    {
                        Console.Clear();
                        Console.WriteLine("Tot ziens");
                        Thread.Sleep(1000);
                        Environment.Exit(0);
                    }
                } while (true);
            }

        }
    }
}
