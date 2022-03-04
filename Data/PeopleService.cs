using System;
using System.Collections.Generic;
using System.Text;
using Todo_app.Models;

namespace Todo_app.Data
{
    class PeopleService
    {
        private static Person[] people = new Person[0];


        public int Size()
        {
            return people.Length;
        }
        public Person[] FindAll()
        {
            return people;
        }

        public Person FindById(int personId)
        {
            foreach (Person person in people)
            {
                if (person.Id == personId)
                {
                    return person;
                }
            }            
            return new Person(0, "", "");
        }

        public Person AddPerson(string firstName, string lastName)
        {
            Person newPerson = new Person(PersonSequencer.NextPersonId(), firstName, lastName);
            if ((newPerson.Id! > 0))
            {
                Person[] newPeople = new Person[people.Length + 1];
                people.CopyTo(newPeople, 0);
                newPeople[people.Length] = newPerson;
                people = newPeople;
            }
            return newPerson;
        }

        public void clear()
        {
            people = new Person[0];
        }
    }
}
