using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagement_SysDev
{
    public class Person
    {

        private String name;
        private int age;

        private List<Listener> listeners = new List<Listener>();

        public Person()
        {

            setName("");
            setAge(0);

        }

        public Person(String name, int age)
        {

            setName(name);
            setAge(age);

        }

        public String getName()
        {

            return name;

        }

        public String setName(String name)
        {

            this.name = name;

            notify();

            return name;

        }

        public int getAge()
        {

            return age;

        }

        public int setAge(int age)
        {

            this.age = age;

            notify();

            return age;

        }

        public Listener addListener(Listener listener)
        {

            listeners.Add(listener);


            return listener;

        }

        public void notify()
        {

            foreach(Listener listener in listeners)
            {

                listener.update();

            }

        }

    }
}
