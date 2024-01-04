using UnityEngine;

namespace Singleton.UnitySingleton
{
    public class AddTwoToScore : MonoBehaviour
    {
        public void AddToScore()
        {
            UnitySingleton.Instance.SetScore(UnitySingleton.Instance.Score + 2);
            Debug.Log("The Score Is: " + UnitySingleton.Instance.Score);
        }
    }
}