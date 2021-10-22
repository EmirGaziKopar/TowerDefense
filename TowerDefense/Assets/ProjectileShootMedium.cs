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

    //daha sonra her silahýn daha üst versiyonun için geliþtirmelere devam edilebilir enum ile
    public enum SelectGun
    {
        low, medium, hard
    }

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        GunTransform = GameObject.Find("GunRotation2").GetComponent<Transform>(); //Buradaki deðerler gelmiyor
    }

    // Update is called once per frame
    void Update()
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
