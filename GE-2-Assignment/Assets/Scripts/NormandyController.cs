using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NormandyController : MonoBehaviour
{

    public NavMeshAgent agent;
    public Vector3 target = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        agent.updateUpAxis = false;
        agent.updateRotation = false;
        agent.SetDestination(target); 
    }

    // Update is called once per frame
    void Update()
    {
        agent.updateUpAxis = false;
    }
}
