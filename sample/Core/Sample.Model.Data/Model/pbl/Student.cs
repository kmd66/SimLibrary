﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Sample.Model.Data
{
    public class Student : Model
    {
        public Student() { }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalCode { get; set; }
        public DateTime Date { get; set; }
    }
}