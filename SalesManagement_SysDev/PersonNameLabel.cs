using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagement_SysDev
{

    public class PersonNameLabel : System.Windows.Forms.Label, Listener
    {

        private Person person;

        public Person addPerson(Person person)
        {

            if (person == null)
            {

                throw new Exception("引数が null です！");

            }

            this.person = person;

            person.addListener(this);

            if (person == null)
            {

                throw new Exception("返却値が null です！");

            }

            return person;

        }

        public void update()
        {

            Text = person.getName();

        }

    }

}
