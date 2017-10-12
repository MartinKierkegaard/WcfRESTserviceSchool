using System;
using System.Collections.Generic;
using System.Linq;
using Education;

namespace WcfRESTserviceStudent
{
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

        public List<Teacher> GetAllTeachers(string nameFragment, string sort)
        {
            List<Teacher> data = SchoolData.Teachers;
            if (nameFragment != null)
                data = data.FindAll(teacher => teacher.Name.Contains(nameFragment));
            if (sort == null) return data;
            sort = sort.ToLower();
            switch (sort)
            {
                case "name":
                    data.Sort((teacher, teacher1) => teacher.Name.CompareTo(teacher1.Name));
                    return data;
                case "id":
                    data.Sort((teacher, teacher1) => teacher.Id - teacher1.Id);
                    return data;
                case "mobileno":
                    data.Sort((teacher, teacher1) => teacher.MobileNo - teacher1.MobileNo);
                    return data;
                default: return data;
            }
        }

        // TODO GetAllTeachersName, sort + remove duplicates?
        public IEnumerable<string> GetAllTeachersName()
        {
            return SchoolData.Teachers.Select(teacher => teacher.Name);
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
            return result;
        }
    }
}
