using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    GameObject dogOnScene;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !dogOnScene)
        {
            SpawnDog();
        }
    }
    void SpawnDog()
    {
        dogOnScene = Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
    }

    
}
