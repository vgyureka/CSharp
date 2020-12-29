using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class EmployeeDI
    {
        public string Name { get; set; }
        IDBAccess _DBAccess;
        public EmployeeDI(IDBAccess DBAccess)
        {
            _DBAccess = DBAccess;  
        }
    }
}
