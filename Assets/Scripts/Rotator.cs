using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] private Vector3 _rotationSpeed;
    private void Update()
    {
        transform.Rotate(_rotationSpeed);
    }
}
