using project_22_03_2023_cli;
namespace Tests10723
{
    public class Tests
    {
        private int val = 0;
        [SetUp]
        public void Setup()
        {
            val = 10;
        }
        [Test]
        public void TestTrueCase()
        {
            var c = new Training_04_03_2023();
            Assert.That(c.GCD(100,200), Is.EqualTo(100));
        }
        [TearDown]
        public void TearDown()
        {
            val = 0;
        }

    }
}