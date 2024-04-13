using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrameMail : MonoBehaviour
{
    void Update()
    {
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, 545, 1200),
            Mathf.Clamp(transform.position.y, 410, 845), transform.position.z);
    }
}