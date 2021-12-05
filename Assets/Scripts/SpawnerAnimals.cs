using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerAnimals : MonoBehaviour
{
    [SerializeField] GameObject[] animals;
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", 2, 1);
        InvokeRepeating("SpawnRandomAnimalRight", 2, 1);
        InvokeRepeating("SpawnRandomAnimalLeft", 2, 1);
    }

    void Update()
    {
        
    }
    void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, animals.Length);
        Vector3 spawnPositionHorizontal = new Vector3(Random.Range(-15, 15), 0, 20);
        Instantiate(animals[animalIndex], spawnPositionHorizontal, Quaternion.Euler(0, 180, 0));
       
    }
    void SpawnRandomAnimalRight()
    {
        int animalIndex = Random.Range(0, animals.Length);
        Vector3 spawnPositionVertical = new Vector3(20, 0, Random.Range(5, 15));
        Instantiate(animals[animalIndex], spawnPositionVertical, Quaternion.Euler(0, -90, 0)); 
    }
    void SpawnRandomAnimalLeft()
    {
        int animalIndex = Random.Range(0, animals.Length);
        Vector3 spawnPositionVertical = new Vector3(-20, 0, Random.Range(5, 15));
        Instantiate(animals[animalIndex], spawnPositionVertical, Quaternion.Euler(0, 90, 0));
    }
}
