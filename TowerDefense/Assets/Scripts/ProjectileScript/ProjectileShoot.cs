using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileShoot : MonoBehaviour
{
    new Rigidbody rigidbody;   
    public float time = 0f;
    [SerializeField] float speed;   
    
    float projectileLifeCycle;

    

    public enum SelectGun
    {
        low,medium,notBad,hard,veryHard
    }



    [SerializeField]SelectGun selectGun;

    private void Start()
    {


        
        rigidbody = GetComponent<Rigidbody>();

        //GunTransform = GetComponent<Transform>();

        if (selectGun == SelectGun.low)
        {
            //ozelleþtirme
        }
        if(selectGun == SelectGun.medium)
        {
            //ozelleþtirme
        }
        if (selectGun == SelectGun.hard)
        {
            //ozelleþtirme
        }







    }

    private void Update()
    {
        
        
        shoot();
        
        
    }

    public void shoot()
    {
        if (time < 0.1) //velocity'nin etki edeceði süre
        {
            
            time += Time.deltaTime;
            //Burada neden transform deðerini mermiden deðil de silahtan aldýk:
            //çünkü mermi hareket halindeyken unity uzayýnda yer çekimi kuvvetine maruz kalýr ve top'un yönü sürekli olarak deðiþir bu nedenle top düzensiz hareketler sergiler.

            
            if (selectGun == SelectGun.low)
            {
                Vector3 a = new Vector3(-transform.forward.x, 0f, -transform.forward.z); //Topun karsiya gitmesini saglayan z.
                                                                                               //Vector3 a = new Vector3(-GunRotation.gunTransform.forward.x, 0f, -GunRotation.gunTransform.forward.z);
                rigidbody.velocity = a * speed *LookAtTheEnemy.distance;
            }
            if (selectGun == SelectGun.medium)
            {
                Vector3 a = new Vector3(-transform.forward.x, -0.005f, -transform.forward.z); //Topun karsiya gitmesini saglayan z.
                                                                                               //Vector3 a = new Vector3(-GunRotation.gunTransform.forward.x, 0f, -GunRotation.gunTransform.forward.z);
                rigidbody.velocity = a * speed *LookAtTheEnemy.distance;
            }

            if (selectGun == SelectGun.notBad)
            {
                Vector3 a = new Vector3(transform.forward.x, -0.1f, transform.forward.z); //Topun karsiya gitmesini saglayan z.
                                                                                         //Vector3 a = new Vector3(-GunRotation.gunTransform.forward.x, 0f, -GunRotation.gunTransform.forward.z);
                rigidbody.velocity = a * speed * 5;
            }

            if (selectGun == SelectGun.hard)
            {
                Vector3 a = new Vector3(transform.forward.x, -0.1f, transform.forward.z); //Topun karsiya gitmesini saglayan z.
                                                                                                    //Vector3 a = new Vector3(-GunRotation.gunTransform.forward.x, 0f, -GunRotation.gunTransform.forward.z);
                rigidbody.velocity = a * speed * LookAtTheEnemy.distance;
            }


        }

        projectileLifeCycle += Time.deltaTime;

        if (projectileLifeCycle > 1)
        {
            Destroy(this.gameObject);
            projectileLifeCycle = 0;
        }


    }


    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "enemy")
        {
            Destroy(this.gameObject);
        }
        if(collision.gameObject.tag == "Ground")
        {
            Destroy(this.gameObject);
        }
    }
}
