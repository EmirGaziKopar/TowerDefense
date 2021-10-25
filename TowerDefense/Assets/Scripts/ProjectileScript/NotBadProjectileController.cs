using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotBadProjectileController : MonoBehaviour
{
    [SerializeField] Transform newprojectilePosition;
    [SerializeField] GameObject NotBadProjectile; //mermi
    ProjectileShoot projectileShootNotBad;
    [Range(0, 2)]
    [SerializeField] float attackSpeed;
    float time;
    bool controlEnemy; //alan içersinde düþman varsa mermi üretilecek

    // Start is called before the first frame update
    void Start()
    {
        projectileShootNotBad = NotBadProjectile.GetComponent<ProjectileShoot>(); //hard projectile içersindeki zamana ulaþmak için
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
            Debug.Log("girdi");
            controlEnemy = true;
            if (time > attackSpeed)
            {
                projectileShootNotBad.time = 0f;
                Instantiate(NotBadProjectile, transform.position, transform.rotation);
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
