using System;
using System.Collections.Generic;
using System.Text;

namespace Sim.Helper
{
    public static class Validate
    {
        public static void NullOrEmpty(this Guid identity)
        {
            if (identity == null || identity == Guid.Empty)
                throw new Exception("The GUID needs a value");
        }
    }
}
