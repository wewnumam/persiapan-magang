using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Singleton.CSharpSingleton
{
    public class GameController : MonoBehaviour
    {
        private void Awake()
        {
            CSharpSingleton.Instance.TestSingleton();
            
            CSharpSingleton instance = CSharpSingleton.Instance;

            instance.TestSingleton();

            CSharpSingleton instance2 = CSharpSingleton.Instance;

            instance2.TestSingleton();

            instance.TestSingleton();

            CSharpSingleton.Instance.TestSingleton();

            CSharpSingleton.Instance.ResetRandomNumber();

            CSharpSingleton instance3 = CSharpSingleton.Instance;

            instance3.TestSingleton();
            instance2.TestSingleton();
            instance.TestSingleton();

            CSharpSingleton.Instance.TestSingleton();
        }
    }
}
