using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

public class EditModel : PageModel
{
    private readonly AppDbContext _context;
    public EditModel(AppDbContext context)
    {
        _context = context;
    }

[BindProperty]
    public Student User {get;set;}

    public void OnGet(int id)
    {
        User = _context.Students.Find(id);
    }

    public IActionResult OnPost()
    {


        _context.Students.Update(User);
        _context.SaveChanges();
        // Redirect to Page
        return RedirectToPage("Students");
    }

}