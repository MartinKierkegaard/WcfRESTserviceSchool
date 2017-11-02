using System.Runtime.Serialization;

namespace Education
{
    [DataContract]
    public class Teacher : Person
    {
        //private static int _nextId = 1;

        //public Teacher()
        //{
        //    Id = _nextId++;
        //}

        [DataMember]
        public int? Salary { get; set; }
    }
}
