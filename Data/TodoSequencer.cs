using System;
using System.Collections.Generic;
using System.Text;

namespace Todo_app.Data
{
    public class TodoSequencer
    {
        private static int todoId = 0;
        public static int NextTodoId()
        {
            todoId = todoId + 1;
            return todoId;
        }

        public static void Reset()
        {
            todoId = 0;
        }
    }
}
