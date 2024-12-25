using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnController : MonoBehaviour
{
    [SerializeField] private List<Spawner> _spawners = new List<Spawner>();
    [SerializeField] private float _spawnRate = 1f;

    private Coroutine _spawnRoutine;
    private bool _isActive = true;

    private void Start()
    {
        _spawnRoutine = StartCoroutine(SpawnRoutine());
    }

    private IEnumerator SpawnRoutine()
    {
        WaitForSeconds spawnRate = new WaitForSeconds(_spawnRate);
        Spawner selectedSpawner;

        while (_isActive)
        {
            selectedSpawner = _spawners[Random.Range(0, _spawners.Count)];
            selectedSpawner.SpawnEnemy();
            yield return spawnRate;
        }
    }
}
