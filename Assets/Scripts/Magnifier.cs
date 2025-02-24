using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magnifier : MonoBehaviour
{
    [SerializeField] private float scaleSpeed = 0.2f;
    [SerializeField] private Vector3 maxScale = new Vector3(2, 2, 2);

    void Update()
    {
        if (transform.localScale.x < maxScale.x)
        {
            transform.localScale += Vector3.one * scaleSpeed * Time.deltaTime;
        }
    }
}