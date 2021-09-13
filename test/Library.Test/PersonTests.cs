using NUnit.Framework;

using UnitTestAndDebug;

namespace Tests
{
    [TestFixture]
    public class Tests
    {

        [Test]
        public void TestName() 
        {
            Person p = new Person("Néstor Martínez", "5.241.238-0","3/7/2002");
            string expected = "Néstor Martínez";
            Assert.AreEqual(expected, p.Name);
        }

        [Test]
        public void TestID() 
        {
            Person p = new Person("Néstor Martínez", "5.241.238-0","3/7/2002");
            string expected = "5.241.238-0";
            Assert.AreEqual(expected, p.ID);
        }

        [Test]
        public void TestDateOfBirth() 
        {
            Person p = new Person("Néstor Martínez", "5.241.238-0","-1/7/2002");
            string expected = null;
            Assert.AreEqual(expected, p.DateOfBirth);
        }
    }
}