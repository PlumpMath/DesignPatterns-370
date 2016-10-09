using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDB
{
    class SqlServer : IDB
    {
        public IUserOperation CreateUserOperation()
        {
            return new SqlserverUser();
        }


        public IDeptOperation CreateDeptOperation()
        {
            return new SqlserverDept();
        }
    }
}
