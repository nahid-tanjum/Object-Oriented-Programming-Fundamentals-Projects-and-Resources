using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Swin_Adventure;
using NUnit.Framework;

namespace Swin_AdventureUnitTests
{
    [TestFixture]
    public class LookCommandTests
    {
        private LookCommand _lookCommand;
        private Player _player;
        private Bag _bag;
        private Item _gem;

        [SetUp]
        public void SetUp()
        {
            _lookCommand = new LookCommand();
            _player = new Player("Fred", "the mighty programmer");
            _bag = new Bag(new string[] { "bag", "backpack" }, "bag", "This is a big blue bag");
            _gem = new Item(new string[] { "gem", "shiny gem" }, "gem", "This is a shiny green gem");
        }

        [Test]
        public void TestLookAtMe()
        {
            _player.Inventory.Put(_gem);
            _player.Inventory.Put(_bag);
            string[] input = new[] { "look", "at", "inventory" };
            Assert.That(_lookCommand.Execute(_player, input), Is.EqualTo("You are Fred, the mighty programmer.\nYou are carrying: \n  gem (gem)\n  bag (bag)\n"));
        }

        [Test]
        public void TestLookAtGem()
        {
            _player.Inventory.Put(_gem);
            string[] input = new[] { "look", "at", "gem" };
            Assert.That(_lookCommand.Execute(_player, input), Is.EqualTo("This is a shiny green gem"));
        }

        [Test]
        public void TestLookAtUnk()
        {
            string[] input = new[] { "look", "at", "gem" };
            Assert.That(_lookCommand.Execute(_player, input), Is.EqualTo("I cannot find the gem"));
        }

        [Test]
        public void TestLookAtGemInMe()
        {
            _player.Inventory.Put(_gem);
            string[] input = new[] { "look", "at", "gem", "in", "inventory" };
            Assert.That(_lookCommand.Execute(_player, input), Is.EqualTo("This is a shiny green gem"));
        }

        [Test]
        public void TestLookAtGemInBag()
        {
            _bag.Inventory.Put(_gem);
            _player.Inventory.Put(_bag);
            string[] input = new[] { "look", "at", "gem", "in", "bag" };
            Assert.That(_lookCommand.Execute(_player, input), Is.EqualTo("This is a shiny green gem"));
        }

        [Test]
        public void TestLookAtGemInNoBag()
        {
            string[] input = new[] { "look", "at", "gem", "in", "bag" };
            Assert.That(_lookCommand.Execute(_player, input), Is.EqualTo("I cannot find the bag"));
        }

        [Test]
        public void TestLookAtNoGemInBag()
        {
            _player.Inventory.Put(_bag);
            string[] input = new[] { "look", "at", "gem", "in", "bag" };
            Assert.That(_lookCommand.Execute(_player, input), Is.EqualTo("I cannot find the gem in the bag"));
        }

        [Test]
        public void TestInvalidLook()
        {
            Assert.That(_lookCommand.Execute(_player, new string[] { }), Is.EqualTo("I don't know how to look there"));
            Assert.That(_lookCommand.Execute(_player, new string[] { "find", "the", "gem" }), Is.EqualTo("Error in look input"));
            Assert.That(_lookCommand.Execute(_player, new string[] { "look", "for", "gem" }), Is.EqualTo("What do you want to look at?"));
            Assert.That(_lookCommand.Execute(_player, new string[] { "look", "at", "a", "at", "b" }), Is.EqualTo("What do you want to look in?"));
            Assert.That(_lookCommand.Execute(_player, new string[] { "look", "around" }), Is.EqualTo("I don't know how to look there"));
            Assert.That(_lookCommand.Execute(_player, new string[] { "hello" }), Is.EqualTo("I don't know how to look there"));
        }
    }
}
