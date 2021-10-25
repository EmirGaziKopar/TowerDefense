using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MediumProjectileCreator : MonoBehaviour
{

    [SerializeField] Transform newprojectilePosition;
    [SerializeField] GameObject MediumProjectile; //mermi
    ProjectileShoot projectileShootMedium;
    [Range(0,2)]
    [SerializeField] float attackSpeed;
    float time;
    float projectileLifeCycle;
    bool controlEnemy; //alan içersinde düþman varsa mermi üretilecek

    // Start is called before the first frame update
    void Start()
    {
        projectileShootMedium = MediumProjectile.GetComponent<ProjectileShoot>();
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        

        
    }

    //Buraya yazmayý gözden geçir kasmaya neden olabilir.
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "enemy")
        {
            controlEnemy = true;
            if (time > attackSpeed)
            {
                projectileShootMedium.time = 0f;
                Debug.Log("Mermi üretildi");
                Instantiate(MediumProjectile, transform.position, transform.rotation);
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
