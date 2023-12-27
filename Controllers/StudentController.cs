using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using project.Models;
using BOL;
using BLL;
namespace project.Controllers;

public class StudentController : Controller
{
    private readonly ILogger<StudentController> _logger;

    public StudentController(ILogger<StudentController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()


    {
       studentManager smgr=new studentManager();

       List<Student> st=smgr.getStudent();

       this.ViewData["students"]=st;

        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
