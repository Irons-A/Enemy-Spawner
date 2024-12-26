using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float _movementSpeed = 2f;

    private Patroller _target;

    private void Update()
    {
        if (_target != null)
        {
            transform.position = Vector3.MoveTowards(transform.position, 
                _target.transform.position, _movementSpeed * Time.deltaTime);
        }
    }

    public void SetTarget(Patroller target)
    {
        _target = target;
    }
}
