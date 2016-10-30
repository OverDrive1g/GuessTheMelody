namespace GuessTheMelody.Core
{
    class User
    {
        public string _name;
        public string _level;
        public int _score;

        public User(string name, string level, int score)
        {
            _name = name;
            _level = level;
            _score = score;
        }
    }
}
