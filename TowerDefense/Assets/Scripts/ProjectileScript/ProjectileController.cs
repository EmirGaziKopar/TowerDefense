using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileController : MonoBehaviour
{
    [SerializeField] Transform newprojectilePosition;
    [SerializeField] GameObject soBadProjectile; //mermi
    ProjectileShoot projectileShootSoBad;
    [Range(0, 2)]
    [SerializeField] float attackSpeed;
    float time;
    bool controlEnemy; //alan içersinde düþman varsa mermi üretilecek
    

    // Start is called before the first frame update
    void Start()
    {
        projectileShootSoBad = soBadProjectile.GetComponent<ProjectileShoot>(); //hard projectile içersindeki zamana ulaþmak için
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "enemy")
        {
            controlEnemy = true;
            if (time > attackSpeed)
            {
                projectileShootSoBad.time = 0f;
                Instantiate(soBadProjectile, transform.position, transform.rotation);
                time = 0;

                //EnemyHp.tekMermiTekHasarSayacý = 0;
            }
            
        }
        
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "enemy")
        {
            controlEnemy = false;
        }
    }

    

}
