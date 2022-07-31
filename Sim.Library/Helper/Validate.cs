using System;
using System.Collections.Generic;
using System.Text;

namespace Sim.Library.Helper
{
    public static class Validate
    {
        public static bool NullOrEmpty(this Guid identity)
        {
            if (identity == null || identity == Guid.Empty)
               return true;
            return false;
        }
    }
}
