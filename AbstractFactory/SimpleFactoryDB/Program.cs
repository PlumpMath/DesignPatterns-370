using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryDB
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            Department dept = new Department();

            IUserOperation userOperation = DataAccess.CreateUserOperation();
            IDeptOperation deptOperation = DataAccess.CreateDeptOperation();

            userOperation.Insert(user);
            userOperation.GetUser(3);

            deptOperation.Insert(dept);
            deptOperation.GetDepartment(4);
        }
    }
}
