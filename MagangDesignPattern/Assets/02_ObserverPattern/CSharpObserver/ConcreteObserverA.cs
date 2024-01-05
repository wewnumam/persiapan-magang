using UnityEngine;

namespace Observer.CSharpObserver
{
    // Concrete Observers react to the updates issued by the Subject they had
    // been attached to.
    class ConcreteObserverA : IObserver
    {
        public void Update(ISubject subject)
        {
            if ((subject as Subject).State < 3)
            {
                Debug.Log("ConcreteObserverA: Reacted to the event.");
            }
        }
    }
}