using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDB
{
    class AccessUser : IUserOperation
    {
        public void Insert(User user)
        {
            Console.WriteLine("在 Access 中给 User 表增加一条记录");
        }

        public User GetUser(int id)
        {
            Console.WriteLine("在 Access 中根据 ID 得到 User 表一条记录");
            return null;
        }
    }
}
