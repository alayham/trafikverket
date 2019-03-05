using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Trafikverket.TrafficInfo.Rails.Models
{
    public class TrainStation
    {
        [JsonProperty]
        public bool Advertised{ get; set; }

        [JsonProperty]
        public string AdvertisedLocationName{ get; set; }

        [JsonProperty]
        public string AdvertisedShortLocationName{ get; set; }

        [JsonProperty]
        public string CountryCode{ get; set; }

        [JsonProperty]
        public int[] CountyNo{ get; set; }

        [JsonProperty]
        public string LocationSignature{ get; set; }

        [JsonProperty]
        public DateTime ModifiedTime{ get; set; }

        [JsonProperty]
        public List<string> PlatformLine{ get; set; }

        [JsonProperty]
        public bool Prognosticated{ get; set; }

        [JsonProperty]
        public Geometry Geometry { get; set; }
    }
}
