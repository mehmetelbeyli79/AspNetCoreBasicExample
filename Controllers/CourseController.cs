
using basics.Models;
using Microsoft.AspNetCore.Mvc;

namespace basics.Controllers;

public class CourseController : Controller
{


    public IActionResult List()
    {
        /*var kurslar = new List<Course>(){
            new Course(){Id=1,Title="ASP.NET Core Kursu",Description="Güzel Bir Kurs",Image="1.jpg"},
            new Course(){Id=2,Title="PHP Kursu",Description="Güzel Bir Kurs",Image="2.jpg"},
            new Course(){Id=3,Title="Node JS Kursu",Description="Güzel Bir Kurs",Image="3.jpg"}
        };*/

        return View(Repository.courses);
    }

    public IActionResult Details(int id)
    {
        var kurs = Repository.GetById(id);
        return View(kurs);
    }

}