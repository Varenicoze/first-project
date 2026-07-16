using _Project.Code;
using Project.Game;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;
namespace Project.Code.Clicker.Skin
{
    public class SkinController : MonoBehaviour
    {
        [SerializeField] private Observer _observer;
        [SerializeField] private Image _imageBG;
        [SerializeField] private ColorItem[] _colorItems;
        
        private BankService _bankService;

        private void Awake()
        {
            _bankService = _observer.GetBank();
          _imageBG.color = _colorItems[Random.Range(0, _colorItems.Length - 1)].Color;
        }
    }
}