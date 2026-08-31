using Microsoft.AspNetCore.Mvc;

namespace TeamGitPractice.Controllers;

[ApiController]

[Route("api/[controller]")]

public class MembersController : ControllerBase

{

	[HttpGet]

	public IActionResult GetMembers()

	{

		var members = new[]

		{

"Jordan del Aguila",

"Brayan Florez",

"Juan Mosquera",

"Juan Londoño",

"Samuel Maya"

};

	}

return Ok(members);

	[HttpGet("count")]

	public IActionResult GetCount()

	{

		return Ok(new { total = 5 });

	}

}