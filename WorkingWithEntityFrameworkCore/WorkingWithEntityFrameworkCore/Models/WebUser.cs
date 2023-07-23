using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WorkingWithEntityFrameworkCore.Models
{
	public class WebUser
	{
		[Column("UserID")]
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int UserID { get; set; }

		[Display(Name = "First Name")]
		[Required]
		[StringLength(25)]
		public string FirstName { get; set;}

		[Required]
		[StringLength(25),MinLength(3)]
		[Display(Name = "Last Name")]
		public string LastName { get; set;}

		public string Email { get; set;}

	}
}
