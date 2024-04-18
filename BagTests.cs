using Swin_Adventure;
using NUnit.Framework;
using System.Runtime.CompilerServices;
using System.Xml.Linq;

namespace Swin_AdventureUnitTests
{
    [TestFixture]
    public class BagTests
    {
        private Bag _bag;
        private Item _shovel;

        [SetUp]
        public void SetUp()
        {
            _bag = new Bag(new String[] { "bag", "backpack" }, "bag", "This is a big blue bag");
            _shovel = new Item(new String[] { "shovel", "spade" }, "a shovel", "This is a mighty fine shovel");
        }

        [Test]
        public void TestBagLocateItems()
        {
            _bag.Inventory.Put(_shovel);

            Assert.That(_shovel, Is.EqualTo(_bag.Locate("shovel")));
        }

        [Test]
        public void TestBagLocateItself()
        {
            Assert.That(_bag, Is.EqualTo(_bag.Locate("bag")));
        }

        [Test]
        public void TestBagLocateNothing()
        {
            Assert.That(_bag.Locate("bazooka"), Is.EqualTo(null));
        }

        [Test]
        public void TestBagFullDescription()
        {
            _bag.Inventory.Put(_shovel);

            Assert.That(_bag.FullDescription, Is.EqualTo("In the bag you can see: \n  a shovel (shovel)\n"));
        }

        [Test]
        public void TestBagLocateStoredBag()
        {
            Bag _suitCase = new Bag(new String[] { "suitcase", "luggage" }, "suitcase", "This is a hefty suitcase");
            _bag.Inventory.Put(_suitCase);

            Assert.That(_suitCase, Is.EqualTo(_bag.Locate("suitcase")));
        }

        [Test]
        public void TestBagLocateItemsExceptBag()
        {
            Bag _suitCase = new Bag(new String[] { "suitcase", "luggage" }, "suitcase", "This is a hefty suitcase");
            _bag.Inventory.Put(_suitCase);
            _bag.Inventory.Put(_shovel);

            Assert.That(_shovel, Is.EqualTo(_bag.Locate("shovel")));
        }

        [Test]
        public void TestBagCannotLocateItemsInStoredBag()
        {
            Bag _suitCase = new Bag(new String[] { "suitcase", "luggage" }, "suitcase", "This is a hefty suitcase");
            _suitCase.Inventory.Put(_shovel);
            _bag.Inventory.Put(_suitCase);

            Assert.That(_bag.Locate("shovel"), Is.EqualTo(null));
        }
    }
}
