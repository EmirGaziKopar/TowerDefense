using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileShootMedium : MonoBehaviour
{
    new Rigidbody rigidbody;
    public Transform GunTransform;
    public float time = 0f;
    [SerializeField] float speed;
    float projectileLifeCycle;

    //daha sonra her silah�n daha �st versiyonun i�in geli�tirmelere devam edilebilir enum ile
    public enum SelectGun
    {
        low, medium, hard
    }

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        GunTransform = GameObject.Find("GunRotation2").GetComponent<Transform>(); //Buradaki de�erler gelmiyor
    }

    // Update is called once per frame
    void Update()
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

            Vector3 a = new Vector3(-GunTransform.forward.x, 0f, -GunTransform.forward.z); //Topun karsiya gitmesini saglayan z.
                                                                                           //Vector3 a = new Vector3(-GunRotation.gunTransform.forward.x, 0f, -GunRotation.gunTransform.forward.z);
            rigidbody.velocity = a * speed;



        }

        projectileLifeCycle += Time.deltaTime;

        if (projectileLifeCycle > 3)
        {
            Destroy(this.gameObject);
            projectileLifeCycle = 0;
        }


    }
}
