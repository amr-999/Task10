using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace StudentSystem.Models
{
	[PrimaryKey(nameof(StudentId), nameof(CourseId))]  
	public class StudentCourse
	{
		public int StudentId { get; set; }

		[ForeignKey(nameof(StudentId))]
		public Student Student { get; set; } = null!;

		public int CourseId { get; set; }

		[ForeignKey(nameof(CourseId))]
		public Course Course { get; set; } = null!;
	}
}
