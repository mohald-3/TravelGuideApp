using System.Text.Json;
using Spectre.Console;
using Figgle;
using System;


namespace TravelGuideApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string TravelDataJSONfilePath = "cities.json";
            string AllTravelDataJSONfilePathTyp = File.ReadAllText(TravelDataJSONfilePath);
            TravelData travelData = JsonSerializer.Deserialize<TravelData>(AllTravelDataJSONfilePathTyp)!;
            Console.OutputEncoding = System.Text.Encoding.UTF8;


            while (true)
            {

                Console.WriteLine("====================================");
                Console.WriteLine("      WELCOME TO TRAVELGUIDE!       ");
                Console.WriteLine("====================================");
                Console.WriteLine();
                Console.WriteLine("  🛫 WHERE DO YOU WANT TO DEPART FROM?  ");


                var cities = new[] { "Stockholm", "Oslo", "Berlin", "Köpenhamn", "Paris" };
              
                var departureCity = AnsiConsole.Prompt(
                    new SelectionPrompt<string>()
                        .Title("Choose your [green]starting city[/]:")
                        .PageSize(5)
                        .AddChoices(cities)
                );

                Console.WriteLine($"\nYou selected: {departureCity}");
                Console.WriteLine("\n🛬 Where is your arrival?\n");


                // Use SelectionPrompt to select the destination city
                var destinationCity = AnsiConsole.Prompt(
                    new SelectionPrompt<string>()
                        .Title("Choose your [blue]destination city[/]:")
                        .PageSize(5)
                        .AddChoices(cities)
                        .MoreChoicesText("[grey](Move up and down to reveal more cities)[/]")
                        .UseConverter(city => city == departureCity ? $"{city} (Starting Point)" : city) // Highlight selected start city
                );

                // Display travel summary
                Console.WriteLine($"\nCalculating the best route from {departureCity} to {destinationCity}...");

                
            }
           
        }


    }

}


