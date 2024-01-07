using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ObjectPooling.BrackeysObjectPooling
{
    public class Cube : MonoBehaviour, IPooledObject
    {
        public float upForce = 1f;
        public float sideForce = .1f;

        public void OnObjectSpawn()
        {
            float xForce = Random.Range(-sideForce, sideForce);
            float yForce = Random.Range(upForce/2, upForce);
            float zForce = Random.Range(-sideForce, sideForce);
            
            Vector3 force = new Vector3(xForce, yForce, zForce);

            GetComponent<Rigidbody>().velocity = force;
        }
    }
}