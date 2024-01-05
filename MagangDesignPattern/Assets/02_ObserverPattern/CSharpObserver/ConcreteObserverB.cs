using UnityEngine;

namespace Observer.CSharpObserver
{
    class ConcreteObserverB : IObserver
    {
        public void Update(ISubject subject)
        {
            if ((subject as Subject).State == 0 || (subject as Subject).State >= 2)
            {
                Debug.Log("ConcreteObserverB: Reacted to the event.");
            }
        }
    }
}