using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Singleton.GenericSingleton
{
    public class AddScore : MonoBehaviour
    {
        public void Add(int amount)
        {
            Client.Instance.SetScore(Client.Instance.Score + amount);
            Debug.Log("The Score Is: " + Client.Instance.Score);
        }
    }
}