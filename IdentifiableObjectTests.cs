using Swin_Adventure;
using NUnit.Framework;
using System.Runtime.CompilerServices;

namespace Swin_AdventureUnitTests
{
    [TestFixture]
    public class IdentifiableObjectTests
    {
        private IdentifiableObject _id;

        [SetUp]
        public void SetUp()
        {
            _id = new IdentifiableObject(new string[] { "fred", "bob" });
        }

        [Test]
        public void TestAreYou()
        {
            Assert.IsTrue(_id.AreYou("fred"));
            Assert.IsTrue(_id.AreYou("bob"));
        }

        [Test]
        public void TestNotAreYou()
        {
            Assert.IsFalse(_id.AreYou("wilma"));
        }

        [Test]
        public void TestAreYouCaseSensitive()
        {
            Assert.IsTrue(_id.AreYou("FREd"));
            Assert.IsTrue(_id.AreYou("bOB"));
        }

        [Test]
        public void TestFirstId()
        {
            string result = _id.FirstId;
            Assert.That(result, Is.EqualTo("fred"));
        }

        [Test]
        public void TestFirstIdWithNoIds()
        {
            _id = new IdentifiableObject(new string[] { });

            string result = _id.FirstId;
            Assert.That(result, Is.EqualTo(""));
        }

        [Test]
        public void TestAddId()
        {
            _id.AddIdentifier("wilma");
            Assert.IsTrue(_id.AreYou("wilma"));
            Assert.IsTrue(_id.AreYou("fred"));
            Assert.IsTrue(_id.AreYou("bob"));
        }
    }
}