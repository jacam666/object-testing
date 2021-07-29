using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace object_testing.People
{
    public class Person
    {
        public string Name;
        public int age;
        public bool HasPet;

        public void Greeting()
        {
            Console.WriteLine("hi  my name is " + Name + ", my age is " + age + " and has a pet is " + HasPet);
        }
    }
}
