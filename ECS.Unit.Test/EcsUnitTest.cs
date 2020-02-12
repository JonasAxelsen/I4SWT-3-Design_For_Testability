using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace ECS.Unit.Test
{
    [TestFixture]
    public class EcsUnitTest
    {
        private FakeHeater uutFakeHeater;
        private FakeTempSensor uutFakeTempSensor;
        private ECS uut;

        [SetUp]
        public void SetUp()
        {
            uutFakeHeater = new FakeHeater();
            uutFakeTempSensor = new FakeTempSensor();
            uut = new ECS(uutFakeHeater, uutFakeTempSensor); // Threshold is set to 15 default
        }


        // CurTemp
        [Test]
        public void CurTemp_CallAfterConstructor_ReturnsAValidValue()
        {
            
        }

        // Theshold



        // Regulate



    }
}
