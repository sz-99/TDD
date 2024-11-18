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

        [Test]
        public void Test1()
        {
            Compass greatCompass = new Compass();

            Point input1 = Point.North;
            Direction input2 = Direction.right;

            Point result = greatCompass.Rotate(input1, input2);

            result.Should().Be(Point.East);
            Assert.Pass();
        }
    }
}