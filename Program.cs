namespace Swin_Adventure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LookCommand _lookCommand = new LookCommand();
            Player _player = new Player("Nahid", "The epic programmer");
            Item _gem = new Item(new string[] { "gem", "shiny gem" }, "a gem", "This is a shiny green gem");
            Bag _bag = new Bag(new string[] { "bag", "backpack" }, "bag", "This is a big blue bag");

            _player.Inventory.Put(_gem);
            _player.Inventory.Put(_bag);
            string[] input1 = new string[] { "look", "at", "inventory" };
            Console.WriteLine(_lookCommand.Execute(_player, input1));
            string[] input2 = new string[] { "look", "at", "gem" };
            Console.WriteLine(_lookCommand.Execute(_player, input2));
            _bag.Inventory.Put(_gem);
            string[] input3 = new string[] { "look", "at", "bag" };
            Console.WriteLine(_lookCommand.Execute(_player, input3));
        }
    }
}