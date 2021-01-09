using Adapter_Pattern.Adaptee;
using Adapter_Pattern.Target;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Adapter_Pattern.Adapter
{
    /// <summary>
    /// The Adapter class implements the ITarget interface and inherits the Adaptee class as well. 
    /// </summary>
    public class EmployeeAdapter : EmployeeManager, IEmployee
    {
        public override string GetAllEmployees()
        {
            // getting the result at XML first(using the adaptee method)
            string returnXml = base.GetAllEmployees();

            // creating an XML object
            XmlDocument doc = new XmlDocument();
            // adding to the xmL object the XML result we received from the base class(adaptee)
            doc.LoadXml(returnXml);

            // converting the result from XML to Json for the client
            return JsonConvert.SerializeObject(doc, Newtonsoft.Json.Formatting.Indented);
        }
    }
}
