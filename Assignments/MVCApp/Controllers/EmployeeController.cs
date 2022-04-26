using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVCApp.Models;
using MVCApp.Enum;

namespace MVCApp.Controllers;

public class EmployeeController : Controller
{
    public HrDbContext hrDb { get; }

    public EmployeeController(HrDbContext hrDb)
    {
        this.hrDb = hrDb;
    }
    public IActionResult Index()
    {
        // List<Employee> data = new() {
        //     new Employee { Name = "Dipesh", Gender = Enum.Gender.Male, JoiningDate = DateTime.Now},
        //     new Employee { Name = "Jidesh", Gender = Enum.Gender.Male, JoiningDate = DateTime.Now},
        //     new Employee { Name = "Suman", Gender = Enum.Gender.Male, JoiningDate = DateTime.Now},
        //     new Employee { Name = "Sarita", Gender = Enum.Gender.Female, JoiningDate = DateTime.Now},
        //     new Employee { Name = "Nirmal", Gender = Enum.Gender.Male, JoiningDate = DateTime.Now},
        //     new Employee { Name = "Nabin", Gender = Enum.Gender.Male, JoiningDate = DateTime.Now},
        // };
        return View();
    }

    public IActionResult Add()
    {
        return View();
    }

    public IActionResult Update()
    {
        return View();
    }

    public IActionResult Delete()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
