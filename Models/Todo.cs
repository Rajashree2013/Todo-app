using System;
using System.Collections.Generic;
using System.Text;

namespace Todo_app.Models
{
    class Todo
    {
        private int id;
        private string description;
        private bool done;
        private Person assignee;


        public Todo(int id, string description)
        {
           this.id = id;
           this.description = description;
        }

        public int Id
        { 
            get => id;
        }
        
        public string Description
        {
            get { 
                return description; 
            }
            set
            {
                if (!value.Equals(null) && !value.Equals(""))
                {
                    description = value;
                }
            }
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

        public Todo()
        {
            
        }

        public bool Done
        {
            get { return done; }
        }

        public Todo(Person assignee)
        {
            this.assignee = assignee;
        }

    }
}
