using System;
using System.Collections.Generic;
using System.Text;

namespace Trafikverket.Request.Models.Conditions
{
    public class NotInCondition: GenericCondition
    {
        public NotInCondition() : base() { }
        public NotInCondition(string name, string value) : base(name, value) { }
        public NotInCondition(string name, int minutes) : base(name, minutes) { }
    }
}
