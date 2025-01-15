namespace QuestionSix
{
    class Program
    {
        static void Main(string[] args)
        {
            var player = new Player("Marc");
            var gameUI = new GameUI();
            player.LevelUp += gameUI.OnPlayerLevelUp;


            player.Score = 50;
            player.Score = 100;
            player.Score = 150;
        }
    }
}

