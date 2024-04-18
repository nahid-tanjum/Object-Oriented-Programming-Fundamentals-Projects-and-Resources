using Swin_Adventure;
using NUnit.Framework;
using System.Runtime.CompilerServices;

namespace Swin_AdventureUnitTests
{
    [TestFixture]
    public class PlayerTests
    {
        private Player _player;
        private Item _shovel;

        [SetUp]
        public void SetUp()
        {
            _player = new Player("Fred", "the mighty programmer");
            _shovel = new Item(new String[] { "shovel", "spade" }, "a shovel", "This is a mighty fine shovel");
        }

        [Test]
        public void TestPlayerIdentifiable()
        {
            Assert.That(_player.AreYou("me"));
        }

        [Test]
        public void TestLocateItems()
        {
            _player.Inventory.Put(_shovel);
            Assert.That(_shovel, Is.EqualTo(_player.Locate("shovel")));
        }

        [Test]
        public void TestLocateSelf()
        {
            Assert.That(_player, Is.EqualTo(_player.Locate("me")));
        }

        [Test]
        public void TestLocateNothing()
        {
            Assert.That(_player.Locate("sword"), Is.EqualTo(null));
        }

        [Test]
        public void TestPlayerFullDescription()
        {
            _player.Inventory.Put(_shovel);
            Assert.That(_player.FullDescription, Is.EqualTo("You are Fred, the mighty programmer.\nYou are carrying: \n  a shovel (shovel)\n"));
        }
    }
}
