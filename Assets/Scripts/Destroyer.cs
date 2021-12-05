using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z > 40)
        {
            Destroy(gameObject);
        }
        else if(transform.position.z < -10 || transform.position.x < -20 || transform.position.x > 20)
        {
            Debug.Log("gg");
            Destroy(gameObject);
        }
    }
    void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }
}
