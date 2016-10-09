using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDB
{
    interface IDB
    {
        IUserOperation CreateUserOperation();
        IDeptOperation CreateDeptOperation();
    }
}
