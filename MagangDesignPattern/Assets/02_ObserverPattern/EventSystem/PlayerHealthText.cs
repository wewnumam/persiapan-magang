using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Observer.EventSystem
{
    public class PlayerHealthText : MonoBehaviour
    {
        [SerializeField]
        private Text text;

        public void UpdateText(Component sender, object data)
        {
            if (data is int)
            {
                text.text = data.ToString();
            }
        }
    }
}