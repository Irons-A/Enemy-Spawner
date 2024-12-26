using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Enemy _enemy;
    [SerializeField] private Patroller _target;

    public void SpawnEnemy ()
    {
        Instantiate(_enemy, transform.position, Quaternion.identity).SetTarget(_target);
    }

}
