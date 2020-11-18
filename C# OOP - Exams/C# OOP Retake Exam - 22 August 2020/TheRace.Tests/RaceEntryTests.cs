using NUnit.Framework;
using System;
using TheRace;

namespace TheRace.Tests
{
    [TestFixture]
    public class RaceEntryTests
    {

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestUnityCarCtorWorksCorectly()
        {
            var car = new UnitCar("Model", 10, 15.6);

            Assert.AreEqual("Model", car.Model);
            Assert.AreEqual(10, car.HorsePower);
            Assert.AreEqual(15.6, car.CubicCentimeters);
        }

        [Test]
        public void TestUnityDriverCtorWorksCorectly()
        {
            var car = new UnitCar("Model", 10, 15.6);
            var driver = new UnitDriver("name", car);

            Assert.AreEqual("name", driver.Name);
            Assert.AreEqual("Model", driver.Car.Model);
            Assert.AreEqual(10, driver.Car.HorsePower);
            Assert.AreEqual(15.6, driver.Car.CubicCentimeters);
        }

        [Test]
        public void TestUnityDriverThrowsArgumentNullExceptionIfNameIsNull()
        {
            var car = new UnitCar("Model", 10, 15.6);

            Assert.Throws<ArgumentNullException>(() => new UnitDriver(null, car));
        }

        [Test]
        public void TestRaceEntryCtorWorksCorectly()
        {
            var race = new RaceEntry();

            Assert.AreEqual(0, race.Counter);
        }
        
        [Test]
        public void TestRaceEntryAddCommandThrowsInvalidOperationExceptionIfNull()
        {
            var race = new RaceEntry();

            Assert.Throws<InvalidOperationException>(() => race.AddDriver(null));
        }

        [Test]
        public void TestRaceEntryAddCommandThrowsInvalidOperationExceptionIfDriverIsInCollection()
        {
            var car = new UnitCar("Model", 10, 15.6);
            var currDriver = new UnitDriver("name", car);
            var expectedDriver = new UnitDriver("name", car);
            var race = new RaceEntry();

            race.AddDriver(currDriver);

            Assert.Throws<InvalidOperationException>(() => race.AddDriver(expectedDriver));
        }

        [Test]
        public void TestRaceEntryAddCommandIncreaseCollectionCount()
        {
            var car = new UnitCar("Model", 10, 15.6);
            var driver = new UnitDriver("name", car);
            var race = new RaceEntry();

            race.AddDriver(driver);

            Assert.AreEqual(1, race.Counter);
        }

        [Test]
        public void TestRaceEntryAddCommandShouldReturnCorrectMessage()
        {
            var car = new UnitCar("Model", 10, 15.6);
            var driver = new UnitDriver("name", car);
            var race = new RaceEntry();

            string currMessage = race.AddDriver(driver);
            string expectedMessage = "Driver name added in race.";

            Assert.AreEqual(currMessage,expectedMessage);
        }

        [Test]
        public void TestRaceEntryCalculateAverageHorsePowerCommandThrowsEceptionIfDriverCountIsLessThanMinParticipants()
        {
            var car = new UnitCar("Model", 10, 15.6);
            var driver = new UnitDriver("name", car);
            var race = new RaceEntry();

            Assert.Throws<InvalidOperationException>(() => race.CalculateAverageHorsePower());
        }

        [Test]
        public void TestRaceEntryCalculateAverageHorsePowerCommandReturnCorectAverage()
        {
            var firstCar = new UnitCar("firstModel", 10, 15.6);
            var secondCar = new UnitCar("secondModel", 10, 15.6);
            var firstDriver = new UnitDriver("firstName",firstCar);
            var secondDriver = new UnitDriver("secondName", secondCar);
            var race = new RaceEntry();

            race.AddDriver(firstDriver);
            race.AddDriver(secondDriver);

            Assert.AreEqual(10, race.CalculateAverageHorsePower());
        }
    }
}