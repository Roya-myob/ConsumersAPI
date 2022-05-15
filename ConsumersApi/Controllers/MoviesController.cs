using Microsoft.AspNetCore.Mvc;

namespace Consumers.API.Controllers
{
	[ApiController]
	[Route("[controller]")]
    public class MoviesController : Controller
    {
	    private readonly IMoviesService _moviesServices;  

		public MoviesController(IMoviesService moviesService)
	    {
		    _moviesServices = moviesService;
	    }

        public MoviesController()
        {
        }

        private static List<Movies>  movies = new List<Movies>()
		 { new Movies("Batman", 1,new Rating())};

		

		[HttpGet]
	    public async Task<IActionResult> GetAllMovies()
		{
			//movies.Count == 0 ? "We have no movie in the list :(": 
			return Ok(movies);


		}

		[HttpGet("{id}")]
		public async Task<IActionResult> GetMovieId(int id)
		{
			var movie = movies.Find(movie => movie.Id == id);
			if (movie == null)
			{
				return NotFound("Id not found");
			}
			return StatusCode((200), movie);

		}

		[HttpPost]
		public async Task<IActionResult> Post(Movies movie)
		{
			
			movies.Add(movie);
			return Created("movie.com",movies);
			

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