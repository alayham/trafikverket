using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Trafikverket.Request.Models;
using Trafikverket.Request.Queries;
using Newtonsoft.Json;
using Trafikverket.TrafficInfo.Rails.Models;
using Trafikverket.Response;
using System.Diagnostics;

namespace Trafikverket.Client
{
    /// <summary>
    /// A basic client for the trafikverket API
    /// </summary>
    public class TrafikVerketClient
    {
        private static readonly HttpClient http = new HttpClient();
        private static string ApiKey;
        private static readonly string ApiEndPoint = "http://api.trafikinfo.trafikverket.se/v1.3/data.json";

        /// <summary>
        /// An API key is required to send requests to the Trafikverket API. you can get a key from
        /// https://api.trafikinfo.trafikverket.se/Account/Register
        /// </summary>
        /// <param name="apiKey">Your own API key</param>
        public TrafikVerketClient (string apiKey)
        {
            ApiKey = apiKey;
        }

        /// <summary>
        /// Get all train stations in Sweden. 
        /// Note that the results of this function can be cached by your app.
        /// </summary>
        /// <returns>A list of train stations</returns>
        public List<TrainStation> getAllActiveSwedishStations()
        {
            ApiRequest request = new ApiRequest(ApiKey);
            request.Query.Add( StationList.AllActiveSwedenStations());
            string response = ApiCall(request).Result;
            TrafikVerketResponse responseJson = JsonConvert.DeserializeObject<TrafikVerketResponse>(response) ;
            List<TrainStation> ret = responseJson.RESPONSE.RESULT[0].TrainStation;
            return (ret);
        }

        /// <summary>
        /// Get all train arrivals to a station.
        /// The query is limited two time points, one should be in the past, or at least now, and the second should be in the future. 
        /// 
        /// </summary>
        /// <param name="LocationSignature">The location signature of a station</param>
        /// <param name="MinutesBefore">The number of minutes before now, default is 15 minutes </param>
        /// <param name="hoursAfter">the number of hours after now, default is 12 hours</param>
        /// <returns>A list of train announcements</returns>
        public List<TrainAnnouncement> getStationArrivals(string LocationSignature, int MinutesBefore = 15, int hoursAfter = 12)
        {
            ApiRequest request = new ApiRequest(ApiKey);
            request.Query.Add(StationAnnouncements.StationArrivals(LocationSignature,MinutesBefore, hoursAfter));
            string response = ApiCall(request).Result;
            TrafikVerketResponse responseJson = JsonConvert.DeserializeObject<TrafikVerketResponse>(response);
            List<TrainAnnouncement> ret = responseJson.RESPONSE.RESULT[0].TrainAnnouncement;
            return (ret);
        }

        /// <summary>
        /// Get all train departures to a station.
        /// The query is limited two time points, one should be in the past, or at least now, and the second should be in the future. 
        /// 
        /// </summary>
        /// <param name="LocationSignature">The location signature of a station</param>
        /// <param name="MinutesBefore">The number of minutes before now, default is 15 minutes </param>
        /// <param name="hoursAfter">the number of hours after now, default is 12 hours</param>
        /// <returns>A list of train announcements</returns>
        public List<TrainAnnouncement> getStationDepartures(string LocationSignature, int MinutesBefore = 15, int hoursAfter = 12)
        {
            ApiRequest request = new ApiRequest(ApiKey);
            request.Query.Add(StationAnnouncements.StationDepartures(LocationSignature, MinutesBefore, hoursAfter));
            string response = ApiCall(request).Result;
            TrafikVerketResponse responseJson = JsonConvert.DeserializeObject<TrafikVerketResponse>(response);
            List<TrainAnnouncement> ret = responseJson.RESPONSE.RESULT[0].TrainAnnouncement;
            return (ret);
        }

        /// <summary>
        /// Get all messages for a station
        /// </summary>
        /// <param name="LocationSignature">The station's location Signature</param>
        /// <returns>A list of train messages</returns>
        public List<TrainMessage> getStationMessages(string LocationSignature)
        {
            ApiRequest request = new ApiRequest(ApiKey);
            request.Query.Add(StationMessages.MessageList(LocationSignature));
            string response = ApiCall(request).Result;
            TrafikVerketResponse responseJson = JsonConvert.DeserializeObject<TrafikVerketResponse>(response);
            List<TrainMessage> ret = responseJson.RESPONSE.RESULT[0].TrainMessage;
            return (ret);
        }

        /// <summary>
        /// An Asynchromous API call to trafikverket.
        /// For the request documentation, please refer to:
        /// https://api.trafikinfo.trafikverket.se/API/TheRequest
        /// for the response documentation please refer to:
        /// https://api.trafikinfo.trafikverket.se/API/TheResponse
        /// </summary>
        /// <param name="request">An API request object, which will serialized to xml and sent as the body of the call</param>
        /// <returns>The body of the response</returns>
        private async Task<string> ApiCall(ApiRequest request)
            {
                HttpContent body = new StringContent(request.AsXml());
                HttpResponseMessage response = await http.PostAsync(ApiEndPoint, body);
                String responseString = await response.Content.ReadAsStringAsync();
                return responseString;
            }
        }
}
