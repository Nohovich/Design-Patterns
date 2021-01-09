using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Pattern.Target
{
    /// <summary>
    /// ITarget here represents an interface created to make client achieve its purpose.
    /// </summary>
    public interface IEmployee
    {
        string GetAllEmployees();
    }
}
