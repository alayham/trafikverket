using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using Trafikverket.Request.Models;
using Trafikverket.Request.Models.Conditions;

namespace Trafikverket.Request.Queries
{
    /// <summary>
    /// Generate Trafikverket API requests for information about train stations
    /// </summary>
    public static class StationList 
    {
        /// <summary>
        /// Query about all active stations
        /// </summary>
        /// <returns>An Api query</returns>
        public static ApiQuery AllActiveStations()
        {
            return new ApiQuery()
            {
                ObjectType = "TrainStation",
                OrderBy = "LocationSignature ASC",
                Filters = new List<QueryFilter>()
                {
                    new EqualsCondition("Advertised","true"),
                    new EqualsCondition("Prognosticated","true"),
                },
            };
        }

        /// <summary>
        /// Query about all active Swedish stations
        /// </summary>
        /// <returns>An Api query</returns>
        public static ApiQuery AllActiveSwedenStations()
        {
            ApiQuery All = AllActiveStations();
            All.Filters.Add(new EqualsCondition("CountryCode", "SE"));
            return All;
        }
    }
}
