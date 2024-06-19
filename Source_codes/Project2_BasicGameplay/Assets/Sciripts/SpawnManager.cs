using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    void SpawnRandownAnimal(){
        int animalIndex = Random.Range(0,animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX,spawnRangeX),0,SpawnPosZ);
        Instantiate(animalPrefabs[animalIndex], spawnPos,
            animalPrefabs[animalIndex].transform.rotation);
    }
    // Start is called before the first frame update
    public GameObject[ ] animalPrefabs; 
    private float spawnRangeX = 20;
    private float SpawnPosZ = 20;
    private float startDelay = 2; 
    private float sapwnInterval = 1f;
    private float time = 0;
    void Start()
    {
        InvokeRepeating("SpawnRandownAnimal",startDelay,sapwnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        /* Randomly generate animal index and spawn position with s key
        if (Input.GetKeyDown(KeyCode.S)) {
            SpawnRandownAnimal();
        }*/
        //time ++ ;
     
        Debug.Log(sapwnInterval);

    }
}

/*
Food_Organic_Carrot
Food_Steak_01
Food_Organic_Apple_03
Animal_Horse_Brown
Animal_Cow_Brown
Dog_BorderCollie_01
*/