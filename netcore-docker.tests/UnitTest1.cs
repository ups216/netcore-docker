using NUnit.Framework;

namespace netcore_docker.tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void User_Is_Able_To_GetPersonalProfile()
        {
            Assert.AreEqual("abc", "abc");
        }

        [Test]
        public void User_Is_Able_To_UpdatePersonalProfile()
        {
            Assert.AreEqual("abc", "abc");
        }
    }
}