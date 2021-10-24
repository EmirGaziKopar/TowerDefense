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

    // Start is called before the first frame update
    void Start()
    {
        projectileShootMedium = HardProjectile.GetComponent<ProjectileShoot>(); //hard projectile içersindeki zamana ulaþmak için
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time > attackSpeed)
        {
            projectileShootMedium.time = 0f;
            time = 0;
            Instantiate(HardProjectile, transform.position, transform.rotation);
            //EnemyHp.tekMermiTekHasarSayacý = 0;
        }
    }
}
