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
            var stringManipulator = new StringManipulator();
            string testString = "racecar";

            bool result = stringManipulator.IsPalindrome(testString);

            result.Should().BeTrue();
        }

        [Test]
        public void FindLongestWords()
        {
            var analyser = new WordAnalyser();
            string input = "This is some example samples test data - come up with your own!";

            var result = analyser.FindLongestWords(input);

            result.Should().Equal(new List<string>() { "example", "samples" });
        }
    }
}