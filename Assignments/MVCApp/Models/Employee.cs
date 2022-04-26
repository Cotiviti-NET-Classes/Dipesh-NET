using System.ComponentModel.DataAnnotations;
using MVCApp.Enum;

namespace MVCApp.Models;

public class Employee
{
    [Key]
    public int Id { get; set; }
    [Required, MinLength(6)]
    public string Name { get; set; }
    [Required]
    public string ContactNumber { get; set; }
    public DateTime JoiningDate { get; set; }
    public Gender Gender { get; set; }
}