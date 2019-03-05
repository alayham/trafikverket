using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Trafikverket.Response.Models
{
    public class ResponseModel
    {
        [JsonProperty]
        public List<ResultModel> RESULT = new List<ResultModel>();
    }
}
