using System.Diagnostics;

namespace Exercise2
{
    internal class Program
    {
        
        static void Main()
        {
            bool runProgram = true;
            string input = "";
            int age;
            int price;
            int totalPrice = 0;
        //Navigate by typing in equivalent numbers for each command
        Console.WriteLine("Välkommen till huvudmenyn! \nNavigera genom att skriva in ekvivalenta siffror för varje utförande: ");
            
            do
            {
                Console.WriteLine("\n\nHuvudmeny");
                Console.WriteLine("1: Ange Ålder För Prisgrupp (1 person)");
                Console.WriteLine("2: Räkna ut pris för sällskap");
                Console.WriteLine("3: Skriv en text som upprepas 10 gånger.");
                Console.WriteLine("4: Tredje ordet.");
                Console.WriteLine("0: Avsluta program");
                Console.Write("Input: ");
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
                input = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.

                switch (input)
                {
                    case "0":
                        Environment.Exit(0);
                        break;
                    case "1":
                        bool enterAgeMenu = true;
                        do
                        {
                            // Läser in input för ålder, ändrar pris sedan skriver ut ålder och pris för åldersgrupp
                            Console.Write("\n\nAnge ålder: ");
                            // Är åldern under 20 räknas man som ungdom. Är åldern över 64 räknas man som pensionär. Annars standard.
                            try
                            {
                                age = int.Parse(Console.ReadLine());
                                if (age < 20)
                                {
                                    price = 80;
                                    Console.WriteLine($"{age} år: Ungdom\nUngdomspris: {price}kr");
                                    enterAgeMenu = false;
                                }
                                else if (age > 64)
                                {
                                    price = 90;
                                    Console.WriteLine($"{age} år: Pensionär\nPensionärspris: {price}kr");
                                    enterAgeMenu = false;
                                }
                                else if (age >= 20 && age <= 64)
                                {

                                    price = 120;
                                    Console.WriteLine($"{age} år: Standard\nStandardspris: {price}kr");
                                    enterAgeMenu = false;
                                }
                                else
                                {
                                    Console.WriteLine("Fel inputtyp. Ange ålder igen.");
                                }
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Fel inputtyp. Försök igen.");
                            }
                            

                        } while (enterAgeMenu);
                        break;
                    case "2":
                        
                        bool companyPriceMenu = true;
                        int numberOfPeople = 0;
                        do
                        {
                            // Kollar hur många är i sällskapet. Använder en if stats för att se till att användaren använt rätt inputtyp.
                            // Kör en do while loop och en try catch så användaren återkommer ifall de inte gör så.
                            Console.Write("\n\nHur många är i sällskapet?: ");
                            try
                            {
                                numberOfPeople = int.Parse(Console.ReadLine());
                                if (numberOfPeople >= 0)
                                {
                                    for (int i = 0; i < numberOfPeople; i++)
                                    {
                                        // En till do while loop ifall användaren skriver in fel typ. 
                                        enterAgeMenu = true;
                                        do
                                        {
                                            // Använder i princip samma if statement som i case "1"
                                            Console.Write($"Person {(i + 1)} Ålder: ");
                                            try
                                            {
                                                age = int.Parse(Console.ReadLine());
                                                if (age < 20)
                                                {
                                                    totalPrice += 80;
                                                    enterAgeMenu = false;
                                                }
                                                else if (age > 64)
                                                {
                                                    totalPrice += 90;
                                                    enterAgeMenu = false;
                                                }
                                                else if (age >= 20 && age <= 64)
                                                {

                                                    totalPrice += 120;
                                                    enterAgeMenu = false;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Fel inputtyp. Ange ålder igen.");
                                                }
                                            }
                                            catch (Exception ex)
                                            {
                                                Console.WriteLine("Fel inputtyp. Ange ålder igen.");
                                            }
                                            
                                        } while (enterAgeMenu);
                                    }


                                    companyPriceMenu = false;
                                    
                                }
                                else
                                {
                                    Console.WriteLine("Fel inputtyp. Försök igen");
                                }
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Fel inputtyp. Försök igen");
                            }
                            
                        } while (companyPriceMenu);
                        Console.WriteLine($"\nAntal personer: {numberOfPeople}\nTotalt pris: {totalPrice}");
                        break;
                    case "3":
                        //Användaren skriver en text som sedan upprepas 10 gånger.
                        string text = "";
                        Console.WriteLine("\n\nSkriv en text som ska upprepas 10 gånger.");
                        Console.Write("Text: ");
                        text = Console.ReadLine();
                        for (int i= 0; i < 10; i++)
                        {
                            Console.Write(text);
                        }
                        break;
                    case "4":
                        bool thirdWordMenu = true;
                        // Samma princip som innan ifall användaren inte skriver in rätt typ.
                        do
                        {
                            Console.WriteLine("\n\nAnge en mening på minst tre ord. Programmet ska skriva ut tredje ordet tillbaka.");
                            Console.Write("Skriv en mening: ");
                            string sentenceInput = Console.ReadLine();
                            try
                            {
                                var sentence = sentenceInput.Split(' ');
                                Console.WriteLine($"Tredje ordet: {sentence[2]}");


                                thirdWordMenu = false;
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Fel input. Skriv en mening på minst tre ord");
                            }
                        } while (thirdWordMenu);
                        break;
                    default:
                        Console.WriteLine("Fel inputtyp. Försök igen.");
                        break;



                }



            } while (runProgram);
            




            Console.Read();
        }



        
    }
}
