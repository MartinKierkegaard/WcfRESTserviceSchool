using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using Education;

namespace WcfRESTserviceStudent
{
    [ServiceContract]
    public interface ISchoolService
    {
        /// <summary>
        /// An example for a method returning data about the school classes
        /// </summary>
        /// <returns>a list of all school classes</returns>
        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "classes")]
        List<SchoolClass> GetSchoolClassData();

        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "teachers?name={namefragment}&sort={sort}")]
        // https://stackoverflow.com/questions/21623432/how-to-pass-multiple-parameter-in-wcf-restful-service
        List<Teacher> GetAllTeachers(string nameFragment, string sort);

        // Not legal: endpoints are consideres equal when they only differ by ?name=val
        //[OperationContract]
        //[WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json,
        //    UriTemplate = "teachers?name={nameFragment}")]
        //IEnumerable<Teacher> GetTeachersByName(string nameFragment);

        // Alternative to teachers?name={namefragment}&sort={sort}
        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "teachers/name")]
        IEnumerable<string> GetAllTeachersName();

        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "teachers/{id}")]
        IEnumerable<Teacher> GetTeachersById(string id);
        /// <summary>
        /// Alternative to teachers?name={namefragment}&amp;sort={sort}
        /// </summary>
        /// <param name="nameFragment"></param>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "teachers/name/{namefragment}")]
        IEnumerable<Teacher> GetTeachersByName(string nameFragment);

        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "teachers/{id}/classes")]
        IEnumerable<SchoolClass> GetSchoolClassesByTeacherId(string id);

        [OperationContract]
        [WebInvoke(Method = "DELETE", ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "teachers/{id}")]
        Teacher DeleteTeacher(string id);

        // TODO POST, PUT
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
