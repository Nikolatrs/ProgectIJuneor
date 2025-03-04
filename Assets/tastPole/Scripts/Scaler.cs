using UnityEngine;

public class Scaler : MonoBehaviour
{
    [SerializeField] private float _speedChengeScale;
    private Vector3 _growth;

    private void FixedUpdate()
    {
        _growth = Vector3.one * _speedChengeScale;
        transform.localScale += _growth;
    }
}
