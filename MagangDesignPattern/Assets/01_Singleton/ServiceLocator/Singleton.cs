using Singleton.ExampleSingleton;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Singleton.ServiceLocator
{
    public class Singleton : MonoBehaviour
    {
        public static Singleton Instance { get; private set; }
        public AudioManager AudioManager { get; private set; }
        public UIManager UIManager { get; private set; }
        private void Awake()
        {
            if (Instance != null && Instance != this)
            {
                Destroy(this);
                return;
            }
            Instance = this;
            AudioManager = GetComponentInChildren<AudioManager>();
            UIManager = GetComponentInChildren<UIManager>();
        }
    }
}