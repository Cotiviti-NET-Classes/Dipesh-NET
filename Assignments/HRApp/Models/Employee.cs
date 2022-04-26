using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRApp.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string ContactNumber { get; set; }
        public Gender Gender { get; set; }
        [Required]
        public DateTime JoinDate { get; set; }

        public int DepartmentId { get; set; }
        public Department? Department { get; set; }

        public int DesignationId { get; set; }
        public Designation? Designation { get; set; }


    }

    public enum Gender
    {
        Male = 1,
        Female = 2,
        Others = 3,
    }

}

