using Microsoft.EntityFrameworkCore;
using StudentSystem.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace StudentSystem.Models
{
	public class Resource
	{
		[Key]
		public int ResourceId { get; set; }

		[Required]
		[MaxLength(50)]
		public string Name { get; set; } = null!;

		[Required]
		[Unicode(false)]   
		public string Url { get; set; } = null!;

		[Required]
		public ResourceType ResourceType { get; set; }

		public int CourseId { get; set; }

		[ForeignKey(nameof(CourseId))]
		public Course Course { get; set; } = null!;
	}
}
