using System.ComponentModel.DataAnnotations;
namespace todolistApp.Models;
public class Todo
{
    public int Id { get; set; }
    [Required(ErrorMessage = "Title is required")]
    public string? Title { get; set; }
    public string? Description { get; set; }
    public bool IsTaskComplete { get; set; }
}