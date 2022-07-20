using System;
using System.Collections.Generic;
using System.Text;

namespace Sample.Model.Dto
{
    public abstract class Model
    {
        public int Id { get; set; }
        public Guid UnicId { get; set; }
    }
}
