using NUnit.Framework;
using RobotToy;
using RobotToy.Enums;

namespace RobotToyTest
{
    [TestFixture]
    public class TestRobot
    {
        [Test]
        public void TestValidPlacement()
        {
            //arrange
            Position position = new Position(2, 4);
            RobotToy.RobotToy robot = new RobotToy.RobotToy();

            //act
            robot.Place(position, Direction.EAST);

            //assert
            Assert.AreEqual(2, robot.Position.X);
            Assert.AreEqual(4, robot.Position.Y);
            Assert.AreEqual(Direction.EAST, robot.Direction);


        }

        [Test]
        public void TestValidMove()
        {
            //arrage
            RobotToy.RobotToy robot = new RobotToy.RobotToy { Position = new Position(2, 3), Direction = Direction.NORTH };

            //act
            Position newPosition = robot.Move();

            //assert
            Assert.AreEqual(2, newPosition.X);
            Assert.AreEqual(4, newPosition.Y);
        }

        [Test]
        public void TestValidLeft()
        {
            //arrange
            RobotToy.RobotToy robot = new RobotToy.RobotToy { Position = new Position(2, 3), Direction = Direction.NORTH };

            //act
            robot.Left();

            //assert
            Assert.AreEqual(Direction.WEST, robot.Direction);
        }

        [Test]
        public void TestValidRight()
        {
            //arrange
            RobotToy.RobotToy robot = new RobotToy.RobotToy { Position = new Position(2, 3), Direction = Direction.NORTH };

            //act
            robot.Right();

            //assert
            Assert.AreEqual(Direction.EAST, robot.Direction);
        }

        [Test]
        public void TestValidReport()
        {
            //arrange
            RobotToy.RobotToy robot = new RobotToy.RobotToy { Position = new Position(2, 3), Direction = Direction.NORTH };

            //act
            string output = robot.Report();

            //assert
            Assert.AreEqual($"Output: 2,3,NORTH", output);
        }
    }
}
