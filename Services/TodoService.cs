using todolistApp.Models;

namespace todolistApp.Services;

static class TodoService
{
    static List<Todo>? TodoList { get; set; }

    static TodoService()
    {
        TodoList = new List<Todo> {
            new Todo{Id=1, Title = "toto", Description = "ange", IsTaskComplete = false},
            new Todo{Id=2, Title = "daoa", Description = "oddo", IsTaskComplete = true},
        };
    }

    public static List<Todo>? GetTodolist() { return TodoList; }

}