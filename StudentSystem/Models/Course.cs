using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace StudentSystem.Models
{
	public class Course
	{
		[Key]
		public int CourseId { get; set; }

		[Required]
		[MaxLength(80)]
		public string Name { get; set; } = null!;

		public string? Description { get; set; }

		[Required]
		public DateTime StartDate { get; set; }

		[Required]
		public DateTime EndDate { get; set; }

		[Required]
		public decimal Price { get; set; }

		public ICollection<StudentCourse> StudentCourses { get; set; } = new HashSet<StudentCourse>();
		public ICollection<Resource> Resources { get; set; } = new HashSet<Resource>();
		public ICollection<Homework> HomeworkSubmissions { get; set; } = new HashSet<Homework>();
	}
}
