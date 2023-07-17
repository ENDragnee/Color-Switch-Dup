using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateR : MonoBehaviour
{
    public float speed=100;

    private void Update()
    {
        transform.Rotate(0, 0, speed*Time.deltaTime);
    }
}
