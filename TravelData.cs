﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace TravelGuideApp
{
    public class TravelData
    {
        [JsonPropertyName("cities")]
        public List<Cities> AllTravelDataJson { get; set; } = new List<Cities>();

    }
}
