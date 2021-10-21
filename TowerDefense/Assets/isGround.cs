using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class isGround : MonoBehaviour
{
    GameObject mermi;

    public bool isGrounded;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        


    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "projectile") //degen obje mermiyse
        {
            mermi = collision.gameObject; //referansýný aldýk
            Destroy(mermi); //mermi yok oldu mermi içersindeki patlama effectiini setActive yap
            isGrounded = true;
        }
    }
}
