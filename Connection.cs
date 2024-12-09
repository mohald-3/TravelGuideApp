using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelGuideApp
{
    public class Connection
    {
       public string Distination {  get; set; }
        public int Distance { get; set; }
        public int Time { get; set; }
        public int Cost { get; set; }
        public string TravelMethod { get; set; }
        public Connection(string distination, int distance, int time, int cost, string travelMethod) 
        {
            Distination = distination;
            Distance = distance;
            Time = time;
            Cost = cost;
            TravelMethod = travelMethod;
        }

    }
}
