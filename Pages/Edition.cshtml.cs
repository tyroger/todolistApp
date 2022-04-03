using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using todolistApp.Models;
using todolistApp.Services;

namespace todolistApp.Pages
{
    public class EditionModel : PageModel
    {
        [BindProperty]
        public string? Id { get; set; }
        [BindProperty]
        public string? Title { get; set; }

        [BindProperty]
        public string? Description { get; set; }

        [BindProperty]
        public bool IsComplete { get; set; }

        public List<Todo>? taskList = new();

        public void OnGet()
        {
            taskList = TodoService.GetTodolist();
            taskList.Sort((x, y) => Comparer<double>.Default.Compare(y.Id, x.Id));
        }

        public ActionResult OnPost()
        {
            TodoCompletedUpdating();
            //checkListContents added to dispaly content when debug
            List<Todo> checkListContents = updateList();
            return RedirectToAction("edition");
        }

        /*
        *Update the list when adding a new todo
        */
        public List<Todo> updateList()
        {
            Todo newTask = new Todo();
            newTask.Title = Title;
            newTask.Description = Description;
            TodoService.AddNewTodo(newTask);
            return TodoService.GetTodolist();
        }

        /*
        *Update the list when the todo state changes
        * seems not working...
        */
        public List<Todo> TodoCompletedUpdating()
        {
            taskList = TodoService.GetTodolist();
            foreach (Todo task in taskList)
            {
                if (IsComplete != task.IsTaskComplete)
                {
                    TodoService.ModifyTodoStatus(task.Id);
                }
            }
            return TodoService.GetTodolist();

        }
    }
}
