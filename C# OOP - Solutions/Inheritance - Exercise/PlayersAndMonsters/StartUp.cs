namespace PlayersAndMonsters
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string name = System.Console.ReadLine();
            int level = int.Parse(System.Console.ReadLine());

            var knight = new BladeKnight(name,level);

            System.Console.WriteLine(knight);
        }
    }
}