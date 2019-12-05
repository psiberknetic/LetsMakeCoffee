using System;
using System.Collections.Generic;
using System.Text;

namespace LMC.Common
{
    public class Deal : IHasId<Guid>
    {
        public Guid Id => throw new NotImplementedException();
        public string Code => throw new NotImplementedException();
    }
}
