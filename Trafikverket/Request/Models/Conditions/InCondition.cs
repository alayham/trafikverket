using System;
using System.Collections.Generic;
using System.Text;

namespace Trafikverket.Request.Models.Conditions
{
    public class InCondition : GenericCondition
    {
        public InCondition() : base() { }
        public InCondition(string name, string value) : base(name, value) { }
        public InCondition(string name, int minutes) : base(name, minutes) { }
    }
}
