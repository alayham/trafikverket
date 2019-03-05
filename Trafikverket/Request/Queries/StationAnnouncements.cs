using System;
using System.Collections.Generic;
using System.Text;
using Trafikverket.Request.Models;
using Trafikverket.Request.Models.Conditions;

namespace Trafikverket.Request.Queries
{
    /// <summary>
    /// Generate trafikverket API requests for information about train arrivals and departures.
    /// </summary>
    public static class StationAnnouncements
    {
        /// <summary>
        /// Query about all station arrivals between two points in time, beween a number of minutes in the past, and a number of hours in the future.
        /// </summary>
        /// <param name="LocationSignature"> a station' location signature</param>
        /// <param name="minutesBefore">a number of minutes before now</param>
        /// <param name="hoursAfter">A number of hours</param>
        /// <returns>An API query</returns>
        public static ApiQuery StationArrivals(string LocationSignature, int minutesBefore, int hoursAfter)
        {
            return new ApiQuery()
            {
                ObjectType = "TrainAnnouncement",
                Filters = new List<QueryFilter>()
                {
                    new EqualsCondition("LocationSignature",LocationSignature),
                    new EqualsCondition("ActivityType","Ankomst"),
                    new EqualsCondition("Advertised","true"),
                    new OrCondition(new List<QueryFilter>()
                        {
                            new AndCondition(new List<QueryFilter>()
                                {
                                    new GreaterThanCondition ("AdvertisedTimeAtLocation",-minutesBefore),
                                    new LessThanCondition("AdvertisedTimeAtLocation",hoursAfter*60),
                                }
                            ),
                            new AndCondition(new List<QueryFilter>()
                                {
                                    new GreaterThanCondition("EstimatedTimeAtLocation",-minutesBefore),
                                    new LessThanCondition("EstimatedTimeAtLocation",hoursAfter*60),
                                }
                            )
                        }
                    ),
                }
            };
        }

        /// <summary>
        /// Query about all station departures between two points in time, beween a number of minutes in the past, and a number of hours in the future.
        /// </summary>
        /// <param name="LocationSignature"> a station' location signature</param>
        /// <param name="minutesBefore">a number of minutes before now</param>
        /// <param name="hoursAfter">A number of hours</param>
        /// <returns>An API query</returns>
        public static ApiQuery StationDepartures(string LocationSignature, int minutesBefore, int hoursAfter)
        {
            return new ApiQuery()
            {
                ObjectType = "TrainAnnouncement",
                Filters = new List<QueryFilter>()
                {
                    new EqualsCondition("LocationSignature",LocationSignature),
                    new EqualsCondition("ActivityType","Avgang"),
                    new EqualsCondition("Advertised","true"),
                    new OrCondition(new List<QueryFilter>()
                        {
                            new AndCondition(new List<QueryFilter>()
                                {
                                    new GreaterThanCondition ("AdvertisedTimeAtLocation",-minutesBefore),
                                    new LessThanCondition("AdvertisedTimeAtLocation",hoursAfter*60),
                                }
                            ),
                            new AndCondition(new List<QueryFilter>()
                                {
                                    new GreaterThanCondition("EstimatedTimeAtLocation",-minutesBefore),
                                    new LessThanCondition("EstimatedTimeAtLocation",hoursAfter*60),
                                }
                            )
                        }
                    ),
                }
            };
        }
    }
}
