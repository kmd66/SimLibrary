using System;
using System.Collections.Generic;
using System.Text;

namespace Sim.Core.Model
{
    public class BaseListVM
    {
        public int? PageSize { get; set; }

        public int? PageIndex { get; set; }
    }
}
