namespace QuestionSix
{
    public delegate void LevelUpEventHandler(object sender, LevelUpEventArgs e);

    public class Player
    {
        public event LevelUpEventHandler LevelUp;

        private int _score;
        private int _level;

        public string Name { get; }
        public int Score
        {
            get { return _score; }
            set
            {
                _score = value;
                if (_score >= 100)
                {
                    _level++;
                    OnLevelUp(new LevelUpEventArgs(_level));
                    _score = 0;
                }
            }
        }

        public Player(string name)
        {
            Name = name;
            _level = 1;
            _score = 0;
        }

        protected virtual void OnLevelUp(LevelUpEventArgs e)
        {
            LevelUp?.Invoke(this, e);
        }
    }
}
