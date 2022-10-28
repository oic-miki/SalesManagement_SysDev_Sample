using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagement_SysDev
{

    public class PersonAgeLabel : System.Windows.Forms.Label, Listener
    {

        private Person person;

        public PersonAgeLabel()
        {

            Text = "";

        }

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

            int age = person.getAge();
            if (age > 0)
            {

                Text = age.ToString();

            }
            else
            {

                Text = "";

            }

        }

    }

}
