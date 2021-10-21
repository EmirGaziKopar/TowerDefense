using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AgentManager : MonoBehaviour
{
    // Dizi Yardýmýyla Tüm Ajanlar Alýnacak
    public GameObject Agent;
    public GameObject Tower;
    NavMeshAgent nMesh;


    void Start()
    {
        nMesh = Agent.GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        nMesh.SetDestination(Tower.transform.position);
    }
}
