using EMS.Models;
using Microsoft.EntityFrameworkCore;

namespace EMS.DBContext
{
	public class EmployeeDbContext : DbContext
	{
		public EmployeeDbContext(DbContextOptions options) : base(options)
		{
		}
		public DbSet<Employee> Employee { get; set; }
	}
}
