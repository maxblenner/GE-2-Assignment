using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    
    public float speed;
    public float FireRate;
    public GameObject parentObj;
    public GameObject target;
    public GameObject lazerPrefab;  
    

    private float nextFire = 2;

    float distance;
    Vector3 objPos;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        /*
        if(Time.time > nextFire)
        {
            nextFire = Time.time + FireRate;
            
            GameObject lazerObj = Instantiate (lazerPrefab);
            transform.position = Vector3.MoveTowards(lazerPrefab.transform.position, target.transform.position, 30 * Time.deltaTime);
        }
        */

        

        Vector3 targetDirection = target.transform.position - transform.position;
        float singleStep = speed * Time.deltaTime;

        Vector3 newDirection = Vector3.RotateTowards(transform.forward, targetDirection, singleStep, 0.0f);

        transform.rotation = Quaternion.LookRotation(newDirection);
        
        transform.position = Vector3.MoveTowards(parentObj.transform.position, target.transform.position, speed * Time.deltaTime);
        
        
    }
}
