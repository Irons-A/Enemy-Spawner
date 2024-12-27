using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patroller : MonoBehaviour
{
    [SerializeField] private List<Waypoint> _route = new List<Waypoint>();
    [SerializeField] private float _movementSpeed = 2f;
    [SerializeField] private float _waypointReachAccuracy = 0.1f;

    [SerializeField] private int _currentWaypoint = 0;

    private Vector3 _offset;
    private float _sqrLength;

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position,
            _route[_currentWaypoint].transform.position, _movementSpeed * Time.deltaTime);

        _offset = _route[_currentWaypoint].transform.position - transform.position;
        _sqrLength = _offset.sqrMagnitude;

        if (_sqrLength < _waypointReachAccuracy * _waypointReachAccuracy)
        {
            _currentWaypoint = (_currentWaypoint + 1) % _route.Count;
        }
    }
}
