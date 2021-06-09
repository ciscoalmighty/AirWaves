using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace AirWaves
{
    class Company
    {
        private List<Person> Persons = new List<Person>();

        public Company()
        {

        }

        public void AddPerson(Person person)
        {
            if (person.Id == 0)
            {
                int count = Persons.Count();
                person.Id = count += 1;
            }
            Persons.Add(person);
        }

        public int Count()
        {
            return Persons.Count;
        }

        public Person At(int i)
        {
            return Persons.ElementAt(i);
        }

        public void IncreaseAllAges(int amount)
        {
            foreach (Person person in Persons)
            {
                person.Age += amount;
            }
        }
    }
}
