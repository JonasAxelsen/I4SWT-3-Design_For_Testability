using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NSubstitute;
using NUnit.Framework;

namespace ECS.Unit.Test
{
    [TestFixture]
    public class EcsUnitTest
    {
        private IHeater uutFakeHeater;
        private ITempSensor uutFakeTempSensor;
        private ECS uut;

        [SetUp]
        public void SetUp()
        {
            uutFakeHeater = Substitute.For<IHeater>();
            uutFakeTempSensor = Substitute.For<ITempSensor>();
            
            uut = new ECS(uutFakeHeater, uutFakeTempSensor); // Threshold is set to 15 default
        }


        // CurTemp
        [TestCase(int.MinValue)]
        [TestCase(int.MaxValue)]
        [TestCase(0)]
        [TestCase(-1)]
        [TestCase(1)]
        public void CurTemp_CallAfterConstructor_ReturnsAValidValue(int temperature)
        {
            // Arrange
            uutFakeTempSensor.GetTemp().Returns(temperature);

            // Act
            int returnedTemperature = uut.CurTemp;

            // Assert
            Assert.That(returnedTemperature, Is.EqualTo(temperature));
        }

        // Theshold
        [Test]
        public void Threshold_()
        {

        }

        #region RegulateTest
        [Test]
        public void Regulate_aboveThreshold_callsHeaterTurnOffCorrectly()
        {
            uutFakeTempSensor.GetTemp().Returns(uut.Threshold + 10);

            uut.Regulate();

            uutFakeHeater.Received(1).TurnOff();
        }

        [Test]
        public void Regulate_aboveThreshold_callsHeaterTurnOnCorrectly()
        {
            uutFakeTempSensor.GetTemp().Returns(uut.Threshold + 10);

            uut.Regulate();

            uutFakeHeater.DidNotReceive().TurnOn();
        }

        [Test]
        public void Regulate_belowThreshold_callsHeaterTurnOnCorrectly()
        {
            uutFakeTempSensor.GetTemp().Returns(uut.Threshold - 10);

            uut.Regulate();

            uutFakeHeater.Received(1).TurnOn();
        }

        [Test]
        public void Regulate_belowThreshold_callsHeaterTurnOffCorrectly()
        {
            uutFakeTempSensor.GetTemp().Returns(uut.Threshold - 10);

            uut.Regulate();

            uutFakeHeater.DidNotReceive().TurnOff();
        }
        #endregion
    }
}
