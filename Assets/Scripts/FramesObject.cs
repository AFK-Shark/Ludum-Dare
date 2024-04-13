using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FramesObject : MonoBehaviour
{
    void Update()
    {
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, 722, 1024),
            Mathf.Clamp(transform.position.y, 565, 690), transform.position.z);
    }
}