using System;
using System.Collections.Generic;
using System.Text;

namespace Trafikverket.Request.Models.Conditions
{
    public class ExistsCondition : GenericCondition
    {
        public ExistsCondition() : base() { }
        public ExistsCondition(string name, string value) : base(name, value) { }
        public ExistsCondition(string name, int minutes) : base(name, minutes) { }
    }
}
