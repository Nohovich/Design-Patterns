using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Adapter_Pattern.Adaptee
{
    // ??
    [Serializable]

    /// <summary>
    /// Adaptee class contains the main functionality that client is expecting.
    /// </summary>
    public class Employee
    {
        Employee() { }
        public Employee(int id, string name)
        {
            this.ID = id;
            this.Name = name;
        }
        // ??
        [XmlAttribute]
        public int ID { get; set; }
        [XmlAttribute]
        public string Name { get; set; }
    }
    public class EmployeeManager
    {
        public List<Employee> employees;
        public EmployeeManager()
        {
            employees = new List<Employee>();
            this.employees.Add(new Employee(1, "John"));
            this.employees.Add(new Employee(2, "Michael"));
            this.employees.Add(new Employee(3, "Jason"));
        }
        /// <summary>
        /// this method converts the employees list to an XML string
        /// </summary>
        /// <returns></returns>
        public virtual string GetAllEmployees()
        {
            //  we don't want the namespaces
            var emptyNamepsaces = new XmlSerializerNamespaces(new[] { XmlQualifiedName.Empty });
            // the type that this XmlSerializer will accept
            var serializer = new XmlSerializer(employees.GetType());
            // XML settings
            var settings = new XmlWriterSettings(); settings.Indent = true;
            settings.OmitXmlDeclaration = true;

            // creating StringWriter
            using (var stream = new StringWriter())

            // creating XmlWriter and passing and passing the stream and the settings
            using (var writer = XmlWriter.Create(stream, settings))
            {
                // Serializing the data
                serializer.Serialize(writer, employees, emptyNamepsaces);
                Console.WriteLine($"the result in XML: {stream}");
                return stream.ToString();
            }
        }
    }
}
