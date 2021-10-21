using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootControl : MonoBehaviour
{
    public bool isFire = false;

    


    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "projectile")
        {
            Debug.Log("Buraya girdi");
            isFire = true; //ýcýndeyken
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "projectile")
        {
            isFire = false; //ýcýndeyken
        }
    }


}
