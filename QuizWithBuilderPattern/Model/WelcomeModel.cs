using QuizWithBuilderPattern.Common;

namespace QuizWithBuilderPattern.Model
{
    public class WelcomeModel
    {
        private string _playerName;
        public string PlayerName { get { return _playerName; } set { _playerName = value; PlayerInfo.Name = _playerName; } }
    }
}
