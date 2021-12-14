using Microsoft.AspNetCore.Mvc;
using JobBoard.Models;

namespace JobBoard.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View(JobOpening.GetAll());
    }

    [HttpGet("/new")]
    public ActionResult CreateJob()
    {
      return View();
    }

    [HttpPost("/")]
    public ActionResult AddJobOpening(string title, string description, string name, string email, string phone)
    {
      Contact newContact = new Contact(name, email, phone);
      JobOpening newJobOpening = new JobOpening(title, description, newContact);
      return RedirectToAction("Index");
    }

    [HttpGet("/clear")]
    public ActionResult ClearJobs()
    {
      JobOpening.ClearAll();
      return RedirectToAction("Index");
    }
  }
}