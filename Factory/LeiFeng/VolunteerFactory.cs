using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeiFeng
{
    class VolunteerFactory : IFactory
    {
        public LeiFeng CreateLeiFeng()
        {
            return new Volunteer();
        }
    }
}
