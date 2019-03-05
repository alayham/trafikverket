using System;
using System.Collections.Generic;
using System.Text;

namespace Trafikverket.Request.Models.Conditions
{
    public class OrCondition : GenericConditionGroup
    {
        public OrCondition() : base() { }
        public OrCondition(List<QueryFilter> children) : base(children) { }
    }
}
