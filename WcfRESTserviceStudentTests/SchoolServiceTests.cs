using System.Collections.Generic;
using Education;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WcfRESTserviceStudent.Tests
{
    [TestClass]
    public class SchoolServiceTests
    {
        [TestMethod]
        public void GetSchoolClassDataTest()
        {

        }

        [TestMethod()]
        public void GetAllTeachersTest()
        {
            ISchoolService service = new SchoolService();
            List<Teacher> teachers = service.GetAllTeachers(null, null);
            Assert.IsTrue(teachers.Count > 0);
        }

        [TestMethod()]
        public void GetAllTeachersNameTest()
        {
            // TODO test
        }

        [TestMethod()]
        public void GetTeachersByIdTest()
        {
            // TODO test
        }

        [TestMethod()]
        public void GetTeachersByNameTest()
        {
            // TODO test
        }

        [TestMethod()]
        public void GetSchoolClassesByTeacherIdTest()
        {
            // TODO test
        }

        [TestMethod()]
        public void GetTeachersByStudentIdTest()
        {
            // TODO test
        }

        [TestMethod()]
        public void GetStudentsByTeacherIdTest()
        {
            // TODO test
        }

        [TestMethod()]
        public void DeleteTeacherTest()
        {
            // TODO test
        }

        [TestMethod]
        public void AddTeacherTest()
        {
            ISchoolService service = new SchoolService();
            List<Teacher> teachers = service.GetAllTeachers(null, null);
            int count = teachers.Count;
            service.AddTeacher(new Teacher { Id = 123, Name = "Zimba" });
            teachers = service.GetAllTeachers(null, null);
            int newCount = teachers.Count;
            Assert.AreEqual(count + 1, newCount);
        }

        [TestMethod]
        public void UpdateTeacherTest()
        {
            ISchoolService service = new SchoolService();
            Teacher teacher1 = service.GetTeacherById("1");

            Teacher newInfo = new Teacher {Salary = 123456};
            service.UpdateTeacher("1", newInfo);
            Teacher teacher1b = service.GetTeacherById("1");
            Assert.AreEqual(teacher1.Id, teacher1b.Id);
            Assert.AreEqual(teacher1.Name, teacher1b.Name);
            Assert.AreEqual(teacher1.MobileNo, teacher1b.MobileNo);
            Assert.AreEqual(123456, teacher1b.Salary);
        }
    }
}