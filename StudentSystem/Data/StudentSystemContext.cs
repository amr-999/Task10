using Microsoft.EntityFrameworkCore;
using StudentSystem.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentSystem.Data
{
	public class StudentSystemContext : DbContext
	{
		public DbSet<Student> Students { get; set; }
		public DbSet<Course> Courses { get; set; }
		public DbSet<Resource> Resources { get; set; }
		public DbSet<Homework> HomeworkSubmissions { get; set; }
		public DbSet<StudentCourse> StudentCourses { get; set; }


		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			base.OnConfiguring(optionsBuilder);
			optionsBuilder.UseSqlServer("Data Source=. ; Initial Catalog = StudentSystem ;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True");
		}
	}
}
