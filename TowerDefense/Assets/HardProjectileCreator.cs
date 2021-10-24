using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HardProjectileCreator : MonoBehaviour
{
    [SerializeField] Transform newprojectilePosition;
    [SerializeField] GameObject HardProjectile; //mermi
    ProjectileShoot projectileShootMedium;
    [Range(0, 2)]
    [SerializeField] float attackSpeed;
    float time;
    bool controlEnemy; //alan i�ersinde d��man varsa mermi �retilecek

    // Start is called before the first frame update
    void Start()
    {
        controlEnemy = false;
        projectileShootMedium = HardProjectile.GetComponent<ProjectileShoot>(); //hard projectile i�ersindeki zamana ula�mak i�in
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time > attackSpeed)
        {
            projectileShootMedium.time = 0f;
            time = 0;
            if (controlEnemy == true)
            {
                Instantiate(HardProjectile, transform.position, transform.rotation);
            }
            //EnemyHp.tekMermiTekHasarSayac� = 0;
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "enemy")
        {
            controlEnemy = true;
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
