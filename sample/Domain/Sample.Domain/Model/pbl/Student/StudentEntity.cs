using Sim.Core.Connector;
using Sim.Core.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sample.Domain.Model.pbl.Student
{
    class StudentEntity : BaseEntity
    {

        public StudentEntity(IMapService mapService):base(mapService)
        {
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string NationalCode { get; private set; }
        public DateTime Date { get; private set; }


        //public static StudentEntity Create(Sample.Model.Dto.Student model)
        //{
        //    if (model == null)
        //        throw new IndexOutOfRangeException();

        //    if (string.IsNullOrEmpty(model.FirstName) || 
        //        string.IsNullOrEmpty(model.LastName) || 
        //        string.IsNullOrEmpty(model.NationalCode))
        //            throw new IndexOutOfRangeException();

        //    StudentEntity studentEntity = new StudentEntity();
        //    //cart.Id = Guid.NewGuid();
        //    //cart.CustomerId = customer.Id;

        //    //DomainEvents.Raise<CartCreated>(new CartCreated() { Cart = cart });

        //    return studentEntity;
        //}
    }
}
