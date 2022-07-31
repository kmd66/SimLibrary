using Sim.Library.BaseModel;
using System;

namespace Sample.Model.Data
{
    public class Student : BaseModel
    {
        public Student() { }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalCode { get; set; }
        public DateTime Date { get; set; }
    }
}
