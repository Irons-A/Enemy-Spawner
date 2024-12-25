using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Enemy _enemy;
    [SerializeField] private int _enemyDestinationX = 1;
    [SerializeField] private int _enemyDestinationY = 1;

    public void SpawnEnemy ()
    {
        Instantiate(_enemy, transform.position, Quaternion.identity).SetDirection(_enemyDestinationX, _enemyDestinationY);
    }

}
