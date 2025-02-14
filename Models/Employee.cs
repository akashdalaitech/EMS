using System.ComponentModel.DataAnnotations;

namespace EMS.Models
{
	public class Employee
	{
		[Key]
        public int ID { get; set; }
        public required string Name { get; set; }
        [EmailAddress]
        public required string Email { get; set; }
        public required string Address { get; set; }
        public required string Phone { get; set; }
    }
}
