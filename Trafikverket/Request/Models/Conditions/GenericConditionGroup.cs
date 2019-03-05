using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Trafikverket.Request.Models.Conditions
{
    /// <summary>
    /// A generic condition group (And, Or, ElementMatch)
    /// </summary>
    public class GenericConditionGroup : QueryFilter
    {
        [XmlElement("EQ", typeof(EqualsCondition))]
        [XmlElement("EXISTS", typeof(ExistsCondition))]
        [XmlElement("GT", typeof(GreaterThanCondition))]
        [XmlElement("GTE", typeof(GreaterThanOrEualsCondition))]
        [XmlElement("LT", typeof(LessThanCondition))]
        [XmlElement("LTE", typeof(LessThanOrEqualsCondition))]
        [XmlElement("LIKE", typeof(LikeCondition))]
        [XmlElement("NOTLIKE", typeof(NotLikeCondition))]
        [XmlElement("IN", typeof(InCondition))]
        [XmlElement("NOTIN", typeof(NotInCondition))]
        [XmlElement("WITHIN", typeof(WithinCondition))]
        [XmlElement("AND", typeof(AndCondition))]
        [XmlElement("OR", typeof(OrCondition))]
        [XmlElement("ELEMENTMATCH", typeof(ElementMatchCondition))]
        public List<QueryFilter> Children { get; set; }

        public GenericConditionGroup() { }
        public GenericConditionGroup(List<QueryFilter> children)
        {
            Children = children;
        }
    }
}
