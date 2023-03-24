namespace BasicMathLab.Tests
{
    public class Tests
    {
        private BasicMath basicMath;
        [SetUp]
        public void Setup()
        {
            this.basicMath = new BasicMath();
        }

        [Test]
        public void TestAdd() 
        {
            double realValue = this.basicMath.AddMethod(3,3);
            Assert.AreEqual(6,realValue);
            Assert.AreNotEqual(3,realValue);
        }
        [Test]
        public void TestSubstract()
        {
            double realValue = this.basicMath.SubstractMethod(8, 3);
            Assert.AreEqual(5, realValue);
            Assert.AreNotEqual(3, realValue);
        }
        [Test]
        public void TestMultiply()
        {
            double realValue = this.basicMath.MultiplyMethod(9, 3);
            Assert.AreEqual(27, realValue);
            Assert.AreNotEqual(5, realValue);
        }
        [Test]
        public void TestDivide()
        {
            double realValue = this.basicMath.DivideMethod(9, 3);
            Assert.AreEqual(3, realValue);
            Assert.AreNotEqual(1, realValue);
        }

        [TearDown]
        public void Teardown() 
        {
            this.basicMath = null;
        }
    }
}