using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReviewTurrets : MonoBehaviour
{

    public GameObject objtoCreate;
    RaycastHit hit;
    public Material materyal;
    bool canCreat;
    // Start is called before the first frame update
    void Start()
    {
        canCreat = true;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);


        if(Physics.Raycast(ray, out hit, 5000f,(1<<6)))
        {
            transform.position = hit.point;


        }
       
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject != null && !other.gameObject.CompareTag("Zemin"))
        {

            GetComponent<MeshRenderer>().material.color = Color.red;
            canCreat = false;

        }
    }



    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject != null && !other.gameObject.CompareTag("Zemin"))
        {

            GetComponent<MeshRenderer>().material = materyal;
            canCreat = true;

        }
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        
        if (Physics.Raycast(ray, out hit, 5000f,1<<6))
        {
            // transform.position = hit.point;
            transform.position = new Vector3(hit.point.x, hit.point.y + .5f, hit.point.z);


        }
        if (Input.GetMouseButtonDown(0))
        {

            if(canCreat){

                Instantiate(objtoCreate, transform.position, transform.rotation);
                Destroy(gameObject);

            }
           

        }
    }
}
