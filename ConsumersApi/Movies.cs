namespace Consumers.API
{
    public class Movies
    {
	    public string Name { get; set; }
	    public int Id { get; set; }

		public Movies(string name, int id)
	    {
		    Name = name;
		    Id = id;
	    }
	   
    }
}
