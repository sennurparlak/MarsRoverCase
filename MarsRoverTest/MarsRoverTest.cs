using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MarsRoverCase;
using System.Collections.Generic;

namespace MarsRoverTest
{
    [TestClass]
    public class MarsRoverTest
    {
        [TestMethod]
        public void TestCase1()
        {
            Position position = new Position()
            {
                X = 1,
                Y = 2,
                Direction = Directions.N
            };

            var maxPoints = new List<int>() { 5, 5 };
            var moves = "LMLMLMLMM";

            position.StartToMoving(maxPoints, moves);

            var output = $"{position.X} {position.Y} {position.Direction.ToString()}";
            var expectedOutput = "1 3 N";

            Assert.AreEqual(expectedOutput, output);
        }

        [TestMethod]
        public void TestCase2()
        {
            Position position = new Position()
            {
                X = 3,
                Y = 3,
                Direction = Directions.E
            };

            var maxPoints = new List<int>() { 5, 5 };
            var moves = "MRRMMRMRRM";

            position.StartToMoving(maxPoints, moves);

            var output = $"{position.X} {position.Y} {position.Direction.ToString()}";
            var expectedOutput = "2 3 S";

            Assert.AreEqual(expectedOutput, output);
        }
    }
}
