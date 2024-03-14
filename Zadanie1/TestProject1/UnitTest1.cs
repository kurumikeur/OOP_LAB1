using Zadanie1;

namespace TestProject1
{
    [TestFixture]
    
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(1, 3, "1/3")]
        [TestCase(-2, -3, "2/3")]
        [TestCase(4, 4, "1")]
        [TestCase(-3, 5, "-3/5")]
        [TestCase(4, -6, "-2/3")]
        public void TestMethodToString(int a, int b, string result)
        {
            var x = new Irrational(a, b);
            Assert.IsTrue(result == x.ToString());
        }

        [Test]
        [TestCase(1, 3, 2, 3, 1, 1)]
        [TestCase(-2, 3, 2, 3, 0, 1)]
        [TestCase(4, 2, 4, 2, 4, 1)]
        [TestCase(-2, 3, -5, 3, -7, 3)]
        [TestCase(10, 3, 5, 4, 55, 12)]
        public void TestMethodOperatorPlus(int a, int b, int a1, int b1, int result, int result1)
        {
            var x = new Irrational(a, b);
            var y = new Irrational(a1, b1);
            x = x + y;
            Assert.That((result == x.Numerator && result1 == x.Denominator), Is.True);
        }

        [Test]
        [TestCase(1, 3, 2, 3, -1, 3)]
        [TestCase(-2, 3, 2, 3, -4, 3)]
        [TestCase(4, 2, 4, 2, 0, 1)]
        [TestCase(-2, 3, -5, 3, 1, 1)]
        [TestCase(10, 3, 5, 4, 25, 12)]
        public void TestMethodOperatorMinus(int a, int b, int a1, int b1, int result, int result1)
        {
            var x = new Irrational(a, b);
            var y = new Irrational(a1, b1);
            x = x - y;
            Assert.That((result == x.Numerator && result1 == x.Denominator), Is.True);
        }

        [Test]
        [TestCase(1, 3, 2, 3, 2, 9)]
        [TestCase(-2, 3, 2, 3, -4, 9)]
        [TestCase(4, 2, 4, 2, 4, 1)]
        [TestCase(-2, 3, -5, 3, 10, 9)]
        [TestCase(10, 3, 5, 4, 25, 6)]
        public void TestMethodOperatorMultiplication(int a, int b, int a1, int b1, int result, int result1)
        {
            var x = new Irrational(a, b);
            var y = new Irrational(a1, b1);
            x = x * y;
            Assert.That((result == x.Numerator && result1 == x.Denominator), Is.True);
        }

        [Test]
        [TestCase(1, 3, 2, 3, 1, 2)]
        [TestCase(-2, 3, 2, 3, -1, 1)]
        [TestCase(4, 2, 4, 2, 1, 1)]
        [TestCase(-2, 3, -5, 3, 2, 5)]
        [TestCase(10, 3, 5, 4, 8, 3)]
        public void TestMethodOperatorDivision(int a, int b, int a1, int b1, int result, int result1)
        {
            var x = new Irrational(a, b);
            var y = new Irrational(a1, b1);
            x = x / y;
            Assert.That((result == x.Numerator && result1 == x.Denominator), Is.True);
        }

        [Test]
        [TestCase(1, 3, 2, 3, false)]
        [TestCase(-2, 3, 2, 3, false)]
        [TestCase(4, 2, 4, 2, false)]
        [TestCase(-2, 3, -5, 3, true)]
        [TestCase(10, 3, 5, 4, true)]
        public void TestMethodOperatorMore(int a, int b, int a1, int b1, bool result)
        {
            var x = new Irrational(a, b);
            var y = new Irrational(a1, b1);
            Assert.That(result == x > y, Is.True);
        }

        [Test]
        [TestCase(1, 3, 2, 3, false)]
        [TestCase(-2, 3, 2, 3, false)]
        [TestCase(4, 2, 4, 2, true)]
        [TestCase(-2, 3, -5, 3, true)]
        [TestCase(10, 3, 5, 4, true)]
        public void TestMethodOperatorMoreEq(int a, int b, int a1, int b1, bool result)
        {
            var x = new Irrational(a, b);
            var y = new Irrational(a1, b1);
            Assert.That(result == x >= y, Is.True);
        }

        [Test]
        [TestCase(1, 3, 2, 3, true)]
        [TestCase(-2, 3, 2, 3, true)]
        [TestCase(4, 2, 4, 2, false)]
        [TestCase(-2, 3, -5, 3, false)]
        [TestCase(10, 3, 5, 4, false)]
        public void TestMethodOperatorLess(int a, int b, int a1, int b1, bool result)
        {
            var x = new Irrational(a, b);
            var y = new Irrational(a1, b1);
            Assert.That(result == x < y, Is.True);
        }

        [Test]
        [TestCase(1, 3, 2, 3, true)]
        [TestCase(-2, 3, 2, 3, true)]
        [TestCase(4, 2, 4, 2, true)]
        [TestCase(-2, 3, -5, 3, false)]
        [TestCase(10, 3, 5, 4, false)]
        public void TestMethodOperatorLessEq(int a, int b, int a1, int b1, bool result)
        {
            var x = new Irrational(a, b);
            var y = new Irrational(a1, b1);
            Assert.That(result == x <= y, Is.True);
        }


        [Test]
        [TestCase(-2, 3, -2, 3, true)]
        [TestCase(-2, 3, 2, 3, false)]
        [TestCase(4, 2, 4, 2, true)]
        [TestCase(-2, 3, -5, 3, false)]
        [TestCase(10, 3, 5, 4, false)]
        public void TestMethodOperatorEqual(int a, int b, int a1, int b1, bool result)
        {
            var x = new Irrational(a, b);
            var y = new Irrational(a1, b1);
            Assert.That(result == (x == y), Is.True);
        }

        [Test]
        [TestCase(-2, 3, -2, 3, false)]
        [TestCase(-2, 3, 2, 3, true)]
        [TestCase(4, 2, 4, 2, false)]
        [TestCase(-2, 3, -5, 3, true)]
        [TestCase(10, 3, 5, 4, true)]
        public void TestMethodOperatorNotEqual(int a, int b, int a1, int b1, bool result)
        {
            var x = new Irrational(a, b);
            var y = new Irrational(a1, b1);
            Assert.That(result == (x != y), Is.True);
        }

        [Test]
        [TestCase(-2, 3, 2, 3)]
        [TestCase(-2, -3, -2, 3)]
        [TestCase(4, -3, 4, 3)]
        [TestCase(5, 3, -5, 3)]
        public void TestMethodOperatorUnaryMinus(int a, int b, int result, int result1)
        {
            var x = new Irrational(a, b);
            x = -x;
            Assert.That(x.Numerator == result && x.Denominator == result1, Is.True);
        }
    }
}