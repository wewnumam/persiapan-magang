using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ObjectPooling.BrackeysObjectPooling
{
    public class CubeSpawner : MonoBehaviour
    {
        private void Start()
        {
            InvokeRepeating("Spawn", 1, .25f);
        }

        private void Spawn()
        {
            ObjectPooler.Instance.SpawnFromPool("Cube", transform.position, Quaternion.identity);
        }
    }
}