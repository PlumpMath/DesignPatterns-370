using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDB
{
    class AccessDept : IDeptOperation
    {
        public void Insert(Department department)
        {
            Console.WriteLine("在 Access 中给 Department 表增加一条记录");
        }

        public Department GetDepartment(int id)
        {
            Console.WriteLine("在 Access 中根据 ID 得到 Department 表一条记录");
            return null;
        }
    }
}
