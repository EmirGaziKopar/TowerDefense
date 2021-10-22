using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileController : MonoBehaviour
{
    ProjectileShoot projectileShoot;
    [SerializeField] GameObject Projectile; //mermi
    [SerializeField] GameObject ProjectileMedium; //mermi
    [SerializeField] GameObject ProjectileHard; //mermi

    [SerializeField] Transform newprojectilePosition;

    [Range(0, 2)]
    [SerializeField] float attackSpeed;
    [Range(0, 2)]
    [SerializeField] float attackSpeedMedium;
    [Range(0, 2)]
    [SerializeField] float attackSpeedHard;
    [SerializeField] ProjectileShoot.SelectGun selectGun;
    //
    //Vector3(276.369263,0,0)
    //Vector3(499.770996,-48.1041679,542.821655)
    float time;
    //butun projectile'lar� burada kontrol et enum kullan.
    // Start is called before the first frame update
    public bool isGrounded;
    

    void Start()
    {
        isGrounded = false;

        if(selectGun == ProjectileShoot.SelectGun.low)
        {
            projectileShoot = Projectile.GetComponent<ProjectileShoot>();
        }
        
        
    }
    

    // Update is called once per frame
    void Update()
    {


        if(selectGun == ProjectileShoot.SelectGun.low)
        {
            time += Time.deltaTime;
            if (time > attackSpeed)
            {
                projectileShoot.time = 0f;
                time = 0;
                Instantiate(Projectile, transform.position, transform.rotation);

            }
        }
        

        
        
    }

    

}
