using System;
using System.Collections.Generic;
using System.Text;
using Todo_app.Models;

namespace Todo_app.Data
{
    class PeopleService
    {
        // Declaration person array with static and not null
        private static Person[] people = new Person[0];

        //Return length of the array
        public int Size()
        {
            return people.Length;
        }

        //Return person array
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
            return null;
        }

        public Person AddNewPerson(string firstName, string lastName)
        {
            Person newPerson = null;

            if(!firstName.Equals("") && !firstName.Equals(null) && !lastName.Equals("") && !lastName.Equals(null))
            {
                newPerson = new Person(PersonSequencer.NextPersonId(), firstName, lastName);
                Array.Resize(ref people, Size()+1);
                people[people.Length - 1] = newPerson;
            }
            return newPerson;
        }
       
        public void clear()
        {
            people = new Person[0];
        }

        public int GetIndexForPersonId(int personId)
        {
            for (int index = 0; index < people.Length; index++)
            {
                if (people[index].Id == personId)
                {
                    return index;
                }
            }
            return people.Length;
        }

        public bool RemovePerson(int personId)
        {
            int index = GetIndexForPersonId(personId);
            if (index == people.Length)
            {
                return false;
            }
            Array.Copy(people, index + 1, people, index, people.Length - index - 1);
            Array.Resize<Person>(ref people, people.Length - 1);
            return true;
        }
    }
}
