using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtTheEnemy : MonoBehaviour
{

    Quaternion neededRotation;
    [SerializeField] float rotationSpeed;
    float x;
    float y;
    float z;
    bool isEnemy;
    Transform body; //destination
    Transform enemyBody; //source
    Rigidbody rigidbody;
    GameObject enemy;
    public static int sayac=0; //Obje destroy olmadan sayac = 0 olmalý
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

            
            
            if(enemy != null) //eðer enemy null olduðu durumlarda da referans alma kodu çalýþýrsa referans alýnamaz ve hata döner. O nedenle burada bu kontrolü yapýyoruz.
            {
                enemyBody = enemy.GetComponent<Transform>();

                //direction = destination(enemy) - source(Our Gun)
                Vector3 direction = enemyBody.position - transform.position;

                //access our current rotation = Quaternion Look Rotation
                neededRotation = Quaternion.LookRotation(direction);

                //for slowly turn 
                transform.rotation = Quaternion.Slerp(this.transform.rotation, neededRotation, Time.deltaTime * rotationSpeed);
                
                distance = Vector3.Distance(enemyBody.position, transform.position);
                Debug.Log("Distance: " + distance);
            }
            
            

            //body.transform.LookAt(enemyBody);



            
        }
        

        
        

        transform.eulerAngles = new Vector3(0, transform.eulerAngles.y, 0); //bu kod sayesinde silah zemine yapýþýyor ve aþaðý yukarý bakmýyor.

    }

    

    private void OnTriggerStay(Collider other)
    {
        Debug.Log("Buraya girildi");
        if (other.CompareTag("enemy") && sayac == 0)
        {
            sayac++;
            Debug.Log("Buraya girildi");
            enemy = other.gameObject;
            isEnemy = true;
        }
        /*else
        {
            isEnemy = false;
        }*/
    }
    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Buraya girildi");
        if (other.CompareTag("enemy"))
        {
            sayac = 0;
            Debug.Log("Buraya girildi Exit");
            enemy = other.gameObject;
            isEnemy = false;
        }
        /*else
        {
            isEnemy = false;
        }*/
    }
}
