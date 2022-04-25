using MVCApp.Enum;

namespace MVCApp.Models;

public class Employee
{

    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime JoiningDate { get; set; }
    public Gender Gender { get; set; }
}