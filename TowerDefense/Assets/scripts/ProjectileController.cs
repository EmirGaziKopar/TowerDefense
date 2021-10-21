using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileController : MonoBehaviour
{
    ProjectileShoot projectileShoot;
    [SerializeField] GameObject Projectile; //mermi
    [SerializeField] Transform newprojectilePosition;

    [Range(0, 2)]
    [SerializeField] float attackSpeed; 

    //
    //Vector3(276.369263,0,0)
    //Vector3(499.770996,-48.1041679,542.821655)
    float time;
    //butun projectile'larý burada kontrol et enum kullan.
    // Start is called before the first frame update
    public bool isGrounded;
    

    void Start()
    {
        isGrounded = false;
        projectileShoot = Projectile.GetComponent<ProjectileShoot>();
        
    }
    

    // Update is called once per frame
    void Update()
    {

        time += Time.deltaTime;
        if(time > attackSpeed)
        {
            projectileShoot.time = 0f;
            time = 0;
            Instantiate(Projectile, newprojectilePosition.position, newprojectilePosition.rotation);

        }

        
        
    }

    

}
