using System;
using System.Collections.Generic;
using System.Text;

namespace Todo_app.Models
{
    public class Person
    {
        private int id;
        private String firstName;
        private String lastName;

        public Person(int id, string firstName, string lastName)
        {
            if ((!firstName.Equals(null) && !firstName.Equals("") && !lastName.Equals(null) && !lastName.Equals("")) || (id > 0))
            {
                this.id = id;
                this.firstName = firstName;
                this.lastName = lastName;
            }

        }
        public int Id {
            get => id;
        }
        public string FirstName {
            get => firstName;
            set
            {
                if (!value.Equals(null) && !value.Equals(""))
                {
                    firstName = value;
                }
            }
        }
        public string LastName
        {
            get => lastName;
            set
            {
                if (!value.Equals(null) && !value.Equals(""))
                {
                    lastName = value;
                }
            }
        }

        public string Name
        {
            get => $"{firstName} {lastName}";
        }

    }
}
