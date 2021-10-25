using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class DestinationManager : MonoBehaviour
{


    [SerializeField]  Transform DestinationTower;
    NavMeshAgent Ajan;
    
    // Start is called before the first frame update
    void Start()
    {
        Ajan = GetComponent<NavMeshAgent>();
        DestinationTower = GameObject.Find("Tower").GetComponent<Transform>();
      
    }

    // Update is called once per frame
    void Update()
    {
        Ajan.SetDestination(DestinationTower.transform.position);
    }
}
