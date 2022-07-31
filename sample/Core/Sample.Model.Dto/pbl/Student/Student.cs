using Sim.Library.BaseModel;

namespace Sample.Model.Dto
{
    public class Student : BaseModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalCode { get; set; }
    }
}
