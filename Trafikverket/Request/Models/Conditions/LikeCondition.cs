using System;
using System.Collections.Generic;
using System.Text;

namespace Trafikverket.Request.Models.Conditions
{
    public class LikeCondition: GenericCondition
    {
        public LikeCondition() : base() { }
        public LikeCondition(string name, string value) : base(name, value) { }
        public LikeCondition(string name, int minutes) : base(name, minutes) { }
    }
}
