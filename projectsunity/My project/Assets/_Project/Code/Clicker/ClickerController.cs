using _Project.Code;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Project.Game
{
    public class ClickerController : MonoBehaviour
    {
        [SerializeField] private Observer _observer;
        [SerializeField] private TMP_Text _textScore;
        [SerializeField] private Button _buttonClicker;
    
        private BankService _bankService;
        private object _scoreValue;
        private string _score;

        private void Awake()
        {
            _bankService = _observer.GetBank();
            UpdateTextScore();
            _buttonClicker.onClick.AddListener(UpdateScore);
        }

        private void OnDestroy()
        {
            _buttonClicker.onClick.RemoveListener(UpdateScore);
        }

        private void UpdateScore()
        {
            _observer.GetBank().SetScore();
            UpdateTextScore();
        }
        private void UpdateTextScore()
        {
            _textScore.SetText($"${_bankService.GetScore().ToString()}");
        }
    }
}

