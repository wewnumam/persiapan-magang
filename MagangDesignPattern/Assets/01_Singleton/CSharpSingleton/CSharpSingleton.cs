using UnityEngine;

namespace Singleton.CSharpSingleton
{
    public class CSharpSingleton
    {
        private static CSharpSingleton instance = null;
        
        private float randomNumber;

        public static CSharpSingleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CSharpSingleton();
                }

                return instance;
            }
        }
        
        private CSharpSingleton()
        {
            randomNumber = Random.Range(0f, 1f);
        }

        public void ResetRandomNumber() => this.randomNumber = 0;

        public void TestSingleton()
        {
            Debug.Log($"Hello this is Singleton, my random number is: {randomNumber}");
        }
    }
}