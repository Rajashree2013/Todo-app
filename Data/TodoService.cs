using System;
using System.Collections.Generic;
using System.Text;
using Todo_app.Models;

namespace Todo_app.Data
{
    class TodoService
    {
        private static Todo[] todo = new Todo[0];

        public int Size()
        {
            return todo.Length;
        }
        public Todo[] FindAll()
        {
            return todo;
        }

        public Todo FindById(int todoId)
        {         

            foreach (Todo checkTodo in todo)
            {
                if (checkTodo.Id == todoId)
                {
                    return checkTodo;
                }
            }
            return null;
        }

        public Todo AddTodo(string desc)
        {
            Todo newTodo = new Todo(TodoSequencer.NextTodoId(), desc, false);
            Array.Resize(ref todo, Size() + 1);
            todo[todo.Length - 1] = newTodo;
            return newTodo;
        }
        public void Clear()
        {
            todo = new Todo[0];
        }

        public Todo FindByDoneStatus(bool doneStatus)
        {
            {
                Todo foundToDo = new Todo();
                foreach (Todo checkTodo in todo)
                {
                    if (checkTodo.Done == doneStatus)
                    {
                        foundToDo = checkTodo;
                    }
                }
                return foundToDo;
            }
        }


        public Todo FindByAssignee(int personID)
        {
            Todo foundToDo = new Todo();
            foreach (Todo checkTodo in todo)
            {
                if ((checkTodo.assignee != null) && checkTodo.assignee.Id == personID)
                {
                    foundToDo = checkTodo;
                }
            }

            return foundToDo;
        }

        public Todo FindByUnAssigneeTodoItems()
        {
            Todo foundToDo = new Todo();
            foreach (Todo checkTodo in todo)
            {
                if (checkTodo.assignee == null)
                {
                    foundToDo = checkTodo;
                }
            }
            return foundToDo;
        }

        public int GetIndexForTodoId(int todoId)
        {
            for (int index = 0; index < todo.Length; index++)
            {
                if (todo[index].Id == todoId)
                {
                    return index;
                }
            }
            return todo.Length;
        }

        public bool RemoveTodo(int todoId)
        {
            int index = GetIndexForTodoId(todoId);
            if (index == todo.Length)
            {
                return false;
            }
            Array.Copy(todo, index + 1, todo, index, todo.Length - index - 1);
            Array.Resize<Todo>(ref todo, todo.Length - 1);
            return true;
        }

    }
}
