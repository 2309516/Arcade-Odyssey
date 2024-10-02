using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    private void Update()
    {
        transform.Rotate(0, .5f, 0);
    }
}
