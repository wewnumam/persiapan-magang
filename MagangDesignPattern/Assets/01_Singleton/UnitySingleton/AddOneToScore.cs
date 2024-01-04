using UnityEngine;

namespace Singleton.UnitySingleton
{
    public class AddOneToScore : MonoBehaviour
    {
        public void AddToScore()
        {
            UnitySingleton.Instance.SetScore(UnitySingleton.Instance.Score + 1);
            Debug.Log("The Score Is: " + UnitySingleton.Instance.Score);
        }
    }
}