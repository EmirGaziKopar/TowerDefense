using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragManager : MonoBehaviour
{
   
    public GameObject objtoPlace;
    public LayerMask mask;
    public Vector3 mousePos;
    public float LastPosY;
    Renderer rend;
    public Material matGrid, matDefault;
    public bool isDraging;


    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("0"))
        {
            isDraging = true;

            mousePos = Input.mousePosition;
            Ray ray = Camera.main.ScreenPointToRay(mousePos);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, Mathf.Infinity, mask))
            {
                int Posx = (int)Mathf.Round(hit.point.x);
                int Posz = (int)Mathf.Round(hit.point.z);
                objtoPlace.transform.position = new Vector3(Posx, LastPosY, Posz);


            }
        }
        else
        {

            isDraging = false;
        }

        if (isDraging)
        {

            rend.material = matGrid;
        }
        else
        {
            if (!isDraging)
            {

                rend.material = matDefault;
            }

        }

    }
}
