using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;

namespace ObjectPooling.UnityPool
{
    public class Spawner : MonoBehaviour
    {
        [SerializeField]
        private Shape _shapePrefab;
        
        [SerializeField]
        private int _spawnAmount;

        [SerializeField]
        private bool _usePool;

        private ObjectPool<Shape> _pool;

        private void Start()
        {
            _pool = new ObjectPool<Shape>(() =>
            {
                return Instantiate(_shapePrefab);
            }, (shape) =>
            {
                shape.gameObject.SetActive(true);
            }, (shape) =>
            {
                shape.gameObject.SetActive(false);
            }, (shape) =>
            {
                Destroy(shape.gameObject);
            }, false, 10, 20);

            InvokeRepeating(nameof(Spawn), .2f, .2f);
        }

        private void Spawn()
        {
            for (int i = 0; i < _spawnAmount; i++)
            {
                var shape = _usePool ? _pool.Get() : Instantiate(_shapePrefab);
                shape.transform.position = transform.position + Random.insideUnitSphere * 10;
                shape.Init(KillShape);
            }
        }

        private void KillShape(Shape shape)
        {
            if (_usePool)
                _pool.Release(shape);
            else
                Destroy(shape.gameObject);
        }
    }
}