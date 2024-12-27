using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Spawner : MonoBehaviour
{
    [SerializeField] private List<SpawnPoint> _spawners = new List<SpawnPoint>();
    [SerializeField] private float _spawnRate = 1f;

    private Coroutine _spawnRoutine;

    private void Start()
    {
        _spawnRoutine = StartCoroutine(SpawnRoutine());
    }

    private IEnumerator SpawnRoutine()
    {
        WaitForSeconds spawnRate = new WaitForSeconds(_spawnRate);
        SpawnPoint selectedSpawner;

        while (enabled)
        {
            selectedSpawner = _spawners[Random.Range(0, _spawners.Count)];
            selectedSpawner.SpawnEnemy();
            yield return spawnRate;
        }
    }
}
