using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Frames : MonoBehaviour
{
    void Update()
    {
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, 535, 1210),
            Mathf.Clamp(transform.position.y, 410, 845), transform.position.z);
    }
}
