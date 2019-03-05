using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Trafikverket.TrafficInfo.Rails.Models
{
    public class TrainMessage
    {
        [JsonProperty]
        public List<string> AffectedLocation { get; set; }

        [JsonProperty]
        public List<int> CountyNo { get; set; }

        [JsonProperty]
        public DateTime EndDateTime { get; set; }

        [JsonProperty]
        public string EventId { get; set; }

        [JsonProperty]
        public string ExternalDescription { get; set; }

        [JsonProperty]
        public string Header { get; set; }

        [JsonProperty]
        public DateTime LastUpdateDateTime { get; set; }

        [JsonProperty]
        public DateTime ModifiedTime { get; set; }

        [JsonProperty]
        public string ReasonCodeText { get; set; }

        [JsonProperty]
        public DateTime StartDateTime { get; set; }

        [JsonProperty]
        public Geometry Geometry { get; set; }

        [JsonProperty]
        public List<TrafficImpact> TrafficImpact { get; set; }

    }
}
