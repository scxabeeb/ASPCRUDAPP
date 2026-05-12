using Microsoft.AspNetCore.Mvc.RazorPages;

public class StudentModel : PageModel
{
    // connect database 
    private readonly AppDbContext _context;

    public StudentModel(AppDbContext context)
    {
        _context=context;
    }

    // property

    public List<Student> arday {get; set;}

    public void OnGet()
    {
        arday=_context.Students.ToList();
    }

}