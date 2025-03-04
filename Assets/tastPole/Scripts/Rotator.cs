using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] private float _speedRotate;

    private void Update()
    {
        transform.Rotate(Vector3.up, _speedRotate * Time.deltaTime);
    }
}
