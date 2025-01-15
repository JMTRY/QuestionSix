namespace QuestionSix
{
    public class GameUI
    {
        public void OnPlayerLevelUp(object sender, LevelUpEventArgs e)
        {
            Console.WriteLine($"Congratulations! The player leveled up to level {e.NewLevel}!");
        }
    }
}
