using todolistApp.Models;

namespace todolistApp.Services;

static class TodoService
{
    static List<Todo>? TodoList { get; set; }

    static TodoService()
    {
        TodoList = new List<Todo> {
            new Todo{Id=1, Title = "Toulouse", Description = "visite de la ville rose", IsTaskComplete = false},
            new Todo{Id=2, Title = "code", Description = "apprendre le c#", IsTaskComplete = true},
        };
    }

    public static List<Todo>? GetTodolist() { return TodoList; }

    public static Todo GetATodo(int id)
    {
        List<Todo>? list = GetTodolist();
        foreach (Todo todo in list)
        {
            if (todo.Id == id)
            {
                return todo;
            }
        }
        //return an Error 404?
        return null;
    }

}