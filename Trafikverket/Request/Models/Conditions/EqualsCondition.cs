using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Trafikverket.Request.Models.Conditions
{

    [XmlRoot("EQ")]
    [Serializable]
    public class EqualsCondition : GenericCondition
    {
        public EqualsCondition() : base() { }
        public EqualsCondition(string name, string value) : base(name, value) { }
        public EqualsCondition(string name, int minutes) : base(name, minutes) { }

    }
}
