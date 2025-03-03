using UnityEngine;

public class Scale : MonoBehaviour
{
    [SerializeField] private float _speedChengeScale;
    private Vector3 _currentSize;

    private void FixedUpdate()
    {
        _currentSize = Vector3.one * _speedChengeScale;
        transform.localScale += _currentSize;
    }
}
