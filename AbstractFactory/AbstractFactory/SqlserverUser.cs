using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDB
{
    class SqlserverUser : IUserOperation
    {
        public void Insert(User user)
        {
            Console.WriteLine("在 SQL Server 中给 User 表增加一条记录");
        }

        public User GetUser(int id)
        {
            Console.WriteLine("在 SQL Server 中根据 ID 得到 User 表一条记录");
            return null;
        }
    }
}
