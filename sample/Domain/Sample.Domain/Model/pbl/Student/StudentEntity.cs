using Sim.Core.Connector;
using Sim.Core.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sample.Domain.Model.pbl.Student
{
    class StudentEntity : BaseEntity
    {
        private StudentEntity()  : base()
        {
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string NationalCode { get; private set; }
        public DateTime Date { get; private set; }


        public static StudentEntity Create(Sample.Model.Dto.Student model)
        {
            if (model == null)
                throw new IndexOutOfRangeException();

            if (string.IsNullOrEmpty(model.FirstName) ||
                string.IsNullOrEmpty(model.LastName) ||
                string.IsNullOrEmpty(model.NationalCode))
                throw SimException.BadRequest(msg: "Bad Request");

            var studentEntity = New<StudentEntity, Sample.Model.Dto.Student>(model);
            //cart.Id = Guid.NewGuid();
            //cart.CustomerId = customer.Id;

            //DomainEvents.Raise<CartCreated>(new CartCreated() { Cart = cart });

            return studentEntity;
        }
    }
    public class Student1 : Sample.Model.Dto.Model
    {
        public Student1() { }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalCode { get; set; }
        public DateTime Date { get; set; }
    }

    public class Student2 : Sample.Model.Dto.Model
    {
        public Student2() { }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalCode { get; set; }
        public DateTime Date { get; set; }
    }
}
