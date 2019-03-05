using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Trafikverket.TrafficInfo.Rails.Models
{
    public class TrainAnnouncement
    {
        [JsonProperty]
        public string ActivityId { get; set; }

        [JsonProperty]
        public string ActivityType { get; set; }

        [JsonProperty]
        public bool Advertised { get; set; }

        [JsonProperty]
        public DateTime AdvertisedTimeAtLocation { get; set; }

        [JsonProperty]
        public string AdvertisedTrainIdent { get; set; }

        [JsonProperty]
        public string[] Booking { get; set; }

        [JsonProperty]
        public bool Canceled { get; set; }

        [JsonProperty]
        public bool Deleted { get; set; }

        [JsonProperty]
        public string Deviation { get; set; }

        [JsonProperty]
        public DateTime EstimatedTimeAtLocation { get; set; }

        [JsonProperty]
        public bool EstimatedTimeIsPreliminary { get; set; }

        [JsonProperty]
        public string InformationOwner { get; set; }

        [JsonProperty]
        public string LocationSignature { get; set; }

        [JsonProperty]
        public string MobileWebLink { get; set; }

        [JsonProperty]
        public DateTime ModifiedTime { get; set; }

        [JsonProperty]
        public int NewEquipment { get; set; }

        [JsonProperty]
        public string[] OtherInformation  { get; set; }

        [JsonProperty]
        public DateTime PlannedEstimatedTimeAtLocation { get; set; }

        [JsonProperty]
        public bool PlannedEstimatedTimeAtLocationIsValid  { get; set; }

        [JsonProperty]
        public string[] ProductInformation  { get; set; }

        [JsonProperty]
        public DateTime ScheduledDepartureDateTime { get; set; }

        [JsonProperty]
        public string[] Service { get; set; }

        [JsonProperty]
        public string TechnicalTrainIdent { get; set; }

        [JsonProperty]
        public DateTime TimeAtLocation { get; set; }

        [JsonProperty]
        public string TrackAtLocation { get; set; }

        [JsonProperty]
        public string[] TrainComposition  { get; set; }

        [JsonProperty]
        public string TypeOfTraffic { get; set; }

        [JsonProperty]
        public string WebLink  { get; set; }

        [JsonProperty]
        public string WebLinkName  { get; set; }

        [JsonProperty]
        public List<Location> FromLocation { get; set; }

        [JsonProperty]
        public List<Location> ToLocation { get; set; }

        [JsonProperty]
        public List<Location> ViaFromLocation { get; set; }

        [JsonProperty]
        public List<Location> ViaToLocation { get; set; }
    }
}
