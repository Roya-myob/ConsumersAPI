using System;
using Consumers.API;

public interface IMoviesService
{
	public Task<List<Movies>> GetAllMovies();
}

public class MoviesService : IMoviesService
{
	public Task<List<Movies>> GetAllMovies() => throw new NotImplementedException();
}
