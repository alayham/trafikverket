using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Trafikverket.TrafficInfo.Rails.Models
{
    public class TrafficImpact
    {

        [JsonProperty]
        public List<string> AffectedLocation { get; set; }

        [JsonProperty]
        public List<string> FromLocation { get; set; }

        [JsonProperty]
        public List<string> ToLocation { get; set; }
    }
}
