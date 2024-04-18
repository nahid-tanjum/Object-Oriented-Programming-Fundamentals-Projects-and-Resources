using Swin_Adventure;
using NUnit.Framework;
using System.Runtime.CompilerServices;

namespace Swin_AdventureUnitTests
{
    [TestFixture]
    public class ItemTests
    {
        private Item _shovel;

        [SetUp]
        public void SetUp()
        {
            _shovel = new Item(new String[] { "shovel", "spade" }, "a shovel", "This is a mighty fine shovel");
        }

        [Test]
        public void TestIdentifiable()
        {
            Assert.IsTrue(_shovel.AreYou("shovel"));
        }

        [Test]
        public void TestShortDescription()
        {
            Assert.IsTrue(_shovel.ShortDescription == "a shovel (shovel)");
        }

        [Test]
        public void TestFullDescription()
        {
            Assert.That(_shovel.FullDescription, Is.EqualTo("This is a mighty fine shovel"));

        }
    }
}
