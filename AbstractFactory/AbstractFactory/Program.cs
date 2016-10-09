using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDB
{
    class Program
    {
        static void Main(string[] args)
        {
            //使用抽象工厂模式,可以在工厂中生产多种产品
            User user = new User();
            Department dept = new Department();
            //如果需要更换数据库，只需要修改下面这个改为其他数据库的工厂即可
            //缺点是，当增加一个表时，需要增加表类，然后增加相关表操作类，有多少数据库就要增加多少相关表操作类
            //再然后就是要修改各个数据库工厂类，在各个工厂中增加生产操作类的方法
            IDB db = new SqlServer();
            IUserOperation userOperation = db.CreateUserOperation();
            IDeptOperation deptOperation = db.CreateDeptOperation();

            userOperation.Insert(user);
            userOperation.GetUser(1);

            deptOperation.Insert(dept);
            deptOperation.GetDepartment(2);
            Console.ReadKey();
        }
    }
}
