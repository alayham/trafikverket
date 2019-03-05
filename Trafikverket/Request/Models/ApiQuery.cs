using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using Trafikverket.Request.Models.Conditions;

namespace Trafikverket.Request.Models
{

    /// <summary>
    /// A trafikverket API query.
    /// Note that the API accepts multiple queries per request.
    /// Reference: https://api.trafikinfo.trafikverket.se/API/TheRequest
    /// </summary>
    [XmlRoot("QUERY")]
    public class ApiQuery
    {
        [XmlAttribute("objecttype")]
        public string ObjectType { get; set; }

        [XmlAttribute("id")]
        public string Id { get; set; }

        [XmlAttribute("limit")]
        public string Limit { get; set; }

        [XmlAttribute("orderby")]
        public string OrderBy { get; set; }

        [XmlAttribute("count")]
        public string Count { get; set; } 

        [XmlAttribute("lastmodified")]
        public string LastModified { get; set; } 

        [XmlAttribute("skip")]
        public string Skip { get; set; } 

        [XmlAttribute("includedeletedobjects")]
        public string includedeletedobjects { get; set; }

        [XmlArray("FILTER")]
        [XmlArrayItem("EQ", typeof(EqualsCondition))]
        [XmlArrayItem("EXISTS", typeof(ExistsCondition))]
        [XmlArrayItem("GT", typeof(GreaterThanCondition))]
        [XmlArrayItem("GTE", typeof(GreaterThanOrEualsCondition))]
        [XmlArrayItem("LT", typeof(LessThanCondition))]
        [XmlArrayItem("LTE", typeof(LessThanOrEqualsCondition))]
        [XmlArrayItem("LIKE", typeof(LikeCondition))]
        [XmlArrayItem("NOTLIKE", typeof(NotLikeCondition))]
        [XmlArrayItem("IN", typeof(InCondition))]
        [XmlArrayItem("NOTIN", typeof(NotInCondition))]
        [XmlArrayItem("WITHIN", typeof(WithinCondition))]
        [XmlArrayItem("AND", typeof(AndCondition))]
        [XmlArrayItem("OR", typeof(OrCondition))]
        [XmlArrayItem("ELEMENTMATCH", typeof(ElementMatchCondition))]
        public List<QueryFilter> Filters { get; set; }

    }
}