using UnityEngine;

namespace Singleton.ExampleSingleton
{
    public class GameplayManager : MonoBehaviour
    {
        public static GameplayManager instance;

        private int score;
        private int killCount;

        private void Awake()
        {
            if (instance == null)
                instance = this;
            else
                Destroy(gameObject);

            DontDestroyOnLoad(gameObject);
        }

        public int GetScore()
        {
            return score;
        }

        public int GetKillCount()
        {
            return killCount;
        }

        public void IncreaseScore(int amount)
        {
            score += amount;
        }

        public void IncreaseKillCount(int amount)
        {
            killCount += amount;
        }
    }
}