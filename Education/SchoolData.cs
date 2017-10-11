using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Education
{
    public static class SchoolData
    {
        public static List<Student> Students { get; } = 
            new List<Student>()
            {
                new Student() { MobileNo = 1234, Name = "Mads", SchoolClassId = "3a" },
                new Student() { MobileNo = 1246, Name = "Nikoline", SchoolClassId = "3a" },
                new Student() { MobileNo = 1223, Name = "Bo", SchoolClassId = "3a" },
                new Student() { MobileNo = 1289, Name = "Else", SchoolClassId = "3a" },
                new Student() { MobileNo = 1231, Name = "Ib", SchoolClassId = "3a" },
                new Student() { MobileNo = 1249, Name = "Gitte", SchoolClassId = "3a" },
                new Student() { MobileNo = 2334, Name = "Henning", SchoolClassId = "2a" },
                new Student() { MobileNo = 2346, Name = "Mette", SchoolClassId = "2a" },
                new Student() { MobileNo = 2323, Name = "Bob", SchoolClassId = "2a" },
                new Student() { MobileNo = 2389, Name = "Elvira", SchoolClassId = "2a" },
                new Student() { MobileNo = 2331, Name = "Bent", SchoolClassId = "2a" },
                new Student() { MobileNo = 2349, Name = "Sofie", SchoolClassId = "2a" },
                new Student() { MobileNo = 3334, Name = "Buster", SchoolClassId = "1b" },
                new Student() { MobileNo = 3346, Name = "Ane", SchoolClassId = "1b" },
                new Student() { MobileNo = 3323, Name = "Børge", SchoolClassId = "1b" },
                new Student() { MobileNo = 3389, Name = "Vigga", SchoolClassId = "1b" },
                new Student() { MobileNo = 3331, Name = "Viggo", SchoolClassId = "1b" },
                new Student() { MobileNo = 3349, Name = "Tove", SchoolClassId = "1b" },
            };
        public static List<Teacher> Teachers { get; } = new List<Teacher>()
        { // TODO: teachers usually have more than a single class
            new Teacher() { Name = "Martin", MobileNo = 123, SchoolClassId = "3a" },
            new Teacher() { Name = "Vibeke", MobileNo = 127, SchoolClassId = "3a" },
            new Teacher() { Name = "Anders", MobileNo = 122, SchoolClassId = "3a" },
            new Teacher() { Name = "Martin", MobileNo = 123, SchoolClassId = "2a" },
            new Teacher() { Name = "Vibeke", MobileNo = 127, SchoolClassId = "1b" },
            new Teacher() { Name = "Anders", MobileNo = 122, SchoolClassId = "1b" },
            new Teacher() { Name = "Anders", MobileNo = 122, SchoolClassId = "2a" },
            new Teacher() { Name = "Eik", MobileNo = 160, SchoolClassId = "2a" },
        };


        public static List<SchoolClass> SchoolClasses { get; set; } = new List<SchoolClass>()
        {
            new SchoolClass() { SchoolClassId = "3a", SchoolClassName = "Ro31Easj", Address = "Jernbanegade" },
            new SchoolClass() { SchoolClassId = "2a", SchoolClassName = "Ro21Easj", Address = "Elisagårdsvej" },
            new SchoolClass() { SchoolClassId = "1b", SchoolClassName = "Ro1Easj", Address = "Maglegårdsvej" },
        };
    }
}
