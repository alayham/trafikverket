using System;
using System.Collections.Generic;
using System.Text;

namespace Trafikverket.Request.Models.Conditions
{
    public class LessThanOrEqualsCondition : GenericCondition
    {
        public LessThanOrEqualsCondition() : base() { }
        public LessThanOrEqualsCondition(string name, string value) : base(name, value) { }
        public LessThanOrEqualsCondition(string name, int minutes) : base(name, minutes) { }
    }
}
