using Delegates.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Delegates
{
    /// <summary>
    /// Func is a generic delegate included in the System namespace. 
    /// 1. It has zero or more input parameters and one out parameter. 
    /// 2. The last parameter is considered as an out parameter.
    /// </summary>
    internal class FuncDelegate
    {
        public static void MainFunc()
        {
            List<Employees> empList = new List<Employees>()
            {
                new Employees{ Id = 1, Name = "aBC", DeptName = "it", Salary = 1000 },
                new Employees{ Id = 2, Name = "zBC", DeptName = "acc", Salary = 2000 },
                new Employees{ Id = 3, Name = "xBC", DeptName = "dev", Salary = 3000 },
                new Employees{ Id = 4, Name = "vBC", DeptName = "qa", Salary = 4000 }
            };
            List<Department> deptList = new List<Department>()
            {
                new Department{Id=1,DeptName="it1",Location="delhi"},
                new Department{Id=2,DeptName="it3",Location="pun"},
                new Department{Id=3,DeptName="it2",Location="chandi"}
            };
            Func<Employees, string> selector = myFunc;
            IEnumerable<string> result = empList.Select(selector);
            // using lambda
            Func<Employees, string> selector1 = x => x.Name + " Lamda";
            IEnumerable<string> result1 = empList.Select(selector1);

            Action<string> print = msg => Console.WriteLine(msg);
            print("success");
            //func delegate with more than 1 input params
            Func<List<Employees>, List<Department>, bool> multiFunc = (emp, dept) =>
             {
                 return emp.Any(e => dept.Any(d => d.DeptName == e.DeptName));
             };
            bool ifDept = multiFunc(empList, deptList);
        }

        public static string myFunc(Employees emp)
        {
            return emp.Name + " test";
        }
    }
}
