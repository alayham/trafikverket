using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Trafikverket.Request.Models.Conditions
{
    /// <summary>
    /// A generic XML generic condition
    /// Reference: https://api.trafikinfo.trafikverket.se/API/TheRequest
    /// </summary>
    public class GenericCondition : QueryFilter
    {

        [XmlAttribute("name")]
        public string Name { get; set; }

        [XmlAttribute("value")]
        public string Value { get; set; }

        public GenericCondition() { }

        /// <summary>
        /// Constructor with two strings
        /// </summary>
        /// <param name="name"></param>
        /// <param name="value"></param>
        public GenericCondition(string name, string value)
        {
            Name = name;
            Value = value;
        }

        /// <summary>
        /// Constructor with a string and an integer value, which will be converted to a relative date.
        /// Referece: 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="minutes"></param>
        public GenericCondition(string name, int minutes)
        {
            Name = name;
            Value = "$dateadd(";
            Value += minutes < 0 ? "-" : "";
            
            minutes = Math.Abs(minutes);
            int hours = minutes / 60;
            minutes = minutes % 60;
            Value += hours.ToString("D2") + ":" + minutes.ToString("D2") + ":00)";
        }
    }
}
