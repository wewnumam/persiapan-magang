using UnityEngine;
using UnityEngine.Events;

namespace Observer.EventSystem
{
    [System.Serializable]
    public class CustomGameEvent : UnityEvent<Component, object> { }
}