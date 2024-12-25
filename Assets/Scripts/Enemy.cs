using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float _movementSpeed = 1f;

    private int _destinationX = 0;
    private int _destinationY = 0;

    private void Update()
    {
        transform.position = new Vector3(_destinationX, _destinationY, gameObject.transform.position.z) * Time.deltaTime * _movementSpeed;
    }

    public void SetDirection(int x, int y)
    {
        _destinationX = x;
        _destinationY = y;
    }
}
