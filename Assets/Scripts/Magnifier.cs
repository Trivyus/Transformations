using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magnifier : MonoBehaviour
{
    [SerializeField] private float _scaleSpeed = 0.2f;
    [SerializeField] private Vector3 _maxScale = new Vector3(2, 2, 2);

    void Update()
    {
        if (transform.localScale.x < _maxScale.x)
        {
            transform.localScale += Vector3.one * _scaleSpeed * Time.deltaTime;
        }
    }
}