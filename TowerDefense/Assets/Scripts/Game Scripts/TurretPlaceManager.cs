using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretPlaceManager : MonoBehaviour
{

    public GameObject ObjtoMove;
    public GameObject objtoPlace;
    public LayerMask mask;
    public Vector3 mousePos;
    public float LastPosY;
    Renderer rend;
    public Material matGrid, matDefault;


    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        mousePos = Input.mousePosition;
        Ray ray = Camera.main.ScreenPointToRay(mousePos);
        RaycastHit hit;
        if(Physics.Raycast(ray, out hit, Mathf.Infinity, mask))
        {
            int Posx = (int)Mathf.Round(hit.point.x);
            int Posz = (int)Mathf.Round(hit.point.z);
            ObjtoMove.transform.position = new Vector3(Posx, LastPosY, Posz);


        }

        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("buraya girdi");
            Instantiate(objtoPlace, ObjtoMove.transform.position, Quaternion.identity);
            Destroy(gameObject);



        }







    }
}
