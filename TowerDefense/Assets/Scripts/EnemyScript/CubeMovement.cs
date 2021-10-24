using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovement : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W)){
            transform.Translate(transform.right*5f*Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(-transform.right * 5f * Time.deltaTime);
        }
        transform.Translate(-transform.right * 2f * Time.deltaTime);
    }  
}
