using System;
using System.Collections.Generic;
using System.Text;

namespace Sample.Model.Db
{
    public abstract class Model
    {
        public int Id { get; set; }
        public Guid GuId { get; set; }
    }
}
