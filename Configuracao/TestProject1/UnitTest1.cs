namespace TestProject1
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
            if (2 > 1)
                Assert.Pass();
        }
        [Test]
        public void Teste2()
        {
            Assert.Pass();
        }
    }
}