using DependencyInjection.Implementations;
using DependencyInjection.Interfaces;
using Moq;
using NUnit.Framework;

namespace DependencyInjection.Tests
{
    [TestFixture]
    public class GeneratorTests
    {
        [Test]
        public void Generate_List()
        {
            //Arrange
            var eventMock = new Mock<IEvent>();
            eventMock.Setup(x => x.Fire(It.IsAny<int>()))
                .Returns("test");

            var sut = new Generator(eventMock.Object);

            //Act
            var result = sut.Generate(1, 100);

            //Assert
            eventMock.Verify(x => x.Fire(It.IsAny<int>()), Times.Exactly(100));
            Assert.That(result.Count , Is.EqualTo(100));
        }
    }
}