using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtTheEnemy : MonoBehaviour
{

    float x;
    float y;
    float z;
    bool isEnemy;
    Transform body;
    Rigidbody rigidbody;
    [SerializeField] Transform enemy;
    // Start is called before the first frame update
    void Start()
    {
        body = this.GetComponent<Transform>();
        x = transform.rotation.x;
        y = transform.rotation.y;
        z = transform.rotation.z;
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isEnemy == true)
        {
            body.transform.LookAt(enemy);
        }
        body.transform.LookAt(enemy);

        transform.eulerAngles = new Vector3(0, transform.eulerAngles.y, 0);

    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Enemy")
        {
            Debug.Log("Buraya girildi");
            enemy = other.gameObject.transform.GetComponent<Transform>();
            isEnemy = true;
        }
        else
        {
            isEnemy = false;
        }
    }
}
