using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileShoot : MonoBehaviour
{
    new Rigidbody rigidbody;
    Transform GunTransform;
    
    public float time = 0f;
    [SerializeField] float speed;   
    
    float projectileLifeCycle;

    

    public enum SelectGun
    {
        low,medium,hard
    }

    [SerializeField]SelectGun selectGun;

    private void Start()
    {


        
        rigidbody = GetComponent<Rigidbody>();

        //GunTransform = GetComponent<Transform>();

        if (selectGun == SelectGun.low)
        {
            GunTransform = GameObject.Find("GunRotation").GetComponent<Transform>();
        }
        if(selectGun == SelectGun.medium)
        {
            GunTransform = GameObject.Find("GunRotation2").GetComponent<Transform>();
        }
        if (selectGun == SelectGun.hard)
        {
            GunTransform = GameObject.Find("GunRotation3").GetComponent<Transform>();
        }







    }

    private void Update()
    {
        
        
        shoot();
        
        
    }

    public void shoot()
    {
        if (time < 0.1) //velocity'nin etki edece�i s�re
        {
            
            time += Time.deltaTime;
            //Burada neden transform de�erini mermiden de�il de silahtan ald�k:
            //��nk� mermi hareket halindeyken unity uzay�nda yer �ekimi kuvvetine maruz kal�r ve top'un y�n� s�rekli olarak de�i�ir bu nedenle top d�zensiz hareketler sergiler.

            
            if (selectGun == SelectGun.low)
            {
                Vector3 a = new Vector3(-GunTransform.forward.x, 0f, -GunTransform.forward.z); //Topun karsiya gitmesini saglayan z.
                                                                                               //Vector3 a = new Vector3(-GunRotation.gunTransform.forward.x, 0f, -GunRotation.gunTransform.forward.z);
                rigidbody.velocity = a * speed *LookAtTheEnemy.distance;
            }
            if (selectGun == SelectGun.medium)
            {
                Vector3 a = new Vector3(-GunTransform.forward.x, -0.005f, -GunTransform.forward.z); //Topun karsiya gitmesini saglayan z.
                                                                                               //Vector3 a = new Vector3(-GunRotation.gunTransform.forward.x, 0f, -GunRotation.gunTransform.forward.z);
                rigidbody.velocity = a * speed *LookAtTheEnemy.distance;
            }

            if (selectGun == SelectGun.hard)
            {
                Vector3 a = new Vector3(GunTransform.forward.x, -0.1f, GunTransform.forward.z); //Topun karsiya gitmesini saglayan z.
                                                                                                    //Vector3 a = new Vector3(-GunRotation.gunTransform.forward.x, 0f, -GunRotation.gunTransform.forward.z);
                rigidbody.velocity = a * speed * LookAtTheEnemy.distance;
            }


        }

        projectileLifeCycle += Time.deltaTime;

        if (projectileLifeCycle > 3)
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
