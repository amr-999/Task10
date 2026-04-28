using Microsoft.EntityFrameworkCore;
using StudentSystem.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace StudentSystem.Models
{
	public class Homework
	{
		[Key]
		public int HomeworkId { get; set; }

		[Required]
		[Unicode(false)]   
		public string Content { get; set; } = null!;

		[Required]
		public ContentType ContentType { get; set; }

		[Required]
		public DateTime SubmissionTime { get; set; }

		public int StudentId { get; set; }

		[ForeignKey(nameof(StudentId))]
		public Student Student { get; set; } = null!;

		public int CourseId { get; set; }

		[ForeignKey(nameof(CourseId))]
		public Course Course { get; set; } = null!;
	}
}
