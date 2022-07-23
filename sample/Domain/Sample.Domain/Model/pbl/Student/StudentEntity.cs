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
                throw SimException.BadRequest(msg: "Bad Request");

            if (string.IsNullOrEmpty(model.FirstName) ||
                string.IsNullOrEmpty(model.LastName) ||
                string.IsNullOrEmpty(model.NationalCode))
                throw SimException.BadRequest(msg: "Bad Request");

            var studentEntity = New<StudentEntity, Sample.Model.Dto.Student>(model);

            return studentEntity;
        }
    }
}
