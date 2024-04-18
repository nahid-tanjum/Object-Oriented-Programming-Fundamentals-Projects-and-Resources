using Swin_Adventure;
using NUnit.Framework;
using System.Runtime.CompilerServices;

namespace Swin_AdventureUnitTests
{
    [TestFixture]
    public class InventoryTests
    {
        private Inventory _inventory;
        private Item _shovel;

        [SetUp]
        public void SetUp()
        {
            _inventory = new Inventory();
            _shovel = new Item(new String[] { "shovel", "spade" }, "a shovel", "This is a mighty fine shovel");
        }

        [Test]
        public void TestFindItem()
        {
            _inventory.Put(_shovel);
            Assert.IsTrue(_shovel.AreYou("shovel"));
        }


        [Test]
        public void TestNoItem()
        {
            Assert.IsFalse(_inventory.HasItem("shovel"));
        }

        [Test]
        public void TestFetchItem()
        {
            _inventory.Put(_shovel);
            Assert.That(_shovel, Is.EqualTo(_inventory.Fetch("shovel")));
        }

        [Test]
        public void TestTakeItem()
        {
            _inventory.Put(_shovel);
            _inventory.Take("shovel");
            Assert.IsFalse(_inventory.HasItem("shovel"));
        }


        [Test]
        public void TestItemList()
        {
            _inventory.Put(_shovel);
            Assert.That(_inventory.ItemList, Is.EqualTo("  a shovel (shovel)\n"));
        }
    }
}
