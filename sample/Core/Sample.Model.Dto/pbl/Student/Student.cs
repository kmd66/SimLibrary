using Sim.Core.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sample.Model.Dto
{
    public class Student : BaseModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalCode { get; set; }
    }
}
