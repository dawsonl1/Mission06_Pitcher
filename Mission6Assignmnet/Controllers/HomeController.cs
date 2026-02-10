using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Mission6Assignmnet.Models;

namespace Mission6Assignmnet.Controllers;

public class HomeController : Controller
{
    private MovieRecordContext _context;  // Declaring the object I will later use to interact with the Database
    
    public HomeController(MovieRecordContext movieRecordContext) // ASP.NET will create the MovieRecordContext object dependency automatically when it creates the controller with the blueprint found in the Program.cs at: builder.Services.AddDbContext<MovieRecordContext>(...
    {
        _context = movieRecordContext;
    }
    
    public IActionResult Index()  // This is the homepage
    {
        return View();
    }
    
    public IActionResult AboutJoel() // Navigate to the About Joel Page
    {
        return View();
    }
    
    public IActionResult Baconsale() // Redirect to Baconsale website
    {
        return Redirect("https://baconsale.com/");
    }

    public IActionResult QuickWitsComedy()
    {
        return Redirect("https://www.qwcomedy.com/");
    }
    
    public IActionResult AddMovies() // Navigate to the Add Movies to the Database Page
    {
        return View();
    }
    
    [HttpPost]
    public IActionResult AddMovie(MovieRecord movieRecord)
    {
        if (movieRecord.Edited == null)
        {
            movieRecord.Edited = false;
        }
        _context.Add(movieRecord);
        _context.SaveChanges();
        TempData["Message"] = "Movie Added Successfully";
        return RedirectToAction("AddMovies");
    }


}