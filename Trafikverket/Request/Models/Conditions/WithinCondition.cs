using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Trafikverket.Request.Models.Conditions
{
    public class WithinCondition : GenericCondition
    {
        [XmlAttribute("shape")]
        public string Shape { get; set; }
    }
}
