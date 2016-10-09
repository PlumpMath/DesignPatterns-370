using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDB
{
    class Access : IDB
    {
        public IUserOperation CreateUserOperation()
        {
            return new AccessUser();
        }


        public IDeptOperation CreateDeptOperation()
        {
            return new AccessDept();
        }
    }
}
