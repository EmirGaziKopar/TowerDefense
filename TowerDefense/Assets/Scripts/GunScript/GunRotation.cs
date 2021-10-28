using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunRotation : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(0, 1, 0);
        }
        if ((Input.GetKey(KeyCode.RightArrow)))
        {
            transform.Rotate(0, -1, 0);
        }
    }
}
