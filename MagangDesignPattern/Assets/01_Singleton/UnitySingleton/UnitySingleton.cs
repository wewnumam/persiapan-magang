using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Singleton.UnitySingleton
{
    public class UnitySingleton : MonoBehaviour
    {
        public static UnitySingleton Instance { get; private set; }

        [HideInInspector]
        private int _score;
        public int Score { get => _score; }

        private void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
            }
            else
            {
                Destroy(gameObject);
            }
        }

        public void SetScore(int score)
        {
            _score = score;
        }
    }
}