using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDB
{
    interface IDeptOperation
    {
        void Insert(Department department);
        Department GetDepartment(int id);
    }
}
