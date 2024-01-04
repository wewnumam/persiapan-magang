using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Singleton.GenericSingleton
{
    public class Client : GenericSingleton<Client>
    {
        [HideInInspector]
        private int _score;
        public int Score { get => _score; }

        public void SetScore(int score)
        {
            _score = score;
        }
    }
}