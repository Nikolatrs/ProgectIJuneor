using UnityEngine;

public class MoveByCircle : MonoBehaviour
{
    [SerializeField] private float _speedRotate;
    [SerializeField] private float _coefficientRotation;

    private void Update()
    { 
        transform.Translate(Vector3.forward * _speedRotate * Time.deltaTime);
        transform.Rotate(Vector3.up, _speedRotate * _coefficientRotation * Time.deltaTime);
    }
}