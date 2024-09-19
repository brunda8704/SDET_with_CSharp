namespace TestProject1
{
    public class Tests
    {
        [OneTimeSetUp]
        public void Init()
        {
            Console.WriteLine("Init method");
        }

        [Test]
        [Order(1)]
        public void Test1()
        {
            Console.WriteLine("Test1 method");
            Assert.AreEqual(10, 10);
        }

        [Test]
        [Order(3)]
        public void Test2()
        {
            Console.WriteLine("Test2 method");
            Assert.AreNotEqual(10, 1);
            
        }

        [Test]
        [Order(2)]
        [Ignore("Skip this test")]
        public void Test3()
        {
            Assert.That(1.Equals(1));
        }

        [OneTimeTearDown]
        public void Close()
        {
            Console.WriteLine("Close method");
        }

        
    }
}