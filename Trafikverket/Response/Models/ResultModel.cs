using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using Trafikverket.TrafficInfo.Rails.Models;

namespace Trafikverket.Response.Models
{
    public class ResultModel
    {
        [JsonProperty]
        public List<TrainStation> TrainStation ;

        [JsonProperty]
        public List<TrainAnnouncement> TrainAnnouncement;

        [JsonProperty]
        public List<TrainMessage> TrainMessage;
    }
}
