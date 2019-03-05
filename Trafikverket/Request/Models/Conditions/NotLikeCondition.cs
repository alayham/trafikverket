using System;
using System.Collections.Generic;
using System.Text;

namespace Trafikverket.Request.Models.Conditions
{
    public class NotLikeCondition: GenericCondition
    {
        public NotLikeCondition() : base() { }
        public NotLikeCondition(string name, string value) : base(name, value) { }
        public NotLikeCondition(string name, int minutes) : base(name, minutes) { }
    }
}
