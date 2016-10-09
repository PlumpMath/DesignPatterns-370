using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryDB
{
    class DataAccess
    {
        //private static readonly string db = "Sqlserver";
        //如果需要更换数据库，需要更改这一句并在各个 switch语句中添加数据库 case
        private static readonly string db = "Access";
        public static IUserOperation CreateUserOperation()
        {
            IUserOperation userOperation = null;
            switch (db)
            {
                case "Sqlserver":
                    userOperation = new SqlserverUser();
                    break;
                case "Access":
                    userOperation = new AccessUser();
                    break;
            }
            return userOperation;
        }

        public static IDeptOperation CreateDeptOperation()
        {
            IDeptOperation deptOperation = null;
            switch(db)
            {
                case "Sqlserver":
                    deptOperation = new SqlserverDept();
                    break;
                case "Access":
                    deptOperation = new AccessDept();
                    break;
            }
            return deptOperation;
        }
    }
}
