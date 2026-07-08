using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace Project.Game
{
    public class CollectionExample : MonoBehaviour
    {
        [SerializeField] private TMP_Text[] _headers = new TMP_Text[2];
        [SerializeField] private List<string> _listHeaders;
        [SerializeField] private bool _isWhileActive;
        
        private void Awake()
        {
_listHeaders.Add("Hello");
_listHeaders.Add("Hello");
            for (int i = 0; i < _headers.Length; i++)
            {
                if (i == 0)
                {
                    _headers[i].text = string.Empty;
                }
                _headers[i].SetText("");
            }

            foreach (var text in _headers)
            {
                text.SetText("Clicker Game");
            }
        }
    }
}