using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryDB
{
    interface IDeptOperation
    {
        void Insert(Department department);
        Department GetDepartment(int id);
    }
}
