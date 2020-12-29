using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Reflection;

namespace CSharp
{
    public static class Extensions
    {
        public static bool IN(this string sourceString, params string[] argsList)
        {
            argsList.ToList().RemoveAll(x => string.IsNullOrEmpty(x));

            if (!string.IsNullOrEmpty(sourceString) && argsList.Length > 0)
            {
                if (argsList.Any(x => x.Trim().Equals(sourceString.Trim(), StringComparison.CurrentCultureIgnoreCase)))
                    return true;
                else
                    return false;
            }
            return false;
        }

        public static bool AND(this string sourceString, params string[] argsList)
        {
            argsList.ToList().RemoveAll(x => string.IsNullOrEmpty(x));

            if (!string.IsNullOrEmpty(sourceString) && argsList.Length > 0)
            {
                if (argsList.All(x => x.Trim().Equals(sourceString.Trim(), StringComparison.CurrentCultureIgnoreCase)))
                    return true;
                else
                    return false;
            }
            return false;
        }
        public static DataTable RemoveDuplicateRows(this DataTable dTable, string colName)
        {
            Hashtable hTable = new Hashtable();
            ArrayList duplicateList = new ArrayList();

            //Add list of all the unique item value to hashtable, which stores combination of key, value pair.
            //And add duplicate item value in arraylist.
            foreach (DataRow drow in dTable.Rows)
            {
                if (hTable.Contains(drow[colName]))
                    duplicateList.Add(drow);
                else
                    hTable.Add(drow[colName], string.Empty);
            }

            //Removing a list of duplicate items from datatable.
            foreach (DataRow dRow in duplicateList)
                dTable.Rows.Remove(dRow);

            //Datatable which contains unique records will be return as output.
            return dTable;
        }

        public static string ToFullName(this Enum value)
        {
            FieldInfo field = value.GetType().GetField(value.ToString());
            DescriptionAttribute attribute = Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute)) as DescriptionAttribute;
            return attribute == null ? value.ToString() : attribute.Description;
        }
        public static string ToName(this Enum value)
        {
            FieldInfo field = value.GetType().GetField(value.ToString());
            DefaultValueAttribute attribute = Attribute.GetCustomAttribute(field, typeof(DefaultValueAttribute)) as DefaultValueAttribute;
            return attribute == null ? value.ToString() : attribute.Value.ToString();
        }
    }
}
