using System.Text.Json;

namespace TravelGuideApp
{
     class Program
    {
        static void Main(string[] args)
        {
            string TravelDataJSONfilePath = "cities.json";
            string AllTravelDataJSONfilePathTyp = File.ReadAllText(TravelDataJSONfilePath);
            TravelData travelData = JsonSerializer.Deserialize<TravelData>(AllTravelDataJSONfilePathTyp)!;
             
        }
     }
}
