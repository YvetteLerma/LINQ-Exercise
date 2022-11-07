namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            var videoGameList = new List<string>() { "Minecraft", "CoD", "Halo", "Little Big Planet", "FortNite" };


            //var gamesListOrdered = videoGameList.OrderBy(name => name.Length).ToList();

            //foreach (var game in gamesListOrdered)
            //{
            //    Console.WriteLine(game);
            //}

            //gamesListOrdered.ForEach(Console.WriteLine);

            videoGameList.OrderBy(name => name.Length).ToList().ForEach(Console.WriteLine);
        }
    }
}
