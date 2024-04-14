using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragIcon : MonoBehaviour
{
    public void SetPosition(Transform obj)
    {
        obj.position = Input.mousePosition;
    }
}
