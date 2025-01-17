
using LatijnLogic.DTOs;
using Microsoft.AspNetCore.Mvc.Testing;
using System.Net.Http.Json;

namespace LatijnIntegrationTest
{
    public class IntegrationTests : IClassFixture<WebApplicationFactory<Program>>
    {
        private readonly WebApplicationFactory<Program> _factory;

        public IntegrationTests(WebApplicationFactory<Program> factory)
        {
            _factory = factory;
        }

        [Theory]
        [InlineData("/api/Uitgangen")]
        [InlineData("/api/Werkwoorden")]
        public async Task GET_RequestsAllSuccessfulResponse(string url)
        {
            //Arrange
            var client = _factory.CreateClient();
            //Act
            var response = await client.GetAsync(url);
            //Assert
            Assert.True(response.IsSuccessStatusCode);
        }

        [Fact]
        public async Task POST_CreateToets_ReturnsValidId()
        {
            //Arrange
            var client = _factory.CreateClient();
            string url = "/api/Toetsen";
            ToetsDTO toetsDTO = new ToetsDTO { Id = 0, Name = "Ard", AantalVragen = 5, AantalGoed = 0, SessionId = 0 };
            //Act
            var response = await client.PostAsync(url, JsonContent.Create(toetsDTO));
            string createdIdString = await response.Content.ReadAsStringAsync();
            int createdId = int.Parse(createdIdString);
            //Assert
            Assert.True(response.IsSuccessStatusCode && createdId != 0);
        }

        [Fact]
        public async Task GET_GetToets_CreatedToetsExists()
        {
            //Arrange
            var client = _factory.CreateClient();
            string POSTurl = "/api/Toetsen";
            ToetsDTO toetsDTO = new ToetsDTO { Id = 0, Name = "Ard", AantalVragen = 5, AantalGoed = 0, SessionId = 0 };
            var POSTresponse = await client.PostAsync(POSTurl, JsonContent.Create(toetsDTO));
            string createdIdString = await POSTresponse.Content.ReadAsStringAsync();
            int createdId = int.Parse(createdIdString);
            string url = "/api/Toetsen?id=";
            //Act
            var response = await client.GetAsync(url + createdId.ToString());
            ToetsDTO content = await response.Content.ReadFromJsonAsync<ToetsDTO>();
            
            //Assert
            Assert.True(response.IsSuccessStatusCode && content.Name == "Ard");
        }
    }
}
