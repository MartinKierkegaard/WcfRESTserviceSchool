using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Education;

namespace WcfRESTserviceStudent
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class SchoolService : ISchoolService
    {
        /// <summary>
        /// An example for a method returning data about the school classes
        /// GET method
        /// </summary>
        /// <param name="value">schoolclassid</param>
        /// <returns>a list of all school classes</returns>
        public List<SchoolClass> GetSchoolClassData()
        {
            return SchoolData.SchoolClasses;
        }

        public List<Teacher> GetAllTeachers()
        {
            return SchoolData.Teachers;
        }

        public IEnumerable<Teacher> GetTeachersById(string id)
        {
            int idInt = int.Parse(id);
            return SchoolData.Teachers.FindAll(teacher => teacher.Id == idInt);
        }

        // TODO GetTeachersByName case sensitive or not?
        public IEnumerable<Teacher> GetTeachersByName(string nameFragment)
        {
            return SchoolData.Teachers.FindAll(teacher => teacher.Name.Contains(nameFragment));
        }

        public IEnumerable<SchoolClass> GetSchoolClassesByTeacherId(string id)
        {
            int idInt = Int32.Parse(id);
            var result = from cl in SchoolData.SchoolClasses
                join te in SchoolData.Teachers on cl.SchoolClassId equals te.SchoolClassId
                where te.Id == idInt
                select cl;
                //select new {cl.SchoolClassId, cl.Address, cl.SchoolClassName};
            return result;
        }


        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }


    }
}
