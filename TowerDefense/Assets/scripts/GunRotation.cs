using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunRotation : MonoBehaviour
{
    public static Transform gunTransform;

    private void Update()
    {

        gunTransform.rotation = Quaternion.Euler(transform.rotation.x,transform.rotation.y,transform.rotation.z);
        gunTransform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);

    }
}
