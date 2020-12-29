using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public static class IenumeratorDemo
    {

        public static void EnumFunc()
        {

            List<string> Month = new List<string>();
            Month.Add("January");
            Month.Add("February");
            Month.Add("March");
            Month.Add("April");
            Month.Add("May");
            Month.Add("June");
            Month.Add("July");
            Month.Add("August");
            Month.Add("September");
            Month.Add("October");
            Month.Add("November");
            Month.Add("December");
            //IENUMERATOR MAINTAINS THE CURSOR'S CURRENT STATE WHILE IENUMERABLE DONT
            IEnumerator<string> EnumString = Month.GetEnumerator();
            IEnumerable<string> EnumerableString = Month;
            iEnumeratorMethodOne(EnumString);
            iEnumerableOne(EnumerableString);

            IquerableDemo(Month);
        }

      

        public static void iEnumeratorMethodOne(IEnumerator<string> i)
        {
            while (i.MoveNext())
            {
                Console.WriteLine(i.Current);

                if (i.Current == "June")
                {
                    iEnumeratorMethodTwo(i);
                }
            }
        }

        public static void iEnumeratorMethodTwo(IEnumerator<string> i)
        {
            while (i.MoveNext())
            {
                Console.WriteLine(i.Current);
            }
        }
        ///	IEnumerable is best to query data from in-memory collections like List, Array etc.
        ///While query data from database, IEnumerable execute select query on server side, load data in-memory on client side and then filter data.
        ///IEnumerable doesn’t support lazy loading. Hence not suitable for paging like scenarios.

        public static void iEnumerableOne(IEnumerable<string> i)
        {
            foreach (string AllMonths in i)
            {
                Console.WriteLine(AllMonths);

                if (AllMonths == "June")
                {
                    iEnumerableTwo(i);
                }
            }
        }

        public static void iEnumerableTwo(IEnumerable<string> i)
        {
            foreach (string AllMonths in i)
            {
                Console.WriteLine(AllMonths);
            }
        }
        /// <summary>
        /// IQueryable is best to query data from out-memory (like remote database, service) collections.
        ///	While query data from database, IQueryable execute select query on server side with all filters.
        ///	IQueryable support lazy loading. Hence it is suitable for paging like scenarios.
        /// </summary>
        private static void IquerableDemo(List<string> month)
        {
            IQueryable<string> list = month.Where(x => x.StartsWith("J")).AsQueryable();
            list=list.Take<string>(2);

        }
      
       
    }

}

