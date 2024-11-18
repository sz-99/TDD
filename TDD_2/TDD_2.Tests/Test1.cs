using FluentAssertions;
using TDD_2;
namespace TDD_2.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test, Description("Organisation!")]
        public void Test1()
        {
            Compass greatCompass = new Compass();

            Point input1 = Point.North;
            Direction input2 = Direction.left;

            Point result = greatCompass.Rotate(input1, input2);

            result.Should().Be(Point.West);
        }

        [Test]
        public void Test2()
        {
            Compass compass = new Compass();
            Point result1 = compass.Rotate(Point.East, Direction.left);
            Point result2 = compass.Rotate(Point.North, Direction.left);
            Point result3 = compass.Rotate(Point.West, Direction.left);
            Point result4 = compass.Rotate(Point.South, Direction.left);
            Assert.Multiple(() =>
            {
                result1.Should().Be(Point.North);
                result1.Should().Be(Point.West);
                result1.Should().Be(Point.South);
                result1.Should().Be(Point.East);
            });
        }
    }
}