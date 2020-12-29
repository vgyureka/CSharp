using ConsoleApplication1;
using CSharp;
using Microsoft.Practices.Unity.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace ConsoleApplication1
{
    class Employee
    {
        public string Name { get; set; }
        public List<string> Skills { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose topic: ");
            Console.WriteLine("1. Lazy Singleton");
            Console.WriteLine("2. Value - param type");
            Console.WriteLine("3. ref - param type");
            Console.WriteLine("4. out - param type");
            Console.WriteLine("5. params array - param type");
            Console.WriteLine("6. named - param type");
            Console.WriteLine("7. default - param type");

            Console.WriteLine("Please choose topic: ");
            int choice = Convert.ToInt16(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    LazySingletonFunc();
                    break;
                case 2:
                    ParameterTypes.ValueType();
                    break;
                case 3:
                    ParameterTypes.RefType();
                    break;
                case 4:
                    ParameterTypes.OutType();
                    break;
                case 5:
                    ParameterTypes.ParamsType();
                    break;
                case 6:
                    ParameterTypes.NamedType();
                    break;
                case 7:
                    ParameterTypes.DefaultType();
                    break;
                default: break;
            }


            DuplicateVal();
            OverloadTest.func(5);
            //IENUMERATOR DEMO
            IenumeratorDemo.EnumFunc();
            //DI USING UNITY =======
            var container = new UnityContainer();
            container.RegisterType<IDBAccess, SQLDataAccess>();
            EmployeeDI emp = container.Resolve<EmployeeDI>();

            //========DI END========
            //  var container = new UnityContainer();
            //var section = (UnityConfigurationSection)ConfigurationManager.GetSection("unity");
            //section.Containers.Default.Configure(container);

            //if (ConfigurationManager.GetSection("unity") != null)
            //{
            //    container.LoadConfiguration();

            //    Console.WriteLine();
            //    Console.WriteLine("After loading the config file:");
            //    EmployeeDI emp = container.Resolve<EmployeeDI>();

            //}

            LinqDemo();
            DelegateDemo.PredicateDemo();
            DelegateDemo.ActionDemo();
            DelegateDemo.FuncDemo();

            //  Test1 obj = new Test1("");
            //obj.func2();
            //Test1.func2();
            FactoryMethod();
            //Select_VS_SelectMany();
            //Singleton();
            // DelegatesFunc();
        }

        private static void DuplicateVal()
        {
            List<int> lst = new List<int>();
            Dictionary<int, int> dict = new Dictionary<int, int>();

            int count = 0;
            int[] arr = { 1, 3, 6, 3, 4, 5, 10, 5, 5, 7, 5 };
            var result = arr.OrderBy(x => x).ToList();
            for (int i = 0; i < result.Count; i++)
            {
                if (result[i] == result[i + 1])
                {
                    lst.Add(result[i]);
                    dict.Add(result[i], count);
                    count++;
                }
                else
                {
                    count = 0;
                }
            }
        }

        private static void LinqDemo()
        {
            //union or except or intersect
            int[] numbers = { 1, 2, 3, 4, 5 };
            int[] numbers1 = { 4, 5, 6, 6, 7, 8, 9, 10 };
            //union two list without duplicates
            var nn1 = numbers.Union(numbers1);
            //return common items from 2 lists
            var nn2 = numbers.Intersect(numbers1);
            //return elemets from list1 that r not present in 2nd list
            var nn3 = numbers.Except(numbers1);

            //any or all
            string[] names = { "abc", "zxc", "fgh" };
            string[] namesAll = { "abc", "abc", "abc" };

            var a = names.Any(x => x == "zxc");
            var b = namesAll.All(x => x == "abc");
            var c = names.Contains("abc");

            //first and single
            List<int> lstCount = new List<int> { 10, 20, 30, 40, 50, 60, 70, 80, 90 };
            var result = lstCount.First(x => x > 10);
            var result1 = lstCount.FirstOrDefault();
            var result3 = lstCount.SingleOrDefault(x => x < 20);
            var result2 = lstCount.Single(x => x > 10);


        }

        private static void DelegatesFunc()
        {
            DelegatesDemo obj = new DelegatesDemo();
            TestDel td = obj.AddNums;
            td(1, 2, 3);
            SayDel sd = DelegatesDemo.SayHello;
            sd("VISHU");


        }

        private static void Singleton()
        {
            SingleTonSample.InstanceCreation();
            SingleTonSample.InstanceCreation();
            Console.ReadLine();
            //throw new NotImplementedException();
        }


        //Diff select and select many
        private static void Select_VS_SelectMany()
        {
            List<Employee> employees = new List<Employee>();
            Employee emp1 = new Employee { Name = "Deepak", Skills = new List<string> { "C", "C++", "Java" } };
            Employee emp2 = new Employee { Name = "Karan", Skills = new List<string> { "SQL Server", "C#", "ASP.NET" } };

            Employee emp3 = new Employee { Name = "Lalit", Skills = new List<string> { "C#", "ASP.NET MVC", "Windows Azure", "SQL Server" } };

            employees.Add(emp1);
            employees.Add(emp2);
            employees.Add(emp3);

            // Query using Select()
            IEnumerable<List<String>> resultSelect = employees.Select(e => e.Skills);

            Console.WriteLine("**************** Select ******************");

            // Two foreach loops are required to iterate through the results
            // because the query returns a collection of arrays.
            foreach (List<String> skillList in resultSelect)
            {
                foreach (string skill in skillList)
                {
                    Console.WriteLine(skill);
                }
                Console.WriteLine();
            }

            // Query using SelectMany()
            IEnumerable<string> resultSelectMany = employees.SelectMany(emp => emp.Skills);

            Console.WriteLine("**************** SelectMany ******************");

            // Only one foreach loop is required to iterate through the results 
            // since query returns a one-dimensional collection.
            foreach (string skill in resultSelectMany)
            {
                Console.WriteLine(skill);
            }

            Console.ReadKey();
        }

        //Factory design pattern
        private static void FactoryMethod()
        {
            int i = 0;
            IGet ObjIntrface = null;
            ObjIntrface = clsFactory.CreateandReturnObj(i + 1);
            string res = ObjIntrface.ConC("First", "Second");
            i++;

        }

        //lazy singletion
        private static void LazySingletonFunc()
        {
            LazySingleton obj = LazySingleton.SingleInstance;
            LazySingleton obj1 = LazySingleton.SingleInstance;
            if (obj == obj1)
            {

            }
        }

    }
}
