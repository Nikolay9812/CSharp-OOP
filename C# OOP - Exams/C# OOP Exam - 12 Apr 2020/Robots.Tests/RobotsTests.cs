namespace Robots.Tests
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class RobotsTests
    {
        [Test]
        public void Test1()
        {
            Robot robot = new Robot("Max", 100);

            Assert.AreEqual("Max", robot.Name);
            Assert.AreEqual(100, robot.MaximumBattery);
            Assert.AreEqual(100, robot.Battery);
        }

        [Test]
        public void Test2()
        {
            RobotManager robotManager = new RobotManager(10);

            Assert.AreEqual(10, robotManager.Capacity);
            Assert.AreEqual(0, robotManager.Count);
        }

        [Test]
        public void Test3()
        {
            Assert.Throws<ArgumentException>(() => new RobotManager(-1));
        }

        [Test]
        public void Test4()
        {
            Robot firstRobot = new Robot("Max", 100);
            Robot secondRobot = new Robot("Max", 100);

            RobotManager robotManager = new RobotManager(10);

            robotManager.Add(firstRobot);

            Assert.Throws<InvalidOperationException>(() => robotManager.Add(secondRobot));

        }

        [Test]
        public void Test5()
        {
            Robot firstRobot = new Robot("Max", 100);
            Robot secondRobot = new Robot("Ben", 100);

            RobotManager robotManager = new RobotManager(1);

            robotManager.Add(firstRobot);

            Assert.Throws<InvalidOperationException>(() => robotManager.Add(secondRobot));

        }

        [Test]
        public void Test6()
        {
            Robot robot = new Robot("Max", 100);

            RobotManager robotManager = new RobotManager(10);

            robotManager.Add(robot);

            Assert.AreEqual(1, robotManager.Count);

        }

        [Test]
        public void Test7()
        {
            Robot firstRobot = new Robot("Max", 100);
            Robot secondRobot = new Robot("Ben", 100);

            RobotManager robotManager = new RobotManager(10);

            robotManager.Add(firstRobot);
            robotManager.Add(secondRobot);

            robotManager.Remove("Max");

            Assert.AreEqual(firstRobot.Name, "Max");

        }

        [Test]
        public void Test9()
        {
            RobotManager robotManager = new RobotManager(10);

            Assert.Throws<InvalidOperationException>(() => robotManager.Remove(null));

        }

        [Test]
        public void Test10()
        {
            Robot robot = new Robot("Max", 100);

            RobotManager robotManager = new RobotManager(10);

            robotManager.Add(robot);
            robotManager.Remove("Max");

            Assert.AreEqual(0, robotManager.Count);

        }

        [Test]
        public void Test11()
        {
            Robot robot = new Robot("Max", 100);

            RobotManager robotManager = new RobotManager(10);

            robotManager.Add(robot);

            Assert.Throws<InvalidOperationException>(() => robotManager.Work("Sasho", "cleaning", 20));

        }

        [Test]
        public void Test12()
        {
            Robot robot = new Robot("Max", 100);

            RobotManager robotManager = new RobotManager(10);

            robotManager.Add(robot);

            Assert.Throws<InvalidOperationException>(() => robotManager.Work("Max", "builder", 200));

        }

        [Test]
        public void Test13()
        {
            Robot robot = new Robot("Max", 100);

            RobotManager robotManager = new RobotManager(10);

            robotManager.Add(robot);
            robotManager.Work("Max", "builder", 50);

            Assert.AreEqual(50, robot.Battery);

        }

        [Test]
        public void Test14()
        {
            Robot robot = new Robot("Max", 100);

            RobotManager robotManager = new RobotManager(10);

            robotManager.Add(robot);
            robotManager.Work("Max", "builder", 50);

            Assert.Throws<InvalidOperationException>(() => robotManager.Charge("Sam"));

        }

        [Test]
        public void Test15()
        {
            Robot robot = new Robot("Max", 100);

            RobotManager robotManager = new RobotManager(10);

            robotManager.Add(robot);
            robotManager.Work("Max", "builder", 50);
            robotManager.Charge("Max");

            Assert.AreEqual(100, robot.Battery);

        }
    }
}
