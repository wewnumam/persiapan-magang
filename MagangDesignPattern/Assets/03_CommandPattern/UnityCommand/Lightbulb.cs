using UnityEngine;
using UnityEngine.UI;

namespace Command.UnityCommand
{
    public class Lightbulb : MonoBehaviour
    {
        public Image light;
        private bool isPowerOn;

        public void TogglePower()
        {
            Color modifedColor = light.color;
            if (isPowerOn)
            {
                modifedColor.a = 0;
                light.color = modifedColor;
                isPowerOn = false;
            }
            else
            {
                modifedColor.a = 1;
                light.color = modifedColor;
                isPowerOn = true;
            }
        }

        public void SetLightColor(Color color)
        {
            light.color = color;
        }

        public void SetRandomLightColor()
        {
            light.color = GenerateRandomColor();
        }

        private Color GenerateRandomColor()
        {
            float randomRed = Random.Range(0f, 1f);
            float randomGreen = Random.Range(0f, 1f);
            float randomBlue = Random.Range(0f, 1f);
            float randomAlpha = 1f; // Alpha value, 1.0 for fully opaque

            return new Color(randomRed, randomGreen, randomBlue, randomAlpha);
        }
    }
}