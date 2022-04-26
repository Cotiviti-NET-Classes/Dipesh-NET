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
        [Required]
        public DateTime JoinDate { get; set; }
        [ForeignKey("Dept")]
        public int DeptID { get; set; }
        [ForeignKey("Designations")]
        public int DesignationID { get; set; }


        public virtual Department Dept { get; set; }
        public virtual Designation Designations { get; set; }
    }

}

