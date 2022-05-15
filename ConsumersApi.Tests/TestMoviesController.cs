using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Consumers;
using Consumers.API;
using Consumers.API.Controllers;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using Moq;
using Xunit;

namespace Consumers.Tests
{
    public class Get_Successfull_Response
    {
        [Fact]
        public async Task Get_OnSuccess_ReturnStatusCode200()
        {
            // Arrange
            var sut = new MoviesController();

            //Act
            var result = (OkObjectResult)await sut.GetAllMovies();

            //Assert
            result.StatusCode.Should().Be(200);

        }
        // more tests 
        // what is the behaviour of our system when we try to get 
        // users from some external service 
        // our controller is going to need to make a request to some third party api
        // keep business logic separate from web layer 
        // business logic layer  becomes dependency of users controller and
        // users controller will depend on abstraction of that service layer

        [Fact]
        public async Task Get_OnSuccess_InvokesMovieService()
        {
	        // Arrange
	        var mockMoviesService = new Mock<IMoviesService>();
	        mockMoviesService.Setup(service => service.GetAllMovies())
	                         .ReturnsAsync(new List<Movies>());

            //provide mockMovieService as a dependency to MovieController
	        var sut = new MoviesController(mockMoviesService.Object);

	        //Act
	        var result = (OkObjectResult)await sut.GetAllMovies();

	        //Assert
	        

        }

        [Fact]
        public async Task Get_Movie_Name_By_Id()
        {
	        var sut = new MoviesController();

	        var result = (OkObjectResult)await sut.GetAllMovies();

	        result.StatusCode.Should().Be(200);
        }


        //test for create post
        [Fact]
        public async Task Add_New_Movie_Returns_StatusCode201()
        {
	        var sut = new MoviesController();
	        

	      // var result = (CreatedResult)await sut.Post(new Movies("SuperWoman",2,rating));
	      // var result2 = (CreatedResult)await sut.Post(new Movie);
	      // result.StatusCode.Should().Be(201);
           // result2.StatusCode.Should().Be(201);
        }
        // [Fact]
        // public async Task Delete_Movie_Return_StatusCode200()
        // {
	       //  var sut = new MoviesController();
        //
        //     var result = (OkObjectResult)await sut.Delete(2);
        //
	       //  result.StatusCode.Should().Be(200);
        // }


    

        // test for get list
        // test for add update or patch
        // test for delete record delete


    }
}