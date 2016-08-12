using System.Collections.Generic;
using DependencyInjection.Implementations.Events;
using NUnit.Framework;

namespace DependencyInjection.Tests
{
    [TestFixture]
    public class EventTests
    {
        [Test, TestCaseSource(typeof(Data), "RegisterNumbers")]
        public void Register_Fire(int value, string expected)
        {
            //Arrange
            var sut = new Register();

            //Act
            var result = sut.Fire(value);

            //Assert
            Assert.That(expected , Is.EqualTo(result));
        }

        [Test, TestCaseSource(typeof(Data), "DiagnoseNumbers")]
        public void Diagnose_Fire(int value, string expected)
        {
            //Arrange
            var sut = new Diagnose();

            //Act
            var result = sut.Fire(value);

            //Assert
            Assert.That(expected, Is.EqualTo(result));
        }

        [Test, TestCaseSource(typeof(Data), "DiagnoseNumbers")]
        public void BaseEvent_Fire(int value, string expected)
        {
            //Arrange
            var mod = new Dictionary<int, string>()
                {
                    {2 , "Diagnose" },
                    {7 , "Patient" }
                };
            var sut = new BaseEvent(mod);

            //Act
            var result = sut.Fire(value);

            //Assert
            Assert.That(expected, Is.EqualTo(result));
        }

    }
}