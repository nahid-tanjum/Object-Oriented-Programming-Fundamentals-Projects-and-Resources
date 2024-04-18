using Swin_Adventure;
using NUnit.Framework;
using System.Runtime.CompilerServices;

namespace Swin_AdventureTests
{
    [TestFixture]
    public class ItemTests
    {
        private Item _item;

        [SetUp]
        public void SetUp()
        {
            _item = new Item(new String[] { "shovel", "spade" }, "a shovel", "This is a mighty fine shovel");
        }

        [Test]
        public void TestIdentifiable()
        {
            Assert.IsTrue(_item.AreYou("shovel"));
        }

        [Test]
        public void TestShortDescription()
        {
            Assert.IsTrue(_item.ShortDescription == "a shovel (shovel)");
        }

        [Test]
        public void TestFullDescription()
        {
            Assert.That(_item.FullDescription, Is.EqualTo("This is a mighty fine shovel"));

        }
    }
}
