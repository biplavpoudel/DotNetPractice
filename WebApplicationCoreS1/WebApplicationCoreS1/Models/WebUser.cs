using System.ComponentModel.DataAnnotations;
using System.Net.Mail;

namespace WebApplicationCoreS1.Models
{
	public class WebUser
	{
		[Required(ErrorMessage ="You must enter a value for First Name field!")]
		[StringLength(10, ErrorMessage = "Name must be no longer than 10 characters!")]
		[Display(Name = "First Name")]      //data annotations to add metadata to properties in a class
		public string? FirstName { get; set; }

		//[Display(Name = "Last Name")]
		[Required(ErrorMessage = "You must enter a value for Last Name field!")]
		[StringLength(50, MinimumLength=3, ErrorMessage ="Last Name should be in between 3 and 50 characters long!")]
		public string? LastName { get; set; }

		[Required(ErrorMessage = "You must enter a value for email field!")]
		[EmailAddress(ErrorMessage ="Please enter a vaid email address!")]
		[Display(Name = "Email")]
		public string? MailAddress { get; set; }
	}
}
