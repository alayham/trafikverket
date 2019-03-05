using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Trafikverket.TrafficInfo.Rails.Models
{
    public class Geometry
    {
        [JsonProperty]
        public string SWEREF99TM { get; set; }

        [JsonProperty]
        public string WGS84 { get; set; }

    }
}
