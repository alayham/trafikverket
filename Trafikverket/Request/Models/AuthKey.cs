using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Trafikverket.Request.Models
{
    /// <summary>
    /// This class exists to enable successful XML serialization of the API request
    /// according to trafikverket API documentation. 
    /// Reference:  https://api.trafikinfo.trafikverket.se/API/TheRequest
    /// </summary>
    public class AuthKey
    {
        [XmlAttribute("authenticationkey")]
        public string Key { get; set; }

        private AuthKey()
        {

        }

        public AuthKey (string key)
        {
            Key = key;
        }
    }
}
