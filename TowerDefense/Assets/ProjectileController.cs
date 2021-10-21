using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileController : MonoBehaviour
{
    ProjectileController projectileController;
    [SerializeField] GameObject projectileControllerPointer;

    //butun projectile'larý burada kontrol et enum kullan.
    // Start is called before the first frame update

    void Start()
    {
        projectileController = projectileControllerPointer.GetComponent<ProjectileController>();
    }


    // Update is called once per frame
    void Update()
    {
      
    }
}
