using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApplicationModels;
using Microsoft.AspNetCore.Mvc.RazorPages;

public class RegisterModel : PageModel
{

    // Connect Database
    private  readonly AppDbContext _context; 
    public RegisterModel(AppDbContext context)
    {
        _context =context;
    }
    // Binding Property 
    [BindProperty]
    public string Name { get; set; }
[BindProperty]
    public string Address { get; set; }
[BindProperty]
    public DateTime? Date { get; set; }
[BindProperty]
    public string Gender { get; set; }
   
    public IActionResult OnPost()
    {


        var student= new Student
        {
            Name = Name,
            Address = Address,
            Date = Date,
            Gender = Gender,

        }; 

        // Save Records
       
        _context.Students.Add(student);
        _context.SaveChanges();
        // Redirect to Page
        return RedirectToPage("Students");
    }
    
}