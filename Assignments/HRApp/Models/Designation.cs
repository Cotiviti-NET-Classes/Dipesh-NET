using System;
using System.ComponentModel.DataAnnotations;

namespace HRApp.Models
{
    public class Designation
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string DesignationName { get; set; }
    }
}

