using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternCSharp
{
    class Person
    {
        public string name;
        public int age;
        public string address;

        public void Show()
        {
            Console.WriteLine("Name: " + name + " Age: " + age + " Address: " + address);
        }
    }
    class PersonBuilder
    {
        private Person p = new Person();
        public PersonBuilder SetName(string name)
        {
            p.name = name;
            return this;
        }

        public PersonBuilder SetAge(int age)
        {
            p.age = age;
            return this;
        }

        public PersonBuilder SetAddress(string address)
        {
            p.address = address;
            return this;
        }

        public Person Build()
        {
            return p;
        }


    }
}
