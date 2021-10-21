using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileShoot : MonoBehaviour
{
    ShootControl shootControl;
    [SerializeField] GameObject pointerShootControl;
    Rigidbody rigidbody;
    [SerializeField]Transform GunTransform;
    public float time = 0f;
    [SerializeField] float speed;
    private void Start()
    {
        shootControl = pointerShootControl.GetComponent<ShootControl>();
        rigidbody = GetComponent<Rigidbody>();

    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            shoot();
        }
    }

    public void shoot()
    {
        if (time < 0.1)
        {
            time += Time.deltaTime;
            //Burada neden transform deðerini mermiden deðil de silahtan aldýk:
            //çünkü mermi hareket halindeyken unity uzayýnda yer çekimi kuvvetine maruz kalýr ve top'un yönü sürekli olarak deðiþir bu nedenle top düzensiz hareketler sergiler.
            Vector3 a = new Vector3(-GunTransform.forward.x, 0f, -GunTransform.forward.z); //Topun karsiya gitmesini saglayan z.
            rigidbody.velocity = a * speed;
        }
        
    }
}
