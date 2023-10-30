
using AllAboutPigeons.Controllers;
using AllAboutPigeons.Models;

namespace PigeonTests
{
    public class QuizTests
    {
        [Fact]
        public void TestLoadQuestions()
        {
            // Arrange
            var controller = new QuizController();
            var model = new Tests();

            // Act
            var loadedModel = controller.LoadQuestions(model);

            // Assert
            Assert.Equal(controller.Questions, loadedModel.Questions);
            Assert.Equal(controller.Answers, loadedModel.Answers);
            Assert.NotNull(loadedModel.Questions);
            Assert.NotNull(loadedModel.Answers);
            Assert.NotNull(controller.Questions);
            Assert.NotNull(controller.Answers);
        }
    }
}