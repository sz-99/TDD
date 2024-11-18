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
        public void TestSingleDirection()
        {
            Compass greatCompass = new Compass();

            Point input1 = Point.North;
            Direction input2 = Direction.left;

            Point result = greatCompass.Rotate(input1, input2);

            result.Should().Be(Point.West);
        }

        [Test]
        public void TestRotateRight()
        {
            Compass compass = new Compass();
            //Point result1 = compass.Rotate(Point.East, Direction.left);
            //Point result2 = compass.Rotate(Point.North, Direction.left);
            //Point result3 = compass.Rotate(Point.West, Direction.left);
            //Point result4 = compass.Rotate(Point.South, Direction.left);
            //Assert.Multiple(() =>
            //{
            //    result1.Should().Be(Point.North);
            //    result2.Should().Be(Point.West);
            //    result3.Should().Be(Point.South);
            //    result4.Should().Be(Point.East);
            //});

            var testCases = new (Point point, Direction direction, Point expectedResult)[]
                {
                (Point.North, Direction.right, Point.East),
                (Point.East, Direction.right, Point.South),
                (Point.South, Direction.right, Point.West),
                (Point.West, Direction.right, Point.North),
                };

            Assert.Multiple(() =>
            {
                foreach (var (a, b, expected) in testCases)
                {
                    Point result = compass.Rotate((Point)a, (Direction)b);
                    result.Should().Be(expected);
                }
            });
        }


        [Test]
        public void TestRotateLeft()
        {
            Compass compass = new Compass();
            var testCases = new (Point point, Direction direction, Point expectedResult)[]
                {
                (Point.North, Direction.left, Point.West),
                (Point.East, Direction.left, Point.North),
                (Point.South, Direction.left, Point.East),
                (Point.West, Direction.left, Point.South),
                };

            Assert.Multiple(() =>
            {
                foreach (var (a, b, expected) in testCases)
                {
                    Point result = compass.Rotate((Point)a, (Direction)b);
                    result.Should().Be(expected);
                }
            });


        }

        [Test]
        public void TestReverseString()
        {
            string testString = "hello";
            var stringManipulator = new StringManipulator();

            string result = stringManipulator.ReverseString(testString);

            result.Should().Be("olleh");
        }

        [Test]
        public void TestIsPalindrome()
        {
            string testString = "racecar";
            var stringManipulator = new StringManipulator();

            bool result = stringManipulator.IsPalindrome(testString);

            result.Should().BeTrue();
        }
    }
}