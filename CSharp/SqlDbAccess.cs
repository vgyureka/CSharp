using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class SQLDataAccess : IDBAccess
    {

        public string _connection;

        public string Connection
        {
            get
            {
                return "test connection";
            }
            set
            {
                _connection = value;
            }
        }

    }
}
