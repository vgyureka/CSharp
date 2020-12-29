using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    interface IGet
    {
        string ConC(string s1, string s2);
    }
    class clsFirst : IGet
    {
        public string ConC(string s1, string s2)
        {
            string Final = "From First: " + s1 + " and " + s2;
            return Final;
        }
    }

    class clsSecond : IGet
    {
        public string ConC(string s1, string s2)
        {
            string Final = "From Second: " + s1 + " and " + s2;
            return Final;
        }
    }

    class clsFactory
    {
        static public IGet CreateandReturnObj(int cChoice)
        {
            IGet ObjSelector = null;

            switch (cChoice)
            {
                case 1:
                    ObjSelector = new clsFirst();
                    break;
                case 2:
                    ObjSelector = new clsSecond();
                    break;
                default:
                    ObjSelector = new clsFirst();
                    break;
            }
            return ObjSelector;

        }
    }



}
