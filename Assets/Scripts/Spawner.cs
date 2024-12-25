using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Enemy _enemy;
    [SerializeField] private int _enemyDestinationX = 1;
    [SerializeField] private int _enemyDestinationY = 1;

    private SpawnController _spawnController;

    private void Awake()
    {
        _spawnController = FindObjectOfType<SpawnController>();
        _spawnController.SpawnerSelected += SpawnEnemy;
    }

    private void OnEnable()
    {
        _spawnController.SpawnerSelected += SpawnEnemy;
    }

    private void OnDisable()
    {
        _spawnController.SpawnerSelected -= SpawnEnemy;
    }

    private void SpawnEnemy (Spawner spawner)
    {
        if (spawner == this)
        {
            Instantiate(_enemy, transform.position, Quaternion.identity)
                .GetComponent<Enemy>().SetDirection(_enemyDestinationX, _enemyDestinationY);
        }
    }

}
