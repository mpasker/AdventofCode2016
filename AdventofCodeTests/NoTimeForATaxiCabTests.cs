using System;
using System.ComponentModel;
using AdventofCode;
using NUnit.Framework;

namespace AdventofCodeTests
{
   
    public class NoTimeForATaxiCabTests
    {
        [Test]
        public void StartAtTheOriginFacingNorth()
        {
            var instance = new NoTimeForATaxiCab();

            Assert.AreEqual(DirectionFacing.North, instance.Direction);
            Assert.AreEqual(0, instance.Horizontal);
            Assert.AreEqual(0, instance.Vertical);
        }

        [Test]
        public void FaceWestAfterTurningLeftFromNorth()
        {
            var instance = new NoTimeForATaxiCab();
            instance.TurnLeft();

            Assert.AreEqual(DirectionFacing.West, instance.Direction);
        }

        [Test]
        public void FaceEastAfterTurningRightFromNorth()
        {

            var instance = new NoTimeForATaxiCab();
            instance.TurnRight();

            Assert.AreEqual(DirectionFacing.East, instance.Direction);
        }

        [Test]
        public void RecordDistanceTraveledNorth()
        {

            var number = Any.Number();
            var instance = new NoTimeForATaxiCab();
            instance.TravelDistance(number);

            Assert.AreEqual(number, instance.Vertical);
        }

        [Test]
        public void RecordDistanceTraveledEast()
        {
            var number = Any.Number();
            var instance = new NoTimeForATaxiCab();
            instance.TurnRight();

            instance.TravelDistance(number);

            Assert.AreEqual(number, instance.Horizontal);
        }

        [Test]
        public void RecordDistanceTraveledSouth()
        {
            var number = Any.Number();
            var instance = new NoTimeForATaxiCab();

            instance.TurnRight();
            instance.TurnRight();
            instance.TravelDistance(number);

            Assert.AreEqual(number, instance.Vertical * -1);
        }

        [Test]
        public void RecordDistancTraveledWest()
        {
            var number = Any.Number();
            var instance = new NoTimeForATaxiCab();

            instance.TurnLeft();
            instance.TravelDistance(number);

            Assert.AreEqual(number, instance.Horizontal * -1);
        }

        [TestCase("L1", DirectionFacing.West)]
        [TestCase("R1", DirectionFacing.East)]
        public void TurnLeftOrRightBasedOnInput(string step, DirectionFacing expectedDirectionFacing)
        {
            var instance = new NoTimeForATaxiCab();

            instance.HandleStep(step);

            Assert.AreEqual(expectedDirectionFacing, instance.Direction);

        }

        [TestCase("L1", -1)]
        [TestCase("R1", 1)]
        public void TravelWestOrEastBasedOnInput(string step, int expectedHorizonalDistance)
        {
            var instance = new NoTimeForATaxiCab();

            instance.HandleStep(step);

            Assert.AreEqual(expectedHorizonalDistance, instance.Horizontal);
        }
    }
}
