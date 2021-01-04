using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate bool delPromoted(Employee emp);
    public class DelegateEx1
    {
        public static void AddData()
        {
            List<Employee> empList = new List<Employee>();
            empList.Add(new Employee()
            { Id = 1, Name = "John", Salary = 1000, Experince = 1 });
            empList.Add(new Employee()
            { Id = 2, Name = "Mike", Salary = 5000, Experince = 5 });
            empList.Add(new Employee()
            { Id = 3, Name = "Rita", Salary = 3000, Experince = 2 });
            empList.Add(new Employee()
            { Id = 4, Name = "Bob", Salary = 8000, Experince = 6 });

            delPromoted delObj = new delPromoted(IsPromoted);
            Employee.PromoteEmployees(empList, delObj);
        }
        public static void UsingLambda()
        {
            List<Employee> empList = new List<Employee>();
            empList.Add(new Employee()
            { Id = 1, Name = "John", Salary = 1000, Experince = 1 });
            empList.Add(new Employee()
            { Id = 2, Name = "Mike", Salary = 5000, Experince = 5 });
            empList.Add(new Employee()
            { Id = 3, Name = "Rita", Salary = 3000, Experince = 2 });
            empList.Add(new Employee()
            { Id = 4, Name = "Bob", Salary = 8000, Experince = 6 });
            // Delegate using Lambda expression		
            Employee.PromoteEmployees(empList, emp => emp.Experince >= 2);
        }
        public static bool IsPromoted(Employee emp)
        {
            if (emp.Experince >= 2)
            {
                return true;
            }
            else
                return false;
        }
    }
    public class Employee
    {
        public static void PromoteEmployees(List<Employee> empList, delPromoted delObj)
        {
            foreach (var item in empList)
            {
                if (delObj(item))
                {
                    Console.WriteLine(item.Name + " promoted");
                }
            }
        }
        public int Id
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }

        public int Salary
        {
            get;
            set;
        }

        public int Experince
        {
            get;
            set;
        }

     
    }
}
