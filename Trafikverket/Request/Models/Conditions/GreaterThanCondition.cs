using System;
using System.Collections.Generic;
using System.Text;

namespace Trafikverket.Request.Models.Conditions
{
    public class GreaterThanCondition : GenericCondition
    {
        public GreaterThanCondition() : base() { }
        public GreaterThanCondition(string name, string value) : base(name, value) { }
        public GreaterThanCondition(string name, int minutes) : base(name, minutes) { }
    }
}
