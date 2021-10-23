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
    Transform enemyBody;
    Rigidbody rigidbody;
    GameObject enemy;
    public static float distance;
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
            enemyBody = enemy.GetComponent<Transform>();
            body.transform.LookAt(enemyBody);
            distance = Vector3.Distance(enemyBody.position, transform.position);
            Debug.Log("Distance: " + distance);
        }
        

        
        

        transform.eulerAngles = new Vector3(0, transform.eulerAngles.y, 0); //bu kod sayesinde silah zemine yapýþýyor ve aþaðý yukarý bakmýyor.

    }

    

    private void OnTriggerStay(Collider other)
    {
        Debug.Log("Buraya girildi");
        if (other.CompareTag("enemy"))
        {
            Debug.Log("Buraya girildi");
            enemy = other.gameObject;

            isEnemy = true;
        }
        else
        {
            isEnemy = false;
        }
    }
}
