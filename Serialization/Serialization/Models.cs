using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace Serialization
{
    [Serializable]
    public class Student
    {
        public string Firstname     { get; set; }
        public string Lastname      { get; set; }
        public int    Age           { get; set; }
        [XmlElement("StudentCard")]
        public StudentCard SCard    { get; set; }
    }

    [Serializable]
    public class StudentCard
    {
        public string Number { get; set; }
        [XmlElement(DataType = "date")]
        public DateTime? DateOfIssuance { get; set; }
    }
}
