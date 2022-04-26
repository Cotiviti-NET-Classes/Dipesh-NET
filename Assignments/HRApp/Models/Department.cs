using System;
using System.ComponentModel.DataAnnotations;

namespace HRApp.Models
{
	public class Department
	{
		[Key]
		public int DepartmentId { get; set; }
		[Required]
		public string DepartmentName { get; set; }

        public List<Employee>? Employees { get; set; }
    }
}

