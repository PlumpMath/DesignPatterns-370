using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace ReflectionFactory
{
    class DataAccess
    {
        private static readonly string AssemblyName = "ReflectionFactory";
        private static readonly string db = ConfigurationManager.AppSettings["DB"];

        public static IUserOperation CreateUserOperation()
        {
            string className = AssemblyName + "." + db + "User";
            return (IUserOperation)Assembly.Load(AssemblyName).CreateInstance(className);
        }

        public static IDeptOperation CreateDeptOperation()
        {
            string className = AssemblyName + "." + db + "Dept";
            return (IDeptOperation)Assembly.Load(AssemblyName).CreateInstance(className);
        }
    }
}
