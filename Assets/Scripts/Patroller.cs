using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patroller : MonoBehaviour
{
    [SerializeField] private List<Waypoint> _route = new List<Waypoint>();
    [SerializeField] private float _movementSpeed = 2f;
    [SerializeField] private float _waypointReachAccuracy = 0.1f;

    [SerializeField] private int _currentWaypoint = 0;

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position,
            _route[_currentWaypoint].transform.position, _movementSpeed * Time.deltaTime);

        if (Vector2.Distance(transform.position, _route[_currentWaypoint].transform.position) <= _waypointReachAccuracy)
        {
            if (_currentWaypoint < _route.Count-1)
            {
                _currentWaypoint++;
            }
            else
            {
                _currentWaypoint = 0;
            }
        }
    }
}
