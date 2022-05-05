using Microsoft.AspNetCore.Mvc;

namespace Consumers.API.Controllers
{
	[ApiController]
	[Route("[controller]")]
    public class UsersController : Controller
    {
		private static List<Movie>  movies = new List<Movie>()
		 { new Movie("Batman", 1)};


		[HttpGet(Name = "users")]
	    public async Task<IActionResult> Get()
		{
			return Ok(movies);

		}

		[HttpPost()]
		public async Task<IActionResult> Post(Movie movie)
		{
			movies.Add(movie);
			return Created("user.com",movies);

		}


		[HttpGet("{id}" )]
		public async Task<IActionResult> GetId(int id)
		{
			return StatusCode((200), movies.Find(movie => movie.Id == id));

		}

		
		
		[HttpDelete("{id}")]
		public async Task<IActionResult> Delete(int id)
		{
			
			var itemToRemove = movies.Find(movie => movie.Id == id);
			movies.Remove(itemToRemove);
			return StatusCode(200);
			// if (deleted != null)
			// {
			// 	return NoContent();
			// }
			// else
			// {
			// 	return NotFound();
			// }

		}


	}
}