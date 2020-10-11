using System;
using BasicCSharpConsole.Samples.Class;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    [TestCategory("Demo app tests")]
    [TestCategory("Car class tests")]
    public class CarTest
    {
        [TestMethod]
        public void ShouldServiceCheckNotNeeded_IfLowDistanceCovered_Test()
        {
            //assign
            var calc = new Car(100);

            //act
            calc.Drive(20);
            
            //assert
            Assert.IsFalse(calc.IsServiceCheckNeeded());
        }

        [DataTestMethod]
        [DataRow(10)]
        [DataRow(100)]
        [DataRow(330)]
        public void ShouldDistanceIncrease_IfCarMoved_Test(int speed)
        {
            //assign
            var calc = new Car(speed);
            var initialDistance = calc.Distance;
            var duration = 20;

            //act
            calc.Drive(duration);

            //assert
            Assert.AreEqual(0, initialDistance);
            Assert.IsTrue(speed * duration == calc.Distance);
        }

        [TestMethod]
        public void ShouldReturnException_IfNegativeParameterPassed_Test()
        {
            //assert
            Assert.ThrowsException<ArgumentOutOfRangeException>(() =>
            {
                var calc = new Car(-20);
            });
        }
    }
}
