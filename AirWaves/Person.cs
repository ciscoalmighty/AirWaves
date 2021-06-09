using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace AirWaves
{
    class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public Person()
        {

        }
        public Person( string name, int age)
        {
            Name = name;
            Age = age;
        }

        public Person(int id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }
    }
}
