using System;
using System.Collections.Generic;
using System.Text;

namespace Sample.Model.Data
{
    public abstract class Model
    {
        public int Id { get; set; }
        public Guid GuId { get; set; }
    }
}
