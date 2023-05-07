namespace Project_Test_5_5_23
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow(2)]
        public void TestMethod1(int i)
        {
            try
            {
                Assert.AreEqual(1, i);
                Assert.ThrowsException<ArgumentException>(() => { });
                
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}