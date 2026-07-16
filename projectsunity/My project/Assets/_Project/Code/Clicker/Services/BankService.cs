namespace _Project.Code
{
    public class BankService
    {
        private int _scoreValue;
        private int _scorePerclick = 1;

        public BankService(int score)
        {
            _scoreValue = score;
        }

        public int GetScore()
        {
            return _scoreValue;
        }
        
        public void SetScore()
        {
            _scoreValue += _scorePerclick;
        }
        public void UpdateScorePerclick(int updateValue)
        {
            _scorePerclick += updateValue;
        }
    }
}