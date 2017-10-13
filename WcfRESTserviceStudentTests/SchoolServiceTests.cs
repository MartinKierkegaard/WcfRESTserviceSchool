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
            Assert.Fail();
        }

        [TestMethod()]
        public void GetTeachersByIdTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetTeachersByNameTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetSchoolClassesByTeacherIdTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetTeachersByStudentIdTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetStudentsByTeacherIdTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void DeleteTeacherTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void AddTeacherTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void UpdateTeacherTest()
        {
            Assert.Fail();
        }
    }
}