using Microsoft.EntityFrameworkCore;
namespace SchoolAppCore.Models
{
	public class SchoolContext : DbContext
	{
		public SchoolContext(DbContextOptions<SchoolContext> options) :
		base(options) {}
		public DbSet<Department> Departments { get; set; }
		public DbSet<Instructor> Instructors { get; set; }
		public DbSet<Course> Courses { get; set; }
		public DbSet<Student> Students { get; set; }
		public DbSet<Enrollment> Enrollments { get; set; }
	}

	public class Department
	{
		public int DepartmentID { get; set; }
		public string Name { get; set; }
		public decimal Budget { get; set; }
		public DateTime StartDate { get; set; }
	}

	public class Instructor
	{
		public int InstructorID { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public DateTime HireDate { get; set; }
	}

	public class Course
	{
		public int CourseID { get; set; }
		public string Title { get; set; }
		public int Credits { get; set; }
		public int DepartmentID { get; set; }
	}

	public class Student
	{
		public int StudentID { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public DateTime EnrollmentDate { get; set; }
	}

	public class Enrollment
	{
		public int EnrollmentID { get; set; }
		public int CourseID { get; set; }
		public int StudentID { get; set; }
		public decimal Grade { get; set; }
	}
}