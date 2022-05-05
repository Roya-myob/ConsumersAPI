using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Consumers;
using Consumers.API.Controllers;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using Xunit;

namespace Consumers.Tests
{
    public class Get_Successfull_Response
    {
        [Fact]
        public async Task Get_Method_OnSuccess_ReturnStatusCode200()
        {
            // Arrange
            var sut = new MoviesController();

            //Act
            var result = (OkObjectResult)await sut.Get();

            //Assert
            result.StatusCode.Should().Be(200);

        }

        [Fact]
        public async Task Get_Movie_Name_By_Id()
        {
	        var sut = new MoviesController();

	        var result = (OkObjectResult)await sut.Get();

	        result.StatusCode.Should().Be(200);
        }


        //test for create post
        [Fact]
        public async Task Add_New_Movie_Returns_StatusCode201()
        {
	        var sut = new MoviesController();


	     //   var result = (CreatedResult)await sut.Post(new Movie{Name = "Batman"});
	       // var result2 = (CreatedResult)await sut.Post(new Movie { Name = "Spiderman" });

           // result.StatusCode.Should().Be(201);
           // result2.StatusCode.Should().Be(201);
        }

        /*[Fact]
        public async Task Delete_Movie_Return_StatusCode200()
        {
	        var sut = new UsersController();

	        var result = (OkObjectResult)await sut.Delete(1);

	        result.StatusCode.Should().Be(200);
        }*/


    

        // test for get list
        // test for add update or patch
        // test for delete record delete


    }
}