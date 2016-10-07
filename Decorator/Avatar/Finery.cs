using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avatar
{
    class Finery : Person
    {
        protected Person person;

        public Person Decorate(Person person)
        {
            this.person = person;
            return this;
        }

        public override void Show()
        {
            if (person != null)
            {
                person.Show();
            }
        }
    }
}
