using UnityEngine;
using UnityEngine.UIElements;

public class Move : MonoBehaviour
{
    [SerializeField] private float _speed;
 
    private void Update()
    {
        transform.Translate(transform.forward * _speed, Space.World);
    }
}
