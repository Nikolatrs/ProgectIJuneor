using UnityEngine;

public class MoveCicle1 : MonoBehaviour
{
    [SerializeField] private Transform[] _checkpoints;
    [SerializeField] private float _speed;

    private int _currentCheckpoint = 0;

    void Update()
    {
        if (transform.position == _checkpoints[_currentCheckpoint].position)
        { 
            _currentCheckpoint = (_currentCheckpoint +1)%_checkpoints.Length;
        }
        transform.position = Vector3.MoveTowards(transform.position, _checkpoints[_currentCheckpoint].position, _speed*Time.deltaTime);
    }
}
