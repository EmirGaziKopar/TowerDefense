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

    // Start is called before the first frame update
    void Start()
    {
        projectileShootMedium = MediumProjectile.GetComponent<ProjectileShoot>();
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time > attackSpeed)
        {
            projectileShootMedium.time = 0f;
            time = 0;
            Instantiate(MediumProjectile, transform.position, transform.rotation);

        }

        
    }
}
