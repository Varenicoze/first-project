using UnityEngine;
namespace Project.Game
{
    public class CollectionExample  : MonoBehaviour
    {
        [SerializeField] private int[] _numbers;
        private void Awake()
        {
            foreach (var text in _numbers)
            {
                Debug.Log(text);
            }
        }
    }
}