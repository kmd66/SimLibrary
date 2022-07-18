using System;
using System.Collections.Generic;
using System.Text;

namespace Sample.Model.Db
{
    public class Student : Model
    {
        public Student() { }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Date { get; set; }
    }
}
