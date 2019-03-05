using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Trafikverket.TrafficInfo.Rails.Models
{
    public class Location
    {

        [JsonProperty]
        public string LocationName { get; set; }

        [JsonProperty]
        public int Order { get; set; }

        [JsonProperty]
        public int Priority { get; set; }
    }
}
