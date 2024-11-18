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

        [Test]
        public void CalculateLetterFrequency()
        {
            var analyser = new WordAnalyser();
            string input = "Cafbhaifbuhav74689 sva r t3q63 dghc";

            Dictionary<char, int> dictionary = analyser.CalculateLetterFrequency(input);

            int charFrequency = dictionary['A'];

            charFrequency.Should().Be(4);
        }

        [Test]
        public void AddItems()
        {
            ShoppingCart cart = new ShoppingCart();
            string name = "phone";
            double price = 100d;
            bool result = cart.AddItems(name, price);

            result.Should().BeTrue();

        }

        [Test]
        public void CalculateTotalPrice()
        {
            ShoppingCart cart = new ShoppingCart();
            cart.AddItems("phone", 100);
            double result = cart.CalculateTotalPrice();

            result.Should().Be(100d);

        }

        [Test]
        public void ApplyDiscount()
        {
            ShoppingCart cart = new ShoppingCart();
            cart.AddItems("phone", 100);
            
            double result = cart.ApplyDiscount(1.5d);

            result.Should().Be(150);

            var testCases = new (string name, double price, double discount, double discountedPrice)[]
                {
                ("cheese", 50d, 2d, 100d),
                ("argafg", 500d, -1d, -500d),
                };

            Assert.Multiple(() =>
            {
                foreach (var (a, b, c, expected) in testCases)
                {
                    cart.AddItems(a, b);
                    double result = cart.ApplyDiscount(c);
                    
                    result.Should().Be(expected);
                }
            });

        }


    }
}