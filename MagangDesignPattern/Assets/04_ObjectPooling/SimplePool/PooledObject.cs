using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ObjectPooling.SimplePool
{
    public class PooledObject : MonoBehaviour
    {
        private ObjectPool pool;
        public ObjectPool Pool { get => pool; set => pool = value; }

        private void OnEnable()
        {
            Invoke(nameof(Release), 2f);
        }

        public void Release()
        {
            transform.position = Vector3.zero;
            pool.ReturnToPool(this);
        }
    }
}