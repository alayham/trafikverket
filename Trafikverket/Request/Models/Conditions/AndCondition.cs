using System;
using System.Collections.Generic;
using System.Text;

namespace Trafikverket.Request.Models.Conditions
{
    public class AndCondition : GenericConditionGroup
    {
        public AndCondition() : base () { }
        public AndCondition(List<QueryFilter> children) : base(children) { }
    }
}
