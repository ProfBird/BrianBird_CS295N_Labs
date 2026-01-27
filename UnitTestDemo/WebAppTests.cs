using AllAboutPigeons.Controllers;
using AllAboutPigeons.Models;
using Microsoft.AspNetCore.Mvc;

namespace UnitTestDemo
{
    public class WebAppTests
    {
        [Fact]
        public void ForumPostTest()
        {
            // Arrange
            var registryController = new RegistryController();
            var model = new Message();
            // Act
            var viewResult = (ViewResult)registryController.ForumPost(model);
            var message = viewResult.Model as Message;
            // Assert
            Assert.NotNull(message);
            Assert.Equal(DateOnly.FromDateTime(DateTime.Now), message!.Date);
        }
    }
}
