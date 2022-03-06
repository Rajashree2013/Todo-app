using System;
using System.Collections.Generic;
using System.Text;

namespace Todo_app.Models
{
    public class Todo
    {
        // Variable declaration 
        private int id;
        private string description;
        private bool done;
        public Person assignee;

        public Todo()
        { }

        public Todo(int id)
        {
            this.id = id;
        }
        public Todo(Person assignee)
        {
            this.assignee = assignee;
        }

        public Todo(int id, string description)
        {
            this.id = id;
            this.description = description;
        }

        public Todo(int id, string description, bool done)
        {
            this.done = done;
            this.id = id;
            this.description = description;
        }

        public Todo(int id, string description, bool done, Person person)
        {
            this.done = done;
            this.id = id;
            this.description = description;
            this.assignee = person;
        }


        public string Description
        {
            get { 
                return description;
            }
            set
            {                
                description = value;
            }
        }
        public bool Done
        {
            get {
                return done;
            }
            set { 
                done = value; 
            }
        }

        public int Id
        {
            get { return id; }
            set
            {
                if (id < 1)
                {
                    throw new ArgumentOutOfRangeException("ID can not be less than 1 !!");
                }
                id = value;
            }
        }
    }
}
