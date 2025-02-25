using System.ComponentModel.Design;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Experimental.Rendering;
using UnityEngine.UIElements;
using static UnityEngine.Rendering.DebugUI;

public class Scale : MonoBehaviour
{
    [SerializeField] private float _maxSize;
    [SerializeField] private float _startSize ;
    [SerializeField] float _speedChengeScale;
    private int factor;

    private float currentSize;

    private void Start()
    {
        factor = setCoefficient((Vector3.one * _startSize).magnitude , (Vector3.one * _maxSize).magnitude, transform.localScale.magnitude);


        currentSize = _startSize;
    }

    private void FixedUpdate()
    {
        factor = setCoefficient((Vector3.one * _startSize).magnitude, (Vector3.one * _maxSize).magnitude, transform.localScale.magnitude,factor);
        currentSize += _speedChengeScale * factor;
        Changeobget(currentSize);

    }

    private void Changeobget(float currentSizeF)
    {
        transform.localScale = Vector3.one * _startSize * currentSizeF;
        if (transform.localScale.x < 0 || transform.localScale.y < 0 || transform.localScale.z < 0) transform.localScale = Vector3.one * _startSize;
        if (transform.localScale.magnitude > (Vector3.one * _maxSize).magnitude) transform.localScale = Vector3.one * _maxSize;
        if (transform.localScale.magnitude < (Vector3.one * _startSize).magnitude) transform.localScale = Vector3.one * _startSize;
    }

    private int setCoefficient(float min, float max, float Value, int startCoefficient=1)
    {
        if (Value >= max) return -1;
        if (Value <= min) return 1;
        return startCoefficient; 
    }

}
