using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace StudentSystem.Models
{
	public class Student
	{
		[Key]
		public int StudentId { get; set; }

		[Required]
		[MaxLength(100)]
		public string Name { get; set; } = null!;

		[MaxLength(10)]
		[Unicode(false)]          
		public string? PhoneNumber { get; set; }   

		[Required]
		public DateTime RegisteredOn { get; set; }

		public DateTime? Birthday { get; set; }    
		public ICollection<StudentCourse> StudentCourses { get; set; } = new HashSet<StudentCourse>();
		public ICollection<Homework> HomeworkSubmissions { get; set; } = new HashSet<Homework>();
	}
}
