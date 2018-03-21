using System;
using M7_Inheritance.MoreClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ElevatorTest
{
    [TestClass]
    public class UnitTest1
    {
        const int bottomfloor = -2;
        const int topfloor = 3;
        const int startfloor = 1;
        private const int untilmaintainance = 6;

        readonly Elevator elevator = new Elevator("Kalle", bottomfloor, topfloor, startfloor, untilmaintainance);

        [TestMethod]
        public void CorrectStartFloor()
        {
            Assert.AreEqual(startfloor, elevator.CurrentFloor);
        }

        [TestMethod]
        public void CorrectNrOfFloors()
        {
            Assert.AreEqual(6, elevator.CountFloors);
        }

        [TestMethod]
        public void GoUpOnce()
        {
            elevator.GoUp();
            Assert.AreEqual(startfloor + 1, elevator.CurrentFloor);
        }

        [TestMethod]
        public void GoDownOnce()
        {
            elevator.GoDown();
            Assert.AreEqual(startfloor - 1, elevator.CurrentFloor);
        }

        [TestMethod]
        public void GoUpTwice()
        {
            elevator.GoUp();
            elevator.GoUp();
            Assert.AreEqual(startfloor + 2, elevator.CurrentFloor);
        }

        [TestMethod]
        public void HitTopFloor()
        {
            for (int i = 0; i < 100; i++)
                elevator.GoUp();

            Assert.AreEqual(topfloor, elevator.CurrentFloor);
        }

        [TestMethod]
        public void HitBottomFloor()
        {
            for (int i = 0; i < 100; i++)
                elevator.GoDown();

            Assert.AreEqual(bottomfloor, elevator.CurrentFloor);
        }

        [TestMethod]
        public void PowerIsOnAfterFiveSteps()
        {
            elevator.GoDown();
            elevator.GoUp();

            elevator.GoDown();
            elevator.GoUp();

            elevator.GoDown();

            Assert.IsTrue(elevator.PowerIsOn);
        }

        [TestMethod]
        public void PowerIsOffAfterSixSteps()
        {
            elevator.GoDown();
            elevator.GoUp();

            elevator.GoDown();
            elevator.GoUp();

            elevator.GoDown();
            elevator.GoUp();

            Assert.IsFalse(elevator.PowerIsOn);
        }

        [TestMethod]
        public void HighestFloorIsTooLow()
        {
            var ex = Assert.ThrowsException<ArgumentException>(
                () => new Elevator("Laban", 100, 10));

            Assert.AreEqual(Elevator.ErrorHighestFloorIsTooLow, ex.Message);
        }

        [TestMethod]
        public void StartFloorOutsideOfBounds()
        {
            var ex = Assert.ThrowsException<ArgumentException>(
                () => new Elevator("Laban", 10, 15, 16, 1000));

            Assert.AreEqual(Elevator.ErrorStartFloorOutsideOfBounds, ex.Message);
        }

    }
}
