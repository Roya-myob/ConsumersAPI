namespace Consumers.API
{
    public class Movies
    {
	    public string Name { get; set; }
	    public int Id { get; set; }
	    public Rating Rating { get; set; }

		public Movies(string name, int id, Rating rating)
	    {
		    Name = name;
		    Id = id;
		    Rating = rating;
	    }
	   
    }
}
