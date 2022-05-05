namespace Consumers.API
{
    public class Movie
    {
	    public string Name { get; set; }
	    public int Id { get; set; }

		public Movie(string name, int id)
	    {
		    Name = name;
		    Id = id;
	    }
	   
    }
}
