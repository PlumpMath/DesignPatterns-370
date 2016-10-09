using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionFactory
{
    class Program
    {
        
        static void Main(string[] args)
        {
            User user = new User();
            IUserOperation userOperation= DataAccess.CreateUserOperation();
            userOperation.Insert(user);
            userOperation.GetUser(4);

            Department dept = new Department();
            IDeptOperation deptOperation = DataAccess.CreateDeptOperation();
            deptOperation.Insert(dept);
            deptOperation.GetDepartment(5);

            Console.ReadKey();

        }
    }
}
