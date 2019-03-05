using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using Trafikverket.Response.Models;

namespace Trafikverket.Response
{
    public class TrafikVerketResponse
    {
        [JsonProperty]
        public ResponseModel RESPONSE { get; set; }
    }
}
