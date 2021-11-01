using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NPC : MonoBehaviour
{
    private NavMeshAgent agent;
    public GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    public void CannonFire()
    {

    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(target.transform.position);
        CannonFire();
    }
}
