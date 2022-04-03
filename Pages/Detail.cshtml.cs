using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using todolistApp.Services;
using todolistApp.Models;

namespace todolistApp.Pages
{
    public class DetailModel : PageModel
    {
        [BindProperty]
        public int askedTodoId { get; set; }

        public Todo? askedTodo { get; set; }

        public void OnGet(int id)
        {
            askedTodoId = id;
            askedTodo = TodoService.GetATodo(askedTodoId);
        }


    }
}
