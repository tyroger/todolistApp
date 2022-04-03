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

        public List<Todo>? taskList = new();

        public void OnGet()
        {
            taskList = TodoService.GetTodolist();



        }
    }
}
