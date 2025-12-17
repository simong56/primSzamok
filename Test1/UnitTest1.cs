namespace Test1
{
    using Xunit;
    using primSzamok;

    public class UnitTest1
    {
        [Fact]
        public void TestPrimeNumber()
        {
            // Test with prime number 13
            Assert.True(PrimeChecker.IsPrime(13));
        }

        [Fact]
        public void TestNonPrimeNumber()
        {
            // Test with non-prime number 10
            Assert.False(PrimeChecker.IsPrime(10));
        }

        [Fact]
        public void TestZeroAndNegativeNumbers()
        {
            // Test with 0
            Assert.False(PrimeChecker.IsPrime(0));
            // Test with negative number
            Assert.False(PrimeChecker.IsPrime(-5));
        }

        [Fact]
        public void TestLargePrimeNumber()
        {
            // Test with large prime number 1009
            Assert.True(PrimeChecker.IsPrime(1009));
        }
    }
}
