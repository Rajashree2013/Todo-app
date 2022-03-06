using System;
using System.Collections.Generic;
using System.Text;


namespace Todo_app.Data
{
    public class PersonSequencer
    {
        private static int personId=0;
        public static int NextPersonId()
        {
            personId = personId + 1;
            return personId;
        }

        public static void Reset()
        {
            personId = 0;
        }
    }
}
