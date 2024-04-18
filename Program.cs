namespace Swin_Adventure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player("Nahid", "The epic programmer");
            Console.WriteLine(player.FullDescription);
        }
    }
}