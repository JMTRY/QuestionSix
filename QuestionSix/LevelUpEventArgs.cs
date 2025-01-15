namespace QuestionSix
{
    public class LevelUpEventArgs : EventArgs
    {
        public int NewLevel { get; }

        public LevelUpEventArgs(int newLevel)
        {
            NewLevel = newLevel;
        }
    }
}
