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
    }
}