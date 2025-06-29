using NUnit.Framework;
using CalcLibrary;


namespace CalcLibrary.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        private SimpleCalculator _calc;

        [SetUp]
        public void Init()
        {
            _calc = new SimpleCalculator();
        }

        [TearDown]
        public void Cleanup()
        {
            _calc = null;
        }

        [TestCase(2, 3, 5)]
        [TestCase(-1, -1, -2)]
        public void Add_WhenCalled_ReturnsExpectedSum(int a, int b, int expected)
        {
            double result = _calc.Addition(a, b); 
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}