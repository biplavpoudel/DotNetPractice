using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using WebApplicationCoreS1.Models;

namespace WebApplicationCoreS1.Controllers
{
	[Route("api /[controller]")]
	public class PersonController : Controller
	{
		private readonly Person _defaultPerson = new Person
		{
			FirstName = "Biplav",
			LastName = "Poudel"
		};

		[HttpPatch("update")]
		public Person Patch([FromBody] JsonPatchDocument<Person> personPatch)
		{
			personPatch.ApplyTo(_defaultPerson);
			return _defaultPerson;
		}
	}
}
